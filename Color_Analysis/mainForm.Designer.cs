
namespace Color_Analysis
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbLightSource = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLaw = new System.Windows.Forms.ComboBox();
            this.cbLightProd = new System.Windows.Forms.ComboBox();
            this.cbLightCol = new System.Windows.Forms.ComboBox();
            this.gbLens1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumLens1T = new System.Windows.Forms.NumericUpDown();
            this.cbLens1T = new System.Windows.Forms.ComboBox();
            this.cbLens1Prod = new System.Windows.Forms.ComboBox();
            this.cbLens1Col = new System.Windows.Forms.ComboBox();
            this.gbLens2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumLens2T = new System.Windows.Forms.NumericUpDown();
            this.cbLens2Col = new System.Windows.Forms.ComboBox();
            this.cbLens2T = new System.Windows.Forms.ComboBox();
            this.cbLens2Prod = new System.Windows.Forms.ComboBox();
            this.ckLens2 = new System.Windows.Forms.CheckBox();
            this.gbLens3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumLens3T = new System.Windows.Forms.NumericUpDown();
            this.cbLens3Col = new System.Windows.Forms.ComboBox();
            this.cbLens3Prod = new System.Windows.Forms.ComboBox();
            this.cbLens3T = new System.Windows.Forms.ComboBox();
            this.ckLens3 = new System.Windows.Forms.CheckBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.TrsResult = new System.Windows.Forms.TextBox();
            this.CyResult = new System.Windows.Forms.TextBox();
            this.CxResult = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.chtResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbGraph = new System.Windows.Forms.GroupBox();
            this.gbLightSource.SuspendLayout();
            this.gbLens1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens1T)).BeginInit();
            this.gbLens2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens2T)).BeginInit();
            this.gbLens3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens3T)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtResult)).BeginInit();
            this.gbGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLightSource
            // 
            this.gbLightSource.Controls.Add(this.label3);
            this.gbLightSource.Controls.Add(this.label2);
            this.gbLightSource.Controls.Add(this.label1);
            this.gbLightSource.Controls.Add(this.cbLaw);
            this.gbLightSource.Controls.Add(this.cbLightProd);
            this.gbLightSource.Controls.Add(this.cbLightCol);
            this.gbLightSource.Location = new System.Drawing.Point(12, 40);
            this.gbLightSource.Name = "gbLightSource";
            this.gbLightSource.Size = new System.Drawing.Size(498, 72);
            this.gbLightSource.TabIndex = 0;
            this.gbLightSource.TabStop = false;
            this.gbLightSource.Text = "Light Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Law";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color";
            // 
            // cbLaw
            // 
            this.cbLaw.FormattingEnabled = true;
            this.cbLaw.Location = new System.Drawing.Point(354, 44);
            this.cbLaw.Name = "cbLaw";
            this.cbLaw.Size = new System.Drawing.Size(138, 22);
            this.cbLaw.TabIndex = 2;
            this.cbLaw.SelectedIndexChanged += new System.EventHandler(this.cbLaw_Change);
            // 
            // cbLightProd
            // 
            this.cbLightProd.FormattingEnabled = true;
            this.cbLightProd.Location = new System.Drawing.Point(133, 44);
            this.cbLightProd.Name = "cbLightProd";
            this.cbLightProd.Size = new System.Drawing.Size(215, 22);
            this.cbLightProd.TabIndex = 1;
            // 
            // cbLightCol
            // 
            this.cbLightCol.FormattingEnabled = true;
            this.cbLightCol.Location = new System.Drawing.Point(6, 44);
            this.cbLightCol.Name = "cbLightCol";
            this.cbLightCol.Size = new System.Drawing.Size(121, 22);
            this.cbLightCol.TabIndex = 0;
            // 
            // gbLens1
            // 
            this.gbLens1.Controls.Add(this.label7);
            this.gbLens1.Controls.Add(this.label6);
            this.gbLens1.Controls.Add(this.label5);
            this.gbLens1.Controls.Add(this.label4);
            this.gbLens1.Controls.Add(this.NumLens1T);
            this.gbLens1.Controls.Add(this.cbLens1T);
            this.gbLens1.Controls.Add(this.cbLens1Prod);
            this.gbLens1.Controls.Add(this.cbLens1Col);
            this.gbLens1.Location = new System.Drawing.Point(12, 118);
            this.gbLens1.Name = "gbLens1";
            this.gbLens1.Size = new System.Drawing.Size(498, 72);
            this.gbLens1.TabIndex = 1;
            this.gbLens1.TabStop = false;
            this.gbLens1.Text = "Lens1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "T(mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "T(mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // NumLens1T
            // 
            this.NumLens1T.DecimalPlaces = 1;
            this.NumLens1T.Enabled = false;
            this.NumLens1T.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumLens1T.Location = new System.Drawing.Point(426, 44);
            this.NumLens1T.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumLens1T.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLens1T.Name = "NumLens1T";
            this.NumLens1T.Size = new System.Drawing.Size(66, 24);
            this.NumLens1T.TabIndex = 4;
            this.NumLens1T.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbLens1T
            // 
            this.cbLens1T.FormattingEnabled = true;
            this.cbLens1T.Location = new System.Drawing.Point(354, 44);
            this.cbLens1T.Name = "cbLens1T";
            this.cbLens1T.Size = new System.Drawing.Size(65, 22);
            this.cbLens1T.TabIndex = 2;
            this.cbLens1T.SelectedIndexChanged += new System.EventHandler(this.NumLens1T_Change);
            // 
            // cbLens1Prod
            // 
            this.cbLens1Prod.FormattingEnabled = true;
            this.cbLens1Prod.Location = new System.Drawing.Point(155, 44);
            this.cbLens1Prod.Name = "cbLens1Prod";
            this.cbLens1Prod.Size = new System.Drawing.Size(193, 22);
            this.cbLens1Prod.TabIndex = 3;
            // 
            // cbLens1Col
            // 
            this.cbLens1Col.FormattingEnabled = true;
            this.cbLens1Col.Location = new System.Drawing.Point(7, 43);
            this.cbLens1Col.Name = "cbLens1Col";
            this.cbLens1Col.Size = new System.Drawing.Size(142, 22);
            this.cbLens1Col.TabIndex = 3;
            // 
            // gbLens2
            // 
            this.gbLens2.Controls.Add(this.label11);
            this.gbLens2.Controls.Add(this.label10);
            this.gbLens2.Controls.Add(this.label9);
            this.gbLens2.Controls.Add(this.label8);
            this.gbLens2.Controls.Add(this.NumLens2T);
            this.gbLens2.Controls.Add(this.cbLens2Col);
            this.gbLens2.Controls.Add(this.cbLens2T);
            this.gbLens2.Controls.Add(this.cbLens2Prod);
            this.gbLens2.Enabled = false;
            this.gbLens2.Location = new System.Drawing.Point(33, 196);
            this.gbLens2.Name = "gbLens2";
            this.gbLens2.Size = new System.Drawing.Size(477, 72);
            this.gbLens2.TabIndex = 2;
            this.gbLens2.TabStop = false;
            this.gbLens2.Text = "Lens2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "T(mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "T(mm)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Color";
            // 
            // NumLens2T
            // 
            this.NumLens2T.DecimalPlaces = 1;
            this.NumLens2T.Enabled = false;
            this.NumLens2T.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumLens2T.Location = new System.Drawing.Point(404, 42);
            this.NumLens2T.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumLens2T.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLens2T.Name = "NumLens2T";
            this.NumLens2T.Size = new System.Drawing.Size(66, 24);
            this.NumLens2T.TabIndex = 4;
            this.NumLens2T.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbLens2Col
            // 
            this.cbLens2Col.FormattingEnabled = true;
            this.cbLens2Col.Location = new System.Drawing.Point(9, 44);
            this.cbLens2Col.Name = "cbLens2Col";
            this.cbLens2Col.Size = new System.Drawing.Size(119, 22);
            this.cbLens2Col.TabIndex = 3;
            // 
            // cbLens2T
            // 
            this.cbLens2T.FormattingEnabled = true;
            this.cbLens2T.Location = new System.Drawing.Point(333, 44);
            this.cbLens2T.Name = "cbLens2T";
            this.cbLens2T.Size = new System.Drawing.Size(66, 22);
            this.cbLens2T.TabIndex = 2;
            this.cbLens2T.SelectedIndexChanged += new System.EventHandler(this.NumLens2T_Change);
            // 
            // cbLens2Prod
            // 
            this.cbLens2Prod.FormattingEnabled = true;
            this.cbLens2Prod.Location = new System.Drawing.Point(134, 44);
            this.cbLens2Prod.Name = "cbLens2Prod";
            this.cbLens2Prod.Size = new System.Drawing.Size(193, 22);
            this.cbLens2Prod.TabIndex = 3;
            // 
            // ckLens2
            // 
            this.ckLens2.AutoSize = true;
            this.ckLens2.Location = new System.Drawing.Point(12, 224);
            this.ckLens2.Name = "ckLens2";
            this.ckLens2.Size = new System.Drawing.Size(15, 14);
            this.ckLens2.TabIndex = 10;
            this.ckLens2.UseVisualStyleBackColor = true;
            this.ckLens2.CheckedChanged += new System.EventHandler(this.ckLens2_Change);
            // 
            // gbLens3
            // 
            this.gbLens3.Controls.Add(this.label15);
            this.gbLens3.Controls.Add(this.label14);
            this.gbLens3.Controls.Add(this.label13);
            this.gbLens3.Controls.Add(this.label12);
            this.gbLens3.Controls.Add(this.NumLens3T);
            this.gbLens3.Controls.Add(this.cbLens3Col);
            this.gbLens3.Controls.Add(this.cbLens3Prod);
            this.gbLens3.Controls.Add(this.cbLens3T);
            this.gbLens3.Enabled = false;
            this.gbLens3.Location = new System.Drawing.Point(33, 274);
            this.gbLens3.Name = "gbLens3";
            this.gbLens3.Size = new System.Drawing.Size(477, 72);
            this.gbLens3.TabIndex = 3;
            this.gbLens3.TabStop = false;
            this.gbLens3.Text = "Lens3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "T(mm)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "T(mm)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Product";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Color";
            // 
            // NumLens3T
            // 
            this.NumLens3T.DecimalPlaces = 1;
            this.NumLens3T.Enabled = false;
            this.NumLens3T.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumLens3T.Location = new System.Drawing.Point(405, 42);
            this.NumLens3T.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumLens3T.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLens3T.Name = "NumLens3T";
            this.NumLens3T.Size = new System.Drawing.Size(66, 24);
            this.NumLens3T.TabIndex = 4;
            this.NumLens3T.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbLens3Col
            // 
            this.cbLens3Col.FormattingEnabled = true;
            this.cbLens3Col.Location = new System.Drawing.Point(6, 44);
            this.cbLens3Col.Name = "cbLens3Col";
            this.cbLens3Col.Size = new System.Drawing.Size(122, 22);
            this.cbLens3Col.TabIndex = 3;
            // 
            // cbLens3Prod
            // 
            this.cbLens3Prod.FormattingEnabled = true;
            this.cbLens3Prod.Location = new System.Drawing.Point(134, 44);
            this.cbLens3Prod.Name = "cbLens3Prod";
            this.cbLens3Prod.Size = new System.Drawing.Size(193, 22);
            this.cbLens3Prod.TabIndex = 3;
            // 
            // cbLens3T
            // 
            this.cbLens3T.FormattingEnabled = true;
            this.cbLens3T.Location = new System.Drawing.Point(332, 44);
            this.cbLens3T.Name = "cbLens3T";
            this.cbLens3T.Size = new System.Drawing.Size(66, 22);
            this.cbLens3T.TabIndex = 2;
            this.cbLens3T.SelectedIndexChanged += new System.EventHandler(this.NumLens3T_Change);
            // 
            // ckLens3
            // 
            this.ckLens3.AutoSize = true;
            this.ckLens3.Location = new System.Drawing.Point(12, 301);
            this.ckLens3.Name = "ckLens3";
            this.ckLens3.Size = new System.Drawing.Size(15, 14);
            this.ckLens3.TabIndex = 10;
            this.ckLens3.UseVisualStyleBackColor = true;
            this.ckLens3.CheckedChanged += new System.EventHandler(this.ckLens3_Change);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.label19);
            this.gbResult.Controls.Add(this.label18);
            this.gbResult.Controls.Add(this.label17);
            this.gbResult.Controls.Add(this.label16);
            this.gbResult.Controls.Add(this.btnCalc);
            this.gbResult.Controls.Add(this.TrsResult);
            this.gbResult.Controls.Add(this.CyResult);
            this.gbResult.Controls.Add(this.CxResult);
            this.gbResult.Location = new System.Drawing.Point(12, 352);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(498, 73);
            this.gbResult.TabIndex = 4;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(385, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 15);
            this.label19.TabIndex = 21;
            this.label19.Text = "Run";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(256, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "Transmissivity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(130, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 19;
            this.label17.Text = "Cy";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "Cx";
            // 
            // btnCalc
            // 
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(386, 43);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(105, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // TrsResult
            // 
            this.TrsResult.BackColor = System.Drawing.Color.Cornsilk;
            this.TrsResult.Location = new System.Drawing.Point(259, 43);
            this.TrsResult.Name = "TrsResult";
            this.TrsResult.ReadOnly = true;
            this.TrsResult.Size = new System.Drawing.Size(120, 24);
            this.TrsResult.TabIndex = 2;
            // 
            // CyResult
            // 
            this.CyResult.BackColor = System.Drawing.Color.Cornsilk;
            this.CyResult.Location = new System.Drawing.Point(133, 43);
            this.CyResult.Name = "CyResult";
            this.CyResult.ReadOnly = true;
            this.CyResult.Size = new System.Drawing.Size(120, 24);
            this.CyResult.TabIndex = 1;
            // 
            // CxResult
            // 
            this.CxResult.BackColor = System.Drawing.Color.Cornsilk;
            this.CxResult.Location = new System.Drawing.Point(7, 43);
            this.CxResult.Name = "CxResult";
            this.CxResult.ReadOnly = true;
            this.CxResult.Size = new System.Drawing.Size(120, 24);
            this.CxResult.TabIndex = 0;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(346, 10);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(427, 10);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(83, 23);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbUpdate
            // 
            this.tbUpdate.BackColor = System.Drawing.Color.Cornsilk;
            this.tbUpdate.Font = new System.Drawing.Font("굴림", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbUpdate.Location = new System.Drawing.Point(12, 10);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.ReadOnly = true;
            this.tbUpdate.Size = new System.Drawing.Size(253, 20);
            this.tbUpdate.TabIndex = 22;
            // 
            // chtResult
            // 
            chartArea1.Name = "ChartArea1";
            this.chtResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtResult.Legends.Add(legend1);
            this.chtResult.Location = new System.Drawing.Point(6, 23);
            this.chtResult.Name = "chtResult";
            this.chtResult.Size = new System.Drawing.Size(463, 378);
            this.chtResult.TabIndex = 23;
            this.chtResult.Text = "chart1";
            title1.Name = "Result";
            this.chtResult.Titles.Add(title1);
            // 
            // gbGraph
            // 
            this.gbGraph.Controls.Add(this.chtResult);
            this.gbGraph.Location = new System.Drawing.Point(525, 13);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new System.Drawing.Size(475, 407);
            this.gbGraph.TabIndex = 23;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "Graph";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 432);
            this.Controls.Add(this.gbGraph);
            this.Controls.Add(this.ckLens3);
            this.Controls.Add(this.ckLens2);
            this.Controls.Add(this.tbUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbLens3);
            this.Controls.Add(this.gbLens2);
            this.Controls.Add(this.gbLens1);
            this.Controls.Add(this.gbLightSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.gbLightSource.ResumeLayout(false);
            this.gbLightSource.PerformLayout();
            this.gbLens1.ResumeLayout(false);
            this.gbLens1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens1T)).EndInit();
            this.gbLens2.ResumeLayout(false);
            this.gbLens2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens2T)).EndInit();
            this.gbLens3.ResumeLayout(false);
            this.gbLens3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens3T)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtResult)).EndInit();
            this.gbGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLightSource;
        private System.Windows.Forms.GroupBox gbLens1;
        private System.Windows.Forms.GroupBox gbLens2;
        private System.Windows.Forms.GroupBox gbLens3;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.ComboBox cbLaw;
        private System.Windows.Forms.ComboBox cbLightProd;
        private System.Windows.Forms.ComboBox cbLightCol;
        private System.Windows.Forms.ComboBox cbLens1Prod;
        private System.Windows.Forms.ComboBox cbLens1Col;
        private System.Windows.Forms.NumericUpDown NumLens1T;
        private System.Windows.Forms.ComboBox cbLens1T;
        private System.Windows.Forms.ComboBox cbLens2Col;
        private System.Windows.Forms.ComboBox cbLens2T;
        private System.Windows.Forms.ComboBox cbLens2Prod;
        private System.Windows.Forms.NumericUpDown NumLens2T;
        private System.Windows.Forms.ComboBox cbLens3Col;
        private System.Windows.Forms.ComboBox cbLens3Prod;
        private System.Windows.Forms.NumericUpDown NumLens3T;
        private System.Windows.Forms.ComboBox cbLens3T;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox TrsResult;
        private System.Windows.Forms.TextBox CyResult;
        private System.Windows.Forms.TextBox CxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.CheckBox ckLens2;
        private System.Windows.Forms.CheckBox ckLens3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtResult;
        private System.Windows.Forms.GroupBox gbGraph;
    }
}

