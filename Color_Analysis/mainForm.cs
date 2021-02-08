using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.ComboBox;
// https://stackoverflow.com/questions/42107207/draw-cie-color-space-in-mschart // Draw Graph
// https://link2me.tistory.com/857 // Communication for Forms
// https://docs.microsoft.com/ko-kr/dotnet/api/system.drawing.rectangle.contains?view=net-5.0 // isinRect
namespace Color_Analysis
{
    public partial class mainForm : Form
    {
        private List<double> _LawX = new List<double>();
        public List<double> LawX
        {
            get { return _LawX; }
            set { _LawX = LawX; }
        }

        private List<double> _LawY = new List<double>();
        public List<double> LawY
        {
            get { return _LawY; }
            set { _LawY = LawY; }
        }

        private PointF _PointResult = new PointF(3.3f, 3.3f);
        public PointF PointResult
        {
            get { return _PointResult; }
            set { _PointResult = value; }
        }

        public const string colorPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Color";
        public const string lawPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Law";
        public const string lensPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Lens";
        public const string lightPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Light";


        public mainForm()
        {
            InitializeComponent();

            initComboBox(cbLightCol, colorPath);
            initComboBox(cbLightProd, lightPath);
            initComboBox(cbLaw, lawPath);

            initComboBox(cbLens1Col, colorPath);
            initComboBox(cbLens1Prod, lensPath);

            initComboBox(cbLens2Col, colorPath);
            initComboBox(cbLens2Prod, lensPath);

            initComboBox(cbLens3Col, colorPath);
            initComboBox(cbLens3Prod, lensPath);

            cbLens1T.Items.AddRange(new string[] {"1T", "2T", "3T", "4T", "Input"});
            cbLens2T.Items.AddRange(new string[] {"1T", "2T", "3T", "4T", "Input"});
            cbLens3T.Items.AddRange(new string[] {"1T", "2T", "3T", "4T", "Input"});
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            setForm setform = new setForm();
            setform.Owner = this;
            setform.ShowDialog();
        }

        public void initComboBox(ComboBox cb ,string path)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            foreach (System.IO.FileInfo file in di.GetFiles())
            {
                cb.Items.Add(file.Name.Replace(".txt", ""));
            }
        }

        private void NumLens1T_Change(object sender, EventArgs e)
        {
            if (cbLens1T.SelectedItem.ToString().Equals("Input"))
                NumLens1T.Enabled = true;
            else
                NumLens1T.Enabled = false;
        }

        private void NumLens2T_Change(object sender, EventArgs e)
        {
            if (cbLens2T.SelectedItem.ToString().Equals("Input"))
                NumLens2T.Enabled = true;
            else
                NumLens2T.Enabled = false;
        }

        private void NumLens3T_Change(object sender, EventArgs e)
        {
            if (cbLens3T.SelectedItem.ToString().Equals("Input"))
                NumLens3T.Enabled = true;
            else
                NumLens3T.Enabled = false;
        }

        private void ckLens2_Change(object sender, EventArgs e)
        {
            if (ckLens2.Checked == true) gbLens2.Enabled = true;
            else gbLens2.Enabled = false;
        }

        private void ckLens3_Change(object sender, EventArgs e)
        {
            if (ckLens3.Checked == true) gbLens3.Enabled = true;
            else gbLens3.Enabled = false;
        }

        private void cbLaw_Change(object sender, EventArgs e)
        {
            LawX.Clear();
            LawY.Clear();
            if (cbLaw.SelectedItem.ToString() != null)
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(lawPath); 
                foreach (System.IO.FileInfo file in di.GetFiles())
                {
                    if (cbLaw.SelectedItem.ToString().Equals(file.Name.Replace(".txt", "")))
                    {
                        string[] textValue = System.IO.File.ReadAllLines(file.FullName);
                        for (var i = 0; i < textValue.Length; i++)
                        {
                            string[] vs = textValue[i].Split(' ');
                            LawX.Add(Convert.ToDouble(vs[0]));
                            LawY.Add(Convert.ToDouble(vs[1]));
                        }
                    }
                }
            }
            List<PointF> Point_temp = sortPointsClockwise(LawX, LawY);
            LawX.Clear();
            LawY.Clear();

            for (int i = 0; i < Point_temp.Count; i++)
            {
                LawX.Add((double) Point_temp[i].X);
                LawY.Add((double) Point_temp[i].Y);
            }
        }

        private List<PointF> sortPointsClockwise(List<double> px, List<double> py)
        {// https://www.crocus.co.kr/1634?category=209527
            int size = px.Count;
            double averageX = 0;
            double averageY = 0;
            List<PointF> point = new List<PointF>();
            for (int i = 0; i < size; i++)
            {
                averageX += px[i];
                averageY += py[i];
                point.Add(new PointF((float)px[i], (float)py[i]));
            }

            double finalAverageX = averageX / (double)size;
            double finalAverageY = averageY / (double)size;

            point.Sort(delegate (PointF lhs, PointF rhs)
            {
                double lhsAngle = Math.Atan2(lhs.Y - finalAverageY, lhs.X - finalAverageX);
                double rhsAngle = Math.Atan2(rhs.Y - finalAverageY, rhs.X - finalAverageX);

                // Depending on the coordinate system, you might need to reverse these two conditions 
                if (lhsAngle < rhsAngle)
                    return -1;
                if (lhsAngle > rhsAngle)
                    return 1;
                return 0;
            });
            return point;
        }
        private void DrawGraph()
        {
            chtResult.Series.Clear();

            var series = new Series("Finance");

            // Frist parameter is X-Axis and Second is Collection of Y- Axis
            series.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
            chtResult.Series.Add(series);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }
}