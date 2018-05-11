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
    public partial class checkbilldate : Form
    {
        public checkbilldate()
        {
            InitializeComponent();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
           
            int checkbillbydateResult;
            bool checkbillbydateResultSpecified;
            
            localhost.Service1 h = new localhost.Service1();
            h.checkbillbydate(txtdate.Text,out  checkbillbydateResult,out  checkbillbydateResultSpecified );
            string x = checkbillbydateResult.ToString();
            txtbill.Text=x;




            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmoptions f = new frmoptions();
            this.Hide();
            f.Show();
        }
    }
}
