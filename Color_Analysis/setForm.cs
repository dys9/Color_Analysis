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
        private string _method = "";
        public string method
        {
            get { return _method; }
            set { _method = value; }
        }

        public setForm()
        {
            InitializeComponent();
        }

        private void rdDefault_Change(object sender, EventArgs e)
        {
            if (rdDefault.Checked == true)
            {
                rdDaehyeon.Checked = false;
                method = "default";
            }
            else if (rdDefault.Checked == false)
            {
                rdDaehyeon.Checked = true;
                method = "detail";
            }
        }

        private void rdDaehyeon_Change(object sender, EventArgs e)
        {
            if (rdDaehyeon.Checked == true)
            {
                rdDefault.Checked = false;
                method = "detail";
            }
            else if (rdDaehyeon.Checked == false)
            {
                rdDefault.Checked = true;
                method = "default";
            }
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