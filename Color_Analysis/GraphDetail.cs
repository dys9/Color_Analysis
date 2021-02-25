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

        private PointF _PointResult = new PointF(0.5734f, 0.427293f);// 0.57f, 0.42f // 0.64f, 0.55f
        public PointF PointResult
        {
            get { return _PointResult; }
            set { _PointResult = value; }
        }

        public GraphDetail(Chart Cht)
        {
            this.chtResult = Cht;
        }

        private double CustomTruncate(double input)
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

            double result = Math.Truncate(input * Math.Pow(10, cnt+1)) / Math.Pow(10, cnt+1);
            //result = Math.Ceiling(input * Math.Pow(10, cnt)) / Math.Pow(10, cnt);

            return result;
        }

        private List<PointF> SortPointPoly(List<double> px, List<double> py)
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
                List<PointF> Point_temp = SortPointPoly(this.LawX, this.LawY);
                this.LawX.Clear();
                this.LawY.Clear();

                string temp = "";
                for (int i = 0; i < Point_temp.Count; i++)
                {
                    this.LawX.Add(Convert.ToDouble((double)(new decimal(Point_temp[i].X))));
                    this.LawY.Add(Convert.ToDouble((double)(new decimal(Point_temp[i].Y))));
                    temp += $"({this.LawX[i]}, {this.LawY[i]})\r\n";
                }

                //////////////////////////////////////////////////////////////////

                chtResult.Series.Clear();
                chtResult.ChartAreas.Clear();

                ChartArea GraphArea = chtResult.ChartAreas.Add("Result");

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

                double Xinterval = CustomTruncate(LawX.Max() - LawX.Min());
                double Yinterval = CustomTruncate(LawY.Max() - LawY.Min());
                Xinterval = 0.01; Yinterval = 0.01;

                GraphArea.AxisX.Interval = Xinterval; // 수정 하자
                GraphArea.AxisX.Minimum = CustomTruncate(LawX.Min() - Xinterval);
                GraphArea.AxisX.Maximum = CustomTruncate(LawX.Max() + Xinterval);

                GraphArea.AxisY.Interval = Yinterval;
                GraphArea.AxisY.Minimum = CustomTruncate(LawY.Min() - Yinterval);
                GraphArea.AxisY.Maximum = CustomTruncate(LawY.Max() + Yinterval);

                if (PointResult.X < GraphArea.AxisX.Minimum)
                {
                    GraphArea.AxisX.Minimum = ((double)(new decimal(PointResult.X))) - Xinterval;
                    GraphArea.AxisX.Minimum = CustomTruncate(GraphArea.AxisX.Minimum);
                }
                if (PointResult.X > GraphArea.AxisX.Maximum)
                {
                    GraphArea.AxisX.Maximum = ((double)(new decimal(PointResult.X))) + Xinterval;
                    GraphArea.AxisX.Maximum = CustomTruncate(GraphArea.AxisX.Maximum);
                }
                if (PointResult.Y < GraphArea.AxisY.Minimum)
                {
                    GraphArea.AxisY.Minimum = ((double)(new decimal(PointResult.Y))) - Yinterval;
                    GraphArea.AxisY.Minimum = CustomTruncate(GraphArea.AxisY.Minimum);

                }
                if (PointResult.Y > GraphArea.AxisY.Maximum)
                {
                    GraphArea.AxisY.Maximum = ((double)(new decimal(PointResult.Y))) + Yinterval;
                    GraphArea.AxisY.Maximum = CustomTruncate(GraphArea.AxisY.Maximum);
                }

                #region Added at 2021.02.20 (1)
                GraphArea.AxisX.MajorGrid.Interval = GraphArea.AxisX.Maximum - GraphArea.AxisX.Minimum;
                GraphArea.AxisX.LabelAutoFitMaxFontSize = 7;
                //set gbGraph's BackGround Color WHITE!!
                #endregion
            }
        }
    }
}
