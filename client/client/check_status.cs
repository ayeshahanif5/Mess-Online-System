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
    public partial class check_status : Form
    {
        public check_status()
        {
            InitializeComponent();
        }

        private void txtreg_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();

            int checkResult;
            bool checkResultSpecified;
            s.check(txtreg_no.Text, out checkResult, out checkResultSpecified);
            if (checkResult == 1)
            {
                txtstatus.Text = "bill is paid";

            }
            else
            {

                txtstatus.Text = "bill is not paid";

            }
        }

        private void linkaddfood_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddfood f = new frmaddfood();
            f.Show();
            this.Hide();
        }
    }
}
