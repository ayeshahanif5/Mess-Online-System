﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 s  = new localhost.Service1();
   
            s.register( txtfname.Text, txtlname.Text, txtreg.Text, txtpassword.Text);
            MessageBox.Show("user has been registered");


              
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 s = new Form2();
            this.Hide();
            s.Show();

        }
    }
}