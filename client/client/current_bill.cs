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
    public partial class current_bill : Form
    {
        public current_bill()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            localhost.Service1 s= new localhost.Service1();
            int k;
            bool l;
             s.claculate_bill(out k,out l);

             textBox1.Text = k.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbllGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmoptions f = new frmoptions();
            this.Hide();
            f.Show();
        }
    }
}
