
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
            ((System.ComponentModel.ISupportInitialize)(this.chtSpect)).BeginInit();
            this.SuspendLayout();
            // 
            // chtSpect
            // 
            legend1.Name = "Legend1";
            this.chtSpect.Legends.Add(legend1);
            this.chtSpect.Location = new System.Drawing.Point(12, 12);
            this.chtSpect.Name = "chtSpect";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtSpect.Series.Add(series1);
            this.chtSpect.Size = new System.Drawing.Size(430, 371);
            this.chtSpect.TabIndex = 0;
            this.chtSpect.Text = "chart1";
            // 
            // Spectrums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.chtSpect);
            this.Name = "Spectrums";
            this.Text = "Spectrums";
            ((System.ComponentModel.ISupportInitialize)(this.chtSpect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtSpect;
    }
}