
namespace Color_Analysis
{
    partial class Spectrums
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtSpect = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtSpect)).BeginInit();
            this.SuspendLayout();
            // 
            // chtSpect
            // 
            this.chtSpect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            legend1.Name = "Legend1";
            this.chtSpect.Legends.Add(legend1);
            this.chtSpect.Location = new System.Drawing.Point(0, 0);
            this.chtSpect.Margin = new System.Windows.Forms.Padding(5);
            this.chtSpect.Name = "chtSpect";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtSpect.Series.Add(series1);
            this.chtSpect.Size = new System.Drawing.Size(486, 312);
            this.chtSpect.TabIndex = 0;
            this.chtSpect.Text = "chart1";
            // 
            // btnCap
            // 
            this.btnCap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCap.Location = new System.Drawing.Point(0, 312);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(486, 31);
            this.btnCap.TabIndex = 1;
            this.btnCap.Text = "Capture";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // Spectrums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(486, 343);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.chtSpect);
            this.Name = "Spectrums";
            this.Text = "Spectrums";
            ((System.ComponentModel.ISupportInitialize)(this.chtSpect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSpect;
        private System.Windows.Forms.Button btnCap;
    }
}