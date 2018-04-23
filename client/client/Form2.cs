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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            bool isvalid, isvalidpassed;
            s.isvalid(txtfname.Text, txtlname.Text, txtreg.Text, txtpassword.Text, out isvalid, out isvalidpassed);
           
            if (isvalid)
            {
                MessageBox.Show("Valid user");
            }
            else
            {
                MessageBox.Show("inValid user");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 s = new Form1();
            this.Hide();
            s.Show();


        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 k = new Form3();
            this.Hide();
            k.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

