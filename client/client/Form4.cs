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
    public partial class frmUserRting : Form
    {
        public frmUserRting()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool rSpecified = true;
            localhost.Service1 s = new localhost.Service1();
            int y = Int32.Parse(txtRating.Text);
            s.rate(y, rSpecified, txtDate.Text, txtType.Text);
            txtDate.Text = "";
            txtRating.Text = "";
            txtType.Text = "";
            MessageBox.Show("Thanks for your responce");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmoptions f = new frmoptions();
            this.Hide();
            f.Show();
        }
    }
}
