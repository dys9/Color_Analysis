using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
//https://3001ssw.tistory.com/124
// https://forums.autodesk.com/t5/net/sorting-a-list-point-of-a-polygon-clockwise/m-p/7367684#M55128
namespace Color_Analysis
{
    public partial class setForm : Form
    {
        private mainForm _mainform;
        public mainForm mainform
        {
            get { return _mainform; }
            set { _mainform = value; }
        }

        private PointF _point = new PointF(3.0f, 3.0f);
        public PointF point
        {
            get { return _point; }
            set { _point = value; }
        }

        public setForm()
        {
            InitializeComponent();
        }

        public setForm(mainForm mf)
        {
            InitializeComponent();
            this.mainform = mf;

            for (int i = 0; i < mainform.LawX.Count; i++)
            {
                textBox1.Text += $"({mainform.LawX[i]}, {mainform.LawY[i]})\r\n";
            }

            textBox1.Text += "\r\n";
            List<PointF> PointXY = sortPointsClockwise(mainform.LawX, mainform.LawY);
            foreach (PointF pF in PointXY)
            {
                textBox1.Text += $"({pF.X}, {pF.Y})\r\n";
            }
        }

        private bool isInPoly(Point pt)
        {
            return false;
        }

        private List<PointF> sortPointsClockwise(List<double> px, List<double>py)
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

            double finalAverageX = averageX / (double) size;
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

        private void rdDefault_Change(object sender, EventArgs e)
        {
            if (rdDefault.Checked == true)
                rdDaehyeon.Checked = false;
            else if (rdDefault.Checked == false)
                rdDaehyeon.Checked = true;
        }

        private void rdDaehyeon_Change(object sender, EventArgs e)
        {
            if (rdDaehyeon.Checked == true)
                rdDefault.Checked = false;
            else if (rdDaehyeon.Checked == false)
                rdDefault.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}