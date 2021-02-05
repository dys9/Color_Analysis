
namespace Color_Analysis
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLaw = new System.Windows.Forms.ComboBox();
            this.cbLightProd = new System.Windows.Forms.ComboBox();
            this.cbLightCol = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumLens1T = new System.Windows.Forms.NumericUpDown();
            this.cbLens1T = new System.Windows.Forms.ComboBox();
            this.cbLens1Prod = new System.Windows.Forms.ComboBox();
            this.cbLens1Col = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumLen2T = new System.Windows.Forms.NumericUpDown();
            this.cbLens2Col = new System.Windows.Forms.ComboBox();
            this.cbLens2T = new System.Windows.Forms.ComboBox();
            this.cbLens2Prod = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumLen3T = new System.Windows.Forms.NumericUpDown();
            this.cbLen3Col = new System.Windows.Forms.ComboBox();
            this.cbLen3Prod = new System.Windows.Forms.ComboBox();
            this.cbLens3T = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens1T)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLen2T)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLen3T)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLaw);
            this.groupBox1.Controls.Add(this.cbLightProd);
            this.groupBox1.Controls.Add(this.cbLightCol);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light Source";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumLens1T);
            this.groupBox2.Controls.Add(this.cbLens1T);
            this.groupBox2.Controls.Add(this.cbLens1Prod);
            this.groupBox2.Controls.Add(this.cbLens1Col);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lens1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "T(mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "T(mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // NumLens1T
            // 
            this.NumLens1T.Location = new System.Drawing.Point(426, 44);
            this.NumLens1T.Name = "NumLens1T";
            this.NumLens1T.Size = new System.Drawing.Size(66, 24);
            this.NumLens1T.TabIndex = 4;
            // 
            // cbLens1T
            // 
            this.cbLens1T.FormattingEnabled = true;
            this.cbLens1T.Location = new System.Drawing.Point(354, 44);
            this.cbLens1T.Name = "cbLens1T";
            this.cbLens1T.Size = new System.Drawing.Size(65, 22);
            this.cbLens1T.TabIndex = 2;
            // 
            // cbLens1Prod
            // 
            this.cbLens1Prod.FormattingEnabled = true;
            this.cbLens1Prod.Location = new System.Drawing.Point(133, 44);
            this.cbLens1Prod.Name = "cbLens1Prod";
            this.cbLens1Prod.Size = new System.Drawing.Size(215, 22);
            this.cbLens1Prod.TabIndex = 3;
            // 
            // cbLens1Col
            // 
            this.cbLens1Col.FormattingEnabled = true;
            this.cbLens1Col.Location = new System.Drawing.Point(6, 44);
            this.cbLens1Col.Name = "cbLens1Col";
            this.cbLens1Col.Size = new System.Drawing.Size(121, 22);
            this.cbLens1Col.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.NumLen2T);
            this.groupBox3.Controls.Add(this.cbLens2Col);
            this.groupBox3.Controls.Add(this.cbLens2T);
            this.groupBox3.Controls.Add(this.cbLens2Prod);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lens2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "T(mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "T(mm)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Color";
            // 
            // NumLen2T
            // 
            this.NumLen2T.Location = new System.Drawing.Point(425, 42);
            this.NumLen2T.Name = "NumLen2T";
            this.NumLen2T.Size = new System.Drawing.Size(66, 24);
            this.NumLen2T.TabIndex = 4;
            // 
            // cbLens2Col
            // 
            this.cbLens2Col.FormattingEnabled = true;
            this.cbLens2Col.Location = new System.Drawing.Point(6, 44);
            this.cbLens2Col.Name = "cbLens2Col";
            this.cbLens2Col.Size = new System.Drawing.Size(121, 22);
            this.cbLens2Col.TabIndex = 3;
            // 
            // cbLens2T
            // 
            this.cbLens2T.FormattingEnabled = true;
            this.cbLens2T.Location = new System.Drawing.Point(354, 44);
            this.cbLens2T.Name = "cbLens2T";
            this.cbLens2T.Size = new System.Drawing.Size(65, 22);
            this.cbLens2T.TabIndex = 2;
            // 
            // cbLens2Prod
            // 
            this.cbLens2Prod.FormattingEnabled = true;
            this.cbLens2Prod.Location = new System.Drawing.Point(133, 44);
            this.cbLens2Prod.Name = "cbLens2Prod";
            this.cbLens2Prod.Size = new System.Drawing.Size(215, 22);
            this.cbLens2Prod.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.NumLen3T);
            this.groupBox4.Controls.Add(this.cbLen3Col);
            this.groupBox4.Controls.Add(this.cbLen3Prod);
            this.groupBox4.Controls.Add(this.cbLens3T);
            this.groupBox4.Location = new System.Drawing.Point(12, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 72);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Len3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "T(mm)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "T(mm)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 26);
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
            // NumLen3T
            // 
            this.NumLen3T.Location = new System.Drawing.Point(425, 42);
            this.NumLen3T.Name = "NumLen3T";
            this.NumLen3T.Size = new System.Drawing.Size(66, 24);
            this.NumLen3T.TabIndex = 4;
            // 
            // cbLen3Col
            // 
            this.cbLen3Col.FormattingEnabled = true;
            this.cbLen3Col.Location = new System.Drawing.Point(6, 44);
            this.cbLen3Col.Name = "cbLen3Col";
            this.cbLen3Col.Size = new System.Drawing.Size(121, 22);
            this.cbLen3Col.TabIndex = 3;
            // 
            // cbLen3Prod
            // 
            this.cbLen3Prod.FormattingEnabled = true;
            this.cbLen3Prod.Location = new System.Drawing.Point(133, 44);
            this.cbLen3Prod.Name = "cbLen3Prod";
            this.cbLen3Prod.Size = new System.Drawing.Size(215, 22);
            this.cbLen3Prod.TabIndex = 3;
            // 
            // cbLens3T
            // 
            this.cbLens3T.FormattingEnabled = true;
            this.cbLens3T.Location = new System.Drawing.Point(354, 44);
            this.cbLens3T.Name = "cbLens3T";
            this.cbLens3T.Size = new System.Drawing.Size(65, 22);
            this.cbLens3T.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.btnCalc);
            this.groupBox5.Controls.Add(this.TrsResult);
            this.groupBox5.Controls.Add(this.CyResult);
            this.groupBox5.Controls.Add(this.CxResult);
            this.groupBox5.Location = new System.Drawing.Point(12, 352);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(498, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
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
            this.btnSet.Location = new System.Drawing.Point(287, 568);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(105, 23);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(398, 568);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(105, 23);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(255, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox4.Location = new System.Drawing.Point(12, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(237, 24);
            this.textBox4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 603);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLens1T)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLen2T)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLen3T)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
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
        private System.Windows.Forms.NumericUpDown NumLen2T;
        private System.Windows.Forms.ComboBox cbLen3Col;
        private System.Windows.Forms.ComboBox cbLen3Prod;
        private System.Windows.Forms.NumericUpDown NumLen3T;
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
        private System.Windows.Forms.TextBox textBox4;
    }
}

