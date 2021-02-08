
namespace Color_Analysis
{
    partial class setForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDaehyeon = new System.Windows.Forms.RadioButton();
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDaehyeon);
            this.groupBox1.Controls.Add(this.rdDefault);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph Method";
            // 
            // rdDaehyeon
            // 
            this.rdDaehyeon.AutoSize = true;
            this.rdDaehyeon.Location = new System.Drawing.Point(6, 48);
            this.rdDaehyeon.Name = "rdDaehyeon";
            this.rdDaehyeon.Size = new System.Drawing.Size(136, 19);
            this.rdDaehyeon.TabIndex = 1;
            this.rdDaehyeon.Text = "Daehyeon Graph";
            this.rdDaehyeon.UseVisualStyleBackColor = true;
            this.rdDaehyeon.CheckedChanged += new System.EventHandler(this.rdDaehyeon_Change);
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Checked = true;
            this.rdDefault.Location = new System.Drawing.Point(6, 23);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(114, 19);
            this.rdDefault.TabIndex = 0;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "Default Graph";
            this.rdDefault.UseVisualStyleBackColor = true;
            this.rdDefault.CheckedChanged += new System.EventHandler(this.rdDefault_Change);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(79, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // setForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 125);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "setForm";
            this.Text = "setForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDaehyeon;
        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.Button btnOK;
    }
}