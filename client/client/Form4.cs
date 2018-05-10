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
    public partial class frmrRatingUser : Form
    {
        public frmrRatingUser()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            bool rSpecified = true;
            localhost.Service1 s = new localhost.Service1();
            int y = Int32.Parse(txtRating.Text);
            s.rate(y, rSpecified,txtDate.Text, txtType.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
