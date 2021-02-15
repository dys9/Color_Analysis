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
// https://blog.hexabrain.net/151 // delegate & event

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

        private PointF _PointResult = new PointF(0.57f, 0.42f);// 0.57f, 0.42f // 0.64f, 0.55f
        public PointF PointResult
        {
            get { return _PointResult; }
            set { _PointResult = value; }
        }

        private GraphDetail _graphDetail;
        public GraphDetail graphDetail
        {
            get { return _graphDetail; }
            set { _graphDetail = value; }
        }

        public const string colorPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data\Color";
        public const string lawPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data\Law";
        public const string lensPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data\Lens";
        public const string lightPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data\Light";


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

            #region for Drawing Graph
            graphDetail = new GraphDetail(chtResult);
            graphDetail.PointResult = PointResult;
            #endregion

            #region for Update Event
            string server_data_path = @"D:\server_data\";
            string client_data_path = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data\";
            
            try
            {
                Update update = new Update(server_data_path, client_data_path);
                List<string> DiffrentDIr = update.GetChangedDir(); // 수정한 날짜가 다른 폴더 List

                
                foreach (var Folder in DiffrentDIr) // 수정한 날짜가 다른 폴더 List 탐색
                {
                    List<string> FileNames = update.GetChangedFileNames(Folder); // 수정한 날짜가 다른 폴더 속 수정한 날짜가 다른 File List
                    foreach (var ChangedFile in FileNames)
                    {
                        update.GetDataFromServer(Folder, ChangedFile);
                    }
                }
                
                tbUpdate.Text = "입력 데이터가 최신 버전 입니다.";
            }
            catch (System.NullReferenceException)
            {

            }
            #endregion
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
                            LawX.Add((double)(new decimal(Convert.ToDouble(vs[0]))));
                            LawY.Add((double)(new decimal(Convert.ToDouble(vs[1]))));

                            #region SET GraphDetail's LawX & LawY
                            graphDetail.LawX = LawX.ToList();
                            graphDetail.LawY = LawY.ToList();
                            #endregion
                        }
                    }
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (LawX.Count + LawY.Count > 0)
            {
                graphDetail.DrawGraph();
                graphDetail.chtResult.Series["Lines"].Color = Color.Black;
                graphDetail.chtResult.Series["Point"].Color = Color.Black;
                graphDetail.chtResult.Show();

                MessageBox.Show(graphDetail.chtResult.Series.Count.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string server_data_path = @"D:\server_data\";
            string client_data_path = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data\";

            try
            {
                Update update = new Update(server_data_path, client_data_path);
                List<string> DiffrentDIr = update.GetChangedDir(); // 수정한 날짜가 다른 폴더 List

                #region for Test
                foreach (var Folder in DiffrentDIr) // 수정한 날짜가 다른 폴더 List 탐색
                {
                    List<string> FileNames = update.GetChangedFileNames(Folder); // 수정한 날짜가 다른 폴더 속 수정한 날짜가 다른 File List
                    foreach (var ChangedFile in FileNames)
                    {
                        update.GetDataFromServer(Folder, ChangedFile);
                        tbUpdate.Text = ChangedFile + " is Updated! " + "입력 데이터가 최신 버전 입니다.";
                    }
                }
                #endregion
            }
            catch (System.NullReferenceException)
            {

            }
        }
    }
}