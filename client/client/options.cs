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
    public partial class frmoptions : Form
    {
        public frmoptions()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkbilldate l = new checkbilldate();
            this.Hide();
            l.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            on_off s = new on_off();
            this.Hide();
            s.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserRting f = new frmUserRting();
            this.Hide();
            f.Show();
        }

        private void link_current_bill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            current_bill c = new current_bill();
            this.Hide();
            c.Show();
        }
    }
}
