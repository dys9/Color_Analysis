using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Analysis
{
    public partial class setForm : Form
    {
        private mainForm _mainform;
        public mainForm mainform {
            get { return _mainform; }
            set { _mainform = value; }
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
        }
    }
}
