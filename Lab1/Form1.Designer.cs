namespace Lab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxChannels = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDist1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDist2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDist3 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDist4 = new System.Windows.Forms.ComboBox();
            this.howManyRecords = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.groupBoxHistogram = new System.Windows.Forms.GroupBox();
            this.chkHist1 = new System.Windows.Forms.CheckBox();
            this.chkHist2 = new System.Windows.Forms.CheckBox();
            this.chkHist3 = new System.Windows.Forms.CheckBox();
            this.chkHist4 = new System.Windows.Forms.CheckBox();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logBox = new System.Windows.Forms.TextBox();
            this.txtStats = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.A_Triangular = new System.Windows.Forms.TextBox();
            this.B_Triangular = new System.Windows.Forms.TextBox();
            this.C_Triangular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Нормальное = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBoxChannels.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howManyRecords)).BeginInit();
            this.groupBoxHistogram.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Нормальное.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChannels
            // 
            this.groupBoxChannels.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxChannels.Location = new System.Drawing.Point(12, 12);
            this.groupBoxChannels.Name = "groupBoxChannels";
            this.groupBoxChannels.Size = new System.Drawing.Size(200, 180);
            this.groupBoxChannels.TabIndex = 0;
            this.groupBoxChannels.TabStop = false;
            this.groupBoxChannels.Text = "Каналы";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 161);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDist1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ch1:";
            // 
            // comboBoxDist1
            // 
            this.comboBoxDist1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDist1.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное",
            "Треугольное",
            "Кусочно-линейное"});
            this.comboBoxDist1.Location = new System.Drawing.Point(50, 3);
            this.comboBoxDist1.Name = "comboBoxDist1";
            this.comboBoxDist1.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDist1.TabIndex = 1;
            this.comboBoxDist1.SelectedIndexChanged += new System.EventHandler(this.comboBoxDist1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxDist2);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 30);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ch2:";
            // 
            // comboBoxDist2
            // 
            this.comboBoxDist2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDist2.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное",
            "Треугольное",
            "Кусочно-линейное"});
            this.comboBoxDist2.Location = new System.Drawing.Point(50, 3);
            this.comboBoxDist2.Name = "comboBoxDist2";
            this.comboBoxDist2.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDist2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBoxDist3);
            this.panel3.Location = new System.Drawing.Point(3, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 30);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ch3:";
            // 
            // comboBoxDist3
            // 
            this.comboBoxDist3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDist3.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное",
            "Треугольное",
            "Кусочно-линейное"});
            this.comboBoxDist3.Location = new System.Drawing.Point(50, 3);
            this.comboBoxDist3.Name = "comboBoxDist3";
            this.comboBoxDist3.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDist3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.comboBoxDist4);
            this.panel4.Location = new System.Drawing.Point(3, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 30);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ch4:";
            // 
            // comboBoxDist4
            // 
            this.comboBoxDist4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDist4.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное",
            "Треугольное",
            "Кусочно-линейное"});
            this.comboBoxDist4.Location = new System.Drawing.Point(50, 3);
            this.comboBoxDist4.Name = "comboBoxDist4";
            this.comboBoxDist4.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDist4.TabIndex = 1;
            // 
            // howManyRecords
            // 
            this.howManyRecords.Location = new System.Drawing.Point(110, 200);
            this.howManyRecords.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.howManyRecords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howManyRecords.Name = "howManyRecords";
            this.howManyRecords.Size = new System.Drawing.Size(102, 20);
            this.howManyRecords.TabIndex = 2;
            this.howManyRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelCount
            // 
            this.labelCount.Location = new System.Drawing.Point(12, 200);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(100, 23);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Кол-во записей:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 230);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(87, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Генерировать";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(105, 230);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Статистика";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // groupBoxHistogram
            // 
            this.groupBoxHistogram.Controls.Add(this.chkHist1);
            this.groupBoxHistogram.Controls.Add(this.chkHist2);
            this.groupBoxHistogram.Controls.Add(this.chkHist3);
            this.groupBoxHistogram.Controls.Add(this.chkHist4);
            this.groupBoxHistogram.Location = new System.Drawing.Point(8, 360);
            this.groupBoxHistogram.Name = "groupBoxHistogram";
            this.groupBoxHistogram.Size = new System.Drawing.Size(206, 123);
            this.groupBoxHistogram.TabIndex = 5;
            this.groupBoxHistogram.TabStop = false;
            this.groupBoxHistogram.Text = "Гистограмма";
            // 
            // chkHist1
            // 
            this.chkHist1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkHist1.Checked = true;
            this.chkHist1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHist1.Location = new System.Drawing.Point(10, 20);
            this.chkHist1.Name = "chkHist1";
            this.chkHist1.Size = new System.Drawing.Size(71, 24);
            this.chkHist1.TabIndex = 0;
            this.chkHist1.Text = "Ch1";
            this.chkHist1.CheckedChanged += new System.EventHandler(this.chkHist1_CheckedChanged);
            // 
            // chkHist2
            // 
            this.chkHist2.Checked = true;
            this.chkHist2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHist2.Location = new System.Drawing.Point(12, 50);
            this.chkHist2.Name = "chkHist2";
            this.chkHist2.Size = new System.Drawing.Size(69, 24);
            this.chkHist2.TabIndex = 1;
            this.chkHist2.Text = "Ch2";
            this.chkHist2.CheckedChanged += new System.EventHandler(this.chkHist2_CheckedChanged);
            // 
            // chkHist3
            // 
            this.chkHist3.Checked = true;
            this.chkHist3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHist3.Location = new System.Drawing.Point(12, 80);
            this.chkHist3.Name = "chkHist3";
            this.chkHist3.Size = new System.Drawing.Size(69, 24);
            this.chkHist3.TabIndex = 2;
            this.chkHist3.Text = "Ch3";
            this.chkHist3.CheckedChanged += new System.EventHandler(this.chkHist3_CheckedChanged);
            // 
            // chkHist4
            // 
            this.chkHist4.Checked = true;
            this.chkHist4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHist4.Location = new System.Drawing.Point(82, 19);
            this.chkHist4.Name = "chkHist4";
            this.chkHist4.Size = new System.Drawing.Size(104, 24);
            this.chkHist4.TabIndex = 3;
            this.chkHist4.Text = "Ch4";
            this.chkHist4.CheckedChanged += new System.EventHandler(this.chkHist4_CheckedChanged);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(139, 489);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(75, 23);
            this.btnExportCSV.TabIndex = 6;
            this.btnExportCSV.Text = "Сохранить CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(14, 491);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(75, 23);
            this.btnScreenshot.TabIndex = 7;
            this.btnScreenshot.Text = "Скриншот";
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Нормальное);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(220, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 400);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.pictureBox1);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Size = new System.Drawing.Size(562, 374);
            this.tabPageGraph.TabIndex = 0;
            this.tabPageGraph.Text = "График";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(562, 374);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(562, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.C_Triangular);
            this.tabPage1.Controls.Add(this.B_Triangular);
            this.tabPage1.Controls.Add(this.A_Triangular);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(562, 374);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Треугольное распределение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(8, 516);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(778, 60);
            this.logBox.TabIndex = 9;
            // 
            // txtStats
            // 
            this.txtStats.Location = new System.Drawing.Point(220, 450);
            this.txtStats.Multiline = true;
            this.txtStats.Name = "txtStats";
            this.txtStats.ReadOnly = true;
            this.txtStats.Size = new System.Drawing.Size(570, 60);
            this.txtStats.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Треугольное: min / max / mode";
            // 
            // A_Triangular
            // 
            this.A_Triangular.Location = new System.Drawing.Point(6, 33);
            this.A_Triangular.Name = "A_Triangular";
            this.A_Triangular.Size = new System.Drawing.Size(165, 20);
            this.A_Triangular.TabIndex = 1;
            this.A_Triangular.Text = "0";
            // 
            // B_Triangular
            // 
            this.B_Triangular.Location = new System.Drawing.Point(6, 59);
            this.B_Triangular.Name = "B_Triangular";
            this.B_Triangular.Size = new System.Drawing.Size(165, 20);
            this.B_Triangular.TabIndex = 3;
            this.B_Triangular.Text = "1";
            this.B_Triangular.TextChanged += new System.EventHandler(this.B_Triangular_TextChanged);
            // 
            // C_Triangular
            // 
            this.C_Triangular.Location = new System.Drawing.Point(6, 85);
            this.C_Triangular.Name = "C_Triangular";
            this.C_Triangular.Size = new System.Drawing.Size(165, 20);
            this.C_Triangular.TabIndex = 4;
            this.C_Triangular.Text = "0.7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MIN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MAX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "MODE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab1.Properties.Resources.Triangular;
            this.pictureBox2.Location = new System.Drawing.Point(6, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(421, 235);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Нормальное
            // 
            this.Нормальное.Controls.Add(this.textBox2);
            this.Нормальное.Controls.Add(this.textBox1);
            this.Нормальное.Controls.Add(this.label9);
            this.Нормальное.Location = new System.Drawing.Point(4, 22);
            this.Нормальное.Name = "Нормальное";
            this.Нормальное.Size = new System.Drawing.Size(562, 374);
            this.Нормальное.TabIndex = 3;
            this.Нормальное.Text = "Нормальное";
            this.Нормальное.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(562, 374);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Равномерное";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Нормальное: μ / σ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Равномерное: от / до";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 259);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 20);
            this.textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBoxChannels);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.howManyRecords);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.groupBoxHistogram);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.txtStats);
            this.Name = "Form1";
            this.Text = "Ляхов Александр Лабораторная № 1 Генератор данных (упрощённый)";
            this.groupBoxChannels.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.howManyRecords)).EndInit();
            this.groupBoxHistogram.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Нормальное.ResumeLayout(false);
            this.Нормальное.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChannels;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDist1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDist2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDist3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDist4;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown howManyRecords;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.GroupBox groupBoxHistogram;
        private System.Windows.Forms.CheckBox chkHist1;
        private System.Windows.Forms.CheckBox chkHist2;
        private System.Windows.Forms.CheckBox chkHist3;
        private System.Windows.Forms.CheckBox chkHist4;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox txtStats;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A_Triangular;
        private System.Windows.Forms.TextBox B_Triangular;
        private System.Windows.Forms.TextBox C_Triangular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage Нормальное;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
    }
}