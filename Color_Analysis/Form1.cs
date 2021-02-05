using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
// https://stackoverflow.com/questions/42107207/draw-cie-color-space-in-mschart
namespace Color_Analysis
{
    public partial class Form1 : Form
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

        private List<double> _Lens1 = new List<double>() { 1.1, 2.2, 3.3 };
        public List<double> Lens1
        {
            get { return _Lens1; }
            set { _Lens1 = Lens1; }
        }

        public const string colorPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Color";
        public const string lawPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Law";
        public const string lensPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Lens";
        public const string lightPath = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\Light";

        public Form1()
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
            setform.LawX = LawX;
            setform.LawY = LawY;
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
        }
    }
}
