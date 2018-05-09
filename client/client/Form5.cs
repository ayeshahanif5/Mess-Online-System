using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class frmCheckRating : Form
    {
        public frmCheckRating()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int checkratingResult;
            bool checkratingResultSpecified;
            localhost.Service1 s = new localhost.Service1();
          //  s.checkrating(txtDate.Text, txtType.Text, out checkratingResult, out checkratingResultSpecified);
            //string y = checkratingResult.ToString();
            //txtRating.Text = y;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
