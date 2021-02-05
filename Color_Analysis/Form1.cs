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
    public partial class Form1 : Form
    {
        List<double> Lens1;
        List<double> Lens2;
        List<double> Lens3;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            setForm setform = new setForm();
            setform.ShowDialog();
        }
    }
}
