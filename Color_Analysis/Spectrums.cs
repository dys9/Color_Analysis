using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Color_Analysis
{
    public partial class Spectrums : Form
    {
        private List<double> _LightSpect;
        public List<double> LightSpect
        {
            get { return _LightSpect; }
            set { _LightSpect = value; } 
        }

        private List<double> _LensSpect1;
        public List<double> LensSpect1
        {
            get { return _LensSpect1; }
            set { _LensSpect1 = value; }
        }

        private List<double> _LensSpect2;
        public List<double> LensSpect2
        {
            get { return _LensSpect2; }
            set { _LensSpect2 = value; }
        }

        private List<double> _LensSpect3;
        public List<double> LensSpect3
        {
            get { return _LensSpect3; }
            set { _LensSpect3 = value; }
        }

        private List<double> _ResultSpect;
        public List<double> ResultSpect
        {
            get { return _ResultSpect; }
            set { _ResultSpect = value; }
        }

        private string _LightName;
        public string LightName 
        {
            get { return _LightName; }
            set { _LightName = value; }
        }

        private string _Lens1Name;
        public string Lens1Name
        {
            get { return _Lens1Name; }
            set { _Lens1Name = value; }
        }

        private string _Lens2Name;
        public string Lens2Name
        {
            get { return _Lens2Name; }
            set { _Lens2Name = value; }
        }

        private string _Lens3Name;
        public string Lens3Name
        {
            get { return _Lens3Name; }
            set { _Lens1Name = value; }
        }

        public Spectrums()
        {
            InitializeComponent();
            ResultSpect = new List<double>();
            for (int i = 0; i < 401; i++)
            {
                ResultSpect.Add(110.00066 * i);
            }
        }

        public void Draw()
        {
            chtSpect.ChartAreas.Clear();
            chtSpect.Series.Clear();

            if (LightSpect != null || LensSpect1 != null || LensSpect2 != null || LensSpect3 != null || ResultSpect != null)
            {
                ChartArea GraphArea = chtSpect.ChartAreas.Add("Result");
                GraphArea.AxisX.Minimum = 380;
                GraphArea.AxisX.Maximum = 780;
                GraphArea.AxisY.Maximum = ResultSpect.Max();
                GraphArea.AxisY.Maximum = 1;

                if (LightSpect != null)
                {
                    Series Temp = chtSpect.Series.Add("Temp");
                    Temp.ChartType = SeriesChartType.Spline;
                    Temp.BorderWidth = 3;
                    Temp.LegendText = "Result";

                    for (int i = 0; i < LightSpect.Count; i++)
                    {
                        Temp.Points.AddXY(i + 380, ResultSpect[i] / ResultSpect.Max());
                    }
                    chtSpect.Show();

                    Series LightLine = chtSpect.Series.Add("LightLine");
                    LightLine.ChartType = SeriesChartType.Spline;
                    LightLine.BorderWidth = 3;
                    LightLine.LegendText = this.LightName;

                    for (int i = 0; i < LightSpect.Count; i++)
                    {
                        LightLine.Points.AddXY(i + 380, Math.Abs(Math.Sin(0.04*i)));
                    }
                    chtSpect.Show();
                }
            }
            //this.LightSpect = null;
            //this.LensSpect1 = null;
            //this.LensSpect2 = null;
            //this.LensSpect3 = null;
            //this.ResultSpect = null;

            //this.LightName = null;
            //this.Lens1Name = null;
            //this.Lens2Name = null;
            //this.Lens3Name = null;

        }
        private void btnCap_Click(object sender, EventArgs e)
        {
            // 클립보드에 text 저장하기
            using (MemoryStream ms = new MemoryStream())
            {
                chtSpect.SaveImage(ms, ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
        }
    }
}
