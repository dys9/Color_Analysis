using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Color_Analysis
{
    public class GraphDetail
    {
        private Chart _chtResult;
        public Chart chtResult
        {
            get { return _chtResult; }
            set { _chtResult = value;  }
        }

        private List<double> _LawX = new List<double>();
        public List<double> LawX
        {
            get { return _LawX; }
            set { _LawX = value; }
        }

        private List<double> _LawY = new List<double>();
        public List<double> LawY
        {
            get { return _LawY; }
            set { _LawY = value; }
        }

        private PointF _PointResult = new PointF(0.57f, 0.42f);// 0.57f, 0.42f // 0.64f, 0.55f
        public PointF PointResult
        {
            get { return _PointResult; }
            set { _PointResult = value; }
        }

        public GraphDetail(Chart Cht)
        {
            this.chtResult = Cht;
        }

        private double CustomCeil(double input)
        {
            if (input > 1.0)
            {
                return (double)((int)input);
            }

            double d = input;
            int cnt = 0;
            while (d < 1.0)
            {
                cnt++;
                d *= 10;
            }

            double result = Math.Ceiling(input * Math.Pow(10, cnt)) / Math.Pow(10, cnt);
            return result;
        }

        public List<PointF> SortPointPoly(List<double> px, List<double> py)
        {
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

            double finalAverageX = averageX / Convert.ToDouble(size);
            double finalAverageY = averageY / Convert.ToDouble(size);

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

        public void DrawGraph()
        {
            if (LawX.Count + LawY.Count > 0)
            {
                chtResult.Series.Clear();
                chtResult.ChartAreas.Clear();

                double Xinterval = CustomCeil(LawX.Max() - LawX.Min());
                double Yinterval = CustomCeil(LawY.Max() - LawY.Min());

                ChartArea GraphArea = chtResult.ChartAreas.Add("Result");
                GraphArea.AxisX.Interval = Xinterval;
                GraphArea.AxisX.Minimum = (LawX.Min() - Xinterval);
                GraphArea.AxisX.Maximum = (LawX.Max() + Xinterval);

                GraphArea.AxisY.Interval = Yinterval;
                GraphArea.AxisY.Minimum = (LawY.Min() - Yinterval);
                GraphArea.AxisY.Maximum = (LawY.Max() + Yinterval);

                if (PointResult.X < GraphArea.AxisX.Minimum)
                    GraphArea.AxisX.Minimum = ((double)(new decimal(PointResult.X))) - Xinterval;
                if (PointResult.X > GraphArea.AxisX.Maximum)
                    GraphArea.AxisX.Maximum = ((double)(new decimal(PointResult.X))) + Xinterval;
                if (PointResult.Y < GraphArea.AxisY.Minimum)
                    GraphArea.AxisY.Minimum = ((double)(new decimal(PointResult.Y))) - Yinterval;
                if (PointResult.Y > GraphArea.AxisY.Maximum)
                    GraphArea.AxisY.Maximum = ((double)(new decimal(PointResult.Y))) + Yinterval;

                Series Lines = chtResult.Series.Add("Lines"); //새로운 series 생성
                Lines.IsVisibleInLegend = false;
                Lines.ChartType = SeriesChartType.Line;
                Lines.BorderWidth = 2;

                for (int i = 0; i < LawX.Count; i++)
                {
                    Lines.Points.AddXY(LawX[i], LawY[i]);
                    if (i == LawX.Count - 1) Lines.Points.AddXY(LawX[0], LawY[0]);
                }

                Series pPoint = chtResult.Series.Add("Point");
                pPoint.ChartType = SeriesChartType.Point;
                pPoint.IsVisibleInLegend = false;
                pPoint.Color = Color.Red;
                pPoint.Points.AddXY((double)PointResult.X, (double)PointResult.Y);
            }
        }
    }
}
