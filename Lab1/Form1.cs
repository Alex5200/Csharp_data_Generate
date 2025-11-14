using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private List<DataRecord> records = new List<DataRecord>();
        private PiecewiseLinearDistribution piecewiseDist;
        private readonly Random rng = new Random();

        // === ПАРАМЕТРЫ В КОДЕ ===
        private readonly (double, double) uniformParams = (0, 1);
        private readonly (double, double) normalParams = (0, 1);      // mean, stddev
        private readonly (double, double, double) triangularParams = (0, 1, 0.7); // min, max, mode

        public Form1()
        {
            InitializeComponent();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            piecewiseDist = new PiecewiseLinearDistribution(
                  new double[] { 0, 0.5, 1.0, 1.5, 2.0 },
                  new double[] { 0, 1, 2, 1, 0 },
                  rng
              );
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            records.Clear();
            int n = (int)howManyRecords.Value;
            logBox.Clear();

            for (int i = 0; i < n; i++)
            {
                var r = new DataRecord();
                bool ch2Done = false, ch4Done = false;

                // Ch1
                if (comboBoxDist1.Text == "Нормальное")
                {
                    double meanN = double.Parse(textBox1.Text);
                    double stdN = double.Parse(textBox2.Text);
                    var (x, y) = NormalBoxMuller(meanN, stdN);
                    r.Ch1 = x;
                    r.Ch2 = y;
                    ch2Done = true;
                }
                else
                {
                    r.Ch1 = Generate(comboBoxDist1.Text);
                }

                if (!ch2Done)
                    r.Ch2 = Generate(comboBoxDist2.Text);

                // Ch3
                if (comboBoxDist3.Text == "Нормальное")
                {
                    var (x, y) = NormalBoxMuller(normalParams.Item1, normalParams.Item2);
                    r.Ch3 = x;
                    r.Ch4 = y;
                    ch4Done = true;
                }
                else
                {
                    r.Ch3 = Generate(comboBoxDist3.Text);
                }

                if (!ch4Done)
                    r.Ch4 = Generate(comboBoxDist4.Text);

                records.Add(r);
            }

            logBox.AppendText($"Сгенерировано {records.Count} записей.\n");
            dataGridView1.DataSource = records.Select(x => new {
                Ch1 = x.Ch1?.ToString("F4"),
                Ch2 = x.Ch2?.ToString("F4"),
                Ch3 = x.Ch3?.ToString("F4"),
                Ch4 = x.Ch4?.ToString("F4")
            }).ToList();
            DrawVisualization();
        }
       
        private double? Generate(string dist)
        {
            try
            {
                switch (dist)
                {
                    case "Равномерное":
                        double aU = double.Parse(textBox3.Text);
                        double bU = double.Parse(textBox4.Text);
                        if (aU >= bU) throw new ArgumentException("Min >= Max для равномерного");
                        return aU + (bU - aU) * rng.NextDouble();

                    case "Нормальное":
                        // Нормальное генерируется парами, но если вызвано напрямую — сделаем отдельный вызов
                        double meanN = double.Parse(textBox1.Text);
                        double stdN = double.Parse(textBox2.Text);
                        if (stdN < 0) throw new ArgumentException("σ не может быть < 0");
                        var (x, _) = NormalBoxMuller(meanN, stdN);
                        return x;

                    case "Треугольное":
                        double aT = double.Parse(A_Triangular.Text);
                        double bT = double.Parse(B_Triangular.Text);
                        double cT = double.Parse(C_Triangular.Text);
                        if (aT >= bT) throw new ArgumentException("min >= max в треугольном");
                        if (cT < aT || cT > bT) throw new ArgumentException("mode вне [min, max]");
                        return Triangular(aT, bT, cT);

                    case "Кусочно-линейное":
                        // Для упрощения — можно оставить фиксированным или добавить JSON-ввод позже
                        if (piecewiseDist == null)
                        {
                            // Инициализируем один раз на основе UI или кода
                            double[] x1 = { 0, 0.5, 1.0, 1.5, 2.0 };
                            double[] y1 = { 0, 1, 2, 1, 0 };
                            piecewiseDist = new PiecewiseLinearDistribution(x1, y1, rng);
                        }
                        return piecewiseDist.Sample();

                    default:
                        return rng.NextDouble();
                }
            }
            catch (Exception ex)
            {
                logBox.AppendText($"Ошибка в распределении '{dist}': {ex.Message}\n");
                return null;
            }
        }

        private (double, double) NormalBoxMuller(double mean, double stddev)
        {
            double u1 = rng.NextDouble(), u2 = rng.NextDouble();
            double z0 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);
            double z1 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);
            return (mean + stddev * z0, mean + stddev * z1);
        }

        private double Triangular(double a, double b, double c)
        {
            if (a >= b) throw new ArgumentException("a must be < b");
            if (c < a || c > b) throw new ArgumentException("c must be between a and b");

            double u = rng.NextDouble();
            double denominator = b - a;

            if (u < (c - a) / denominator)
            {
                return a + Math.Sqrt(u * denominator * (c - a));
            }
            else
            {
                return b - Math.Sqrt((1 - u) * denominator * (b - c));
            }
        }

        private void DrawVisualization()
        {
            bool drawHist = chkHist1.Checked || chkHist2.Checked || chkHist3.Checked || chkHist4.Checked;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                if (drawHist)
                    DrawHistogram(g, bmp);
                else
                    DrawXY(g, bmp);
            }
            pictureBox1.Image = bmp;
        }

        private void DrawXY(Graphics g, Bitmap bmp)
        {
            var xs = records.Select(r => r.Ch1).Where(v => v.HasValue).Select(v => v.Value).ToList();
            var ys = records.Select(r => r.Ch2).Where(v => v.HasValue).Select(v => v.Value).ToList();
            if (xs.Count == 0 || ys.Count == 0) return;
            double xMin = xs.Min(), xMax = xs.Max(), yMin = ys.Min(), yMax = ys.Max();
            if (xMin == xMax) xMax += 1; if (yMin == yMax) yMax += 1;
            for (int i = 0; i < xs.Count && i < ys.Count; i++)
            {
                float px = (float)((xs[i] - xMin) / (xMax - xMin) * bmp.Width);
                float py = (float)(bmp.Height - (ys[i] - yMin) / (yMax - yMin) * bmp.Height);
                g.FillEllipse(Brushes.Blue, px - 1, py - 1, 3, 3);
            }
        }

        private void DrawHistogram(Graphics g, Bitmap bmp)
        {
            var channels = new List<(string name, List<double?> data, Color color)>();
            if (chkHist1.Checked) channels.Add(("Ch1", records.Select(r => r.Ch1).ToList(), Color.Red));
            if (chkHist2.Checked) channels.Add(("Ch2", records.Select(r => r.Ch2).ToList(), Color.Green));
            if (chkHist3.Checked) channels.Add(("Ch3", records.Select(r => r.Ch3).ToList(), Color.Blue));
            if (chkHist4.Checked) channels.Add(("Ch4", records.Select(r => r.Ch4).ToList(), Color.Orange));
            if (channels.Count == 0) return;
            chkHist1.BackColor = Color.Red;
            chkHist2.BackColor = Color.Green;
            chkHist3.BackColor = Color.Blue;
            chkHist4.BackColor = Color.Orange;
            var all = channels.SelectMany(c => c.data.Where(v => v.HasValue).Select(v => v.Value)).ToList();
            if (all.Count == 0) return;
            double minV = all.Min(), maxV = all.Max();
            if (minV == maxV) maxV += 1;

            int bins = 40;
            double maxCount = 0;
            var histos = new List<(double[] counts, Color color)>();

            foreach (var (_, data, color) in channels)
            {
                double[] counts = new double[bins];
                foreach (double? v in data)
                {
                    if (!v.HasValue) continue;
                    int bin = (int)((v.Value - minV) / (maxV - minV) * bins);
                    bin = Math.Max(0, Math.Min(bins - 1, bin));
                    counts[bin]++;
                }
                maxCount = Math.Max(maxCount, counts.Max());
                histos.Add((counts, color));
            }

            for (int i = 0; i < bins; i++)
            {
                float x = i * ((float)bmp.Width / bins);
                float w = (float)bmp.Width / bins / histos.Count;
                for (int j = 0; j < histos.Count; j++)
                {
                    float h = (float)(histos[j].counts[i] / maxCount * bmp.Height);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(120, histos[j].color)),
                                    x + j * w, bmp.Height - h, w, h);
                }
            }
        }
        private void DrawStatsWithOpenCV()
        {
            // Выбираем первый отмеченный канал из гистограммы
            string targetChannel = "Ch1";
            if (chkHist2.Checked) targetChannel = "Ch2";
            if (chkHist3.Checked) targetChannel = "Ch3";
            if (chkHist4.Checked) targetChannel = "Ch4";

            var data = GetChannel(targetChannel);
            if (data.Count == 0)
            {
                pictureBox1.Image = null;
                return;
            }

            // === Статистика ===
            var sorted = data.OrderBy(x => x).ToList();
            double mean = 1;
            try
            {
                 mean = (double)data.Average();

            }
            catch (Exception ex)
            {
                 mean = 1;

                logBox.Text += "\n"+ex.Message;

            }
            double median = (double)sorted[sorted.Count / 2];
            double minVal = (double)data.Min(), maxVal = (double)data.Max();
            double range = maxVal - minVal;
            double stddev = Math.Sqrt(data.Average(x => Math.Pow((double)(x - mean), 2)));

            // Мода с группировкой 0.001
            double binWidth = 0.001;
            var modeGroup = data
                .GroupBy(x => Math.Round((double)(x / binWidth)) * binWidth)
                .OrderByDescending(g => g.Count())
                .First();
            double mode = modeGroup.Key;

            // 90-й процентиль
            int p90Index = (int)(0.9 * (sorted.Count - 1));
            double percentile90 = (double)sorted[p90Index];

            // === Гистограмма ===
            int bins = 50;
            if (minVal == maxVal) maxVal = minVal + 1e-6;
            double histMin = minVal;
            double histMax = maxVal;
            double[] histValues = new double[bins];

            foreach (double v in data)
            {
                int bin = (int)((v - histMin) / (histMax - histMin) * bins);
                bin = Math.Max(0, Math.Min(bins - 1, bin));
                histValues[bin]++;
            }
            double maxHistCount = histValues.Max();

            // === Создаём изображение OpenCV ===
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            if (width <= 0 || height <= 0) return;

            var mat = new Mat(height, width, MatType.CV_8UC3, new Scalar(255, 255, 255)); // белый фон

            // Рисуем гистограмму (в нижних 70% высоты)
            int histHeight = (int)(height * 0.7);
            for (int i = 0; i < bins; i++)
            {
                double count = histValues[i];
                if (count == 0) continue;

                double binHeight = (count / maxHistCount) * histHeight;
                int x1 = (int)(i * (width / (double)bins));
                int x2 = (int)((i + 1) * (width / (double)bins));
                int y1 = height - (int)binHeight;
                int y2 = height;

                Cv2.Rectangle(mat, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), new Scalar(65, 105, 225), -1); // SteelBlue в BGR
            }

            
            Cv2.PutText(mat, $"Min: {histMin:F3}", new OpenCvSharp.Point(5, height - 5), HersheyFonts.HersheySimplex, 0.5, new Scalar(0, 0, 0), 1);
            Cv2.PutText(mat, $"Max: {histMax:F3}", new OpenCvSharp.Point(width - 100, height - 5), HersheyFonts.HersheySimplex, 0.5, new Scalar(0, 0, 0), 1);

            
            var statsText = new[]
            {
                $"Chanel: {targetChannel}",
                $"Sredee:   {mean:F4}",
                $"Mediana:   {median:F4}",
                $"Moda:      {mode:F4}",
                $"Pazmach:    {range:F4}",
                $"CKO:       {stddev:F4}",
                $"90% перц.: {percentile90:F4}"
            };

            int yText = 20;
            foreach (string line in statsText)
            {
                Cv2.PutText(mat, line, new OpenCvSharp.Point(10, yText), HersheyFonts.HersheySimplex, 0.6, new Scalar(0, 0, 0), 1);
                yText += 22;
            }

            // Преобразуем Mat → Bitmap
            var bitmap = (mat);
            pictureBox1.Image = BitmapConverter.ToBitmap(bitmap); // копия, чтобы Mat можно было освободить
        }

        private void UpdateDataGrid()
        {
            var source = records.Select(r => new
            {
                Ch1 = r.Ch1?.ToString("F4"),
                Ch2 = r.Ch2?.ToString("F4"),
                Ch3 = r.Ch3?.ToString("F4"),
                Ch4 = r.Ch4?.ToString("F4")
            }).ToList();
            dataGridView1.DataSource = source;
        }
        private List<double?> GetChannel(string channelName)
        {
            switch (channelName)
            {
                case "Ch1":
                    return records.Select(r => r.Ch1).ToList();
                case "Ch2":
                    return records.Select(r => r.Ch2).ToList();
                case "Ch3":
                    return records.Select(r => r.Ch3).ToList();
                case "Ch4":
                    return records.Select(r => r.Ch4).ToList();
                default:
                    return new List<double?>();
            }
        }
        private void btnStats_Click(object sender, EventArgs e)
        {

            // Выбираем первый отмеченный канал
            string targetChannel = null;
            if (chkHist1.Checked) targetChannel = "Ch1";
            else if (chkHist2.Checked) targetChannel = "Ch2";
            else if (chkHist3.Checked) targetChannel = "Ch3";
            else if (chkHist4.Checked) targetChannel = "Ch4";
            else targetChannel = "Ch1"; // fallback

            var data = GetChannel(targetChannel)
                .Where(v => v.HasValue)
                .Select(v => v.Value)
                .OrderBy(v => v)
                .ToList();

            if (data.Count == 0)
            {
                txtStats.Text = "Нет данных для вычисления статистики.";
                return;
            }

            double mean = data.Average();
            double median = data[data.Count / 2];
            double min = data.Min(), max = data.Max();
            double range = max - min;
            double stddev = Math.Sqrt(data.Average(v => Math.Pow(v - mean, 2)));

            // Мода с группировкой по 0.001 (как в ТЗ)
            double binWidth = 0.001;
            var modeGroup = data
                .GroupBy(v => Math.Round(v / binWidth) * binWidth)
                .OrderByDescending(g => g.Count())
                .First();
            double mode = modeGroup.Key;

            // Процентиль (например, 90-й)
            int percentileIndex = (int)(0.9 * (data.Count - 1));
            double percentile90 = data[percentileIndex];

            logBox.Text += $@"Среднее:      {mean:F4}
            Медиана:      {median:F4}
            Мода:         {mode:F4}
            Размах:       {range:F4}
            СКО:          {stddev:F4}
            90-й процентиль: {percentile90:F4}";
            DrawStatsWithOpenCV();
        }
        private void DrawStatsAndHistogram()
        {
            if (records == null || records.Count == 0) return;

            // Выбираем канал (например, Ch1)
            var data = records.Select(r => r.Ch1).Where(v => v.HasValue).Select(v => v.Value).ToList();
            if (data.Count == 0) return;

            // Статистика
            double mean = data.Average();
            double median = data.OrderBy(x => x).ElementAt(data.Count / 2);
            double min = data.Min(), max = data.Max();
            double range = max - min;
            double stddev = Math.Sqrt(data.Average(v => Math.Pow(v - mean, 2)));

            // Гистограмма
            int bins = 40;
            double binWidth = (max - min) / bins;
            int[] hist = new int[bins];
            foreach (double v in data)
            {
                int bin = (int)((v - min) / binWidth);
                if (bin >= bins) bin = bins - 1;
                if (bin >= 0) hist[bin]++;
            }
            int maxCount = hist.Max();

            // Рисуем
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (var font = new Font("Arial", 10))
            using (var brush = Brushes.Black)
            {
                g.Clear(Color.White);

                // Гистограмма
                for (int i = 0; i < bins; i++)
                {
                    float x = i * (bmp.Width / (float)bins);
                    float w = bmp.Width / (float)bins;
                    float h = (float)(hist[i] / (double)maxCount * (bmp.Height * 0.7));
                    g.FillRectangle(Brushes.SteelBlue, x, bmp.Height - h, w, h);
                }

                // Статистика (справа)
                string statsText = $@"Среднее: {mean:F4}
Медиана: {median:F4}
Размах: {range:F4}
СКО: {stddev:F4}";
                g.DrawString(statsText, font, brush, new PointF(10, 10));
            }

            pictureBox1.Image = bmp;
        }
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV|*.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                using (var w = new StreamWriter(sfd.FileName))
                {
                    w.WriteLine("Ch1,Ch2,Ch3,Ch4");
                    foreach (var r in records)
                    {
                        w.WriteLine($"{r.Ch1?.ToString("F4")},{r.Ch2?.ToString("F4")},{r.Ch3?.ToString("F4")},{r.Ch4?.ToString("F4")}");
                    }
                }
                logBox.AppendText("Данные сохранены в CSV\n");
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            string name = $"picture{DateTime.Now:yyyyMMddHHmmss}{rng.Next(1000, 10000)}.png";
            pictureBox1.Image?.Save(name);
            logBox.AppendText($"Скриншот: {name}\n");
        }

        private void chkHist1_CheckedChanged(object sender, EventArgs e) => DrawVisualization();
        private void chkHist2_CheckedChanged(object sender, EventArgs e) => DrawVisualization();
        private void chkHist3_CheckedChanged(object sender, EventArgs e) => DrawVisualization();
        private void chkHist4_CheckedChanged(object sender, EventArgs e) => DrawVisualization();

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            DrawStatsWithOpenCV();
        }

        private void comboBoxDist1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void B_Triangular_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class PiecewiseLinearDistribution
    {
        private readonly double[] _x;
        private readonly double[] _pdf;
        private readonly double[] _cdf;
        private readonly Random _random;

        public PiecewiseLinearDistribution(double[] x, double[] y, Random random = null)
        {
            if (x == null || y == null || x.Length != y.Length || x.Length < 2)
                throw new ArgumentException("x и y должны быть одинаковой длины и содержать ≥2 точек.");
            for (int i = 1; i < x.Length; i++)
                if (x[i] <= x[i - 1])
                    throw new ArgumentException("x должен быть строго возрастающим.");

            _x = (double[])x.Clone();
            _pdf = (double[])y.Clone();
            _random = random ?? new Random();

            // Нормализация
            double area = 0.0;
            for (int i = 0; i < _x.Length - 1; i++)
            {
                double w = _x[i + 1] - _x[i];
                double avg = (_pdf[i] + _pdf[i + 1]) / 2.0;
                area += w * avg;
            }
            if (area <= 0) throw new ArgumentException("Площадь под кривой должна быть > 0.");
            for (int i = 0; i < _pdf.Length; i++)
                _pdf[i] /= area;

            // CDF
            _cdf = new double[_x.Length];
            _cdf[0] = 0.0;
            for (int i = 0; i < _x.Length - 1; i++)
            {
                double w = _x[i + 1] - _x[i];
                double segArea = w * (_pdf[i] + _pdf[i + 1]) / 2.0;
                _cdf[i + 1] = _cdf[i] + segArea;
            }
        }

        public double Sample()
        {
            double u = _random.NextDouble();
            int i = Array.BinarySearch(_cdf, u);
            if (i < 0) i = ~i - 1;
            i = Math.Max(0, Math.Min(i, _cdf.Length - 2));

            double x0 = _x[i], x1 = _x[i + 1];
            double y0 = _pdf[i], y1 = _pdf[i + 1];
            double c0 = _cdf[i];
            double du = u - c0;

            if (Math.Abs(y0 - y1) < 1e-12)
            {
                return x0 + du / y0;
            }
            else
            {
                double a = (y1 - y0) / (x1 - x0);
                double b = y0;
                // Решаем: b * dx + 0.5 * a * dx^2 = du
                double disc = b * b + 2 * a * du;
                if (disc < 0) disc = 0;
                double dx = (-b + Math.Sqrt(disc)) / a;
                return x0 + dx;
            }
        }
    }
    public class DataRecord
    {
        public double? Ch1 { get; set; }
        public double? Ch2 { get; set; }
        public double? Ch3 { get; set; }
        public double? Ch4 { get; set; }
    }
}