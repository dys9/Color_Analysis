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

        public setForm()
        {
            InitializeComponent();
            for (int i = 0; i < LawX.Count; i++)
            {
                textBox1.Text = $"({LawX[i]} , {LawY[i]})\r\n";
            }
        }
    }
}
