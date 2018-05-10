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
    public partial class attendence : Form
    {
        public attendence()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int k;
            bool l;
            localhost.Service1 s = new localhost.Service1();
            s.getattendence(textBox1.Text, textBox2.Text, out k, out l);
            label4.Text = k.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddfood f = new frmaddfood();
            this.Hide();
            f.Show();
        }
    }
}
