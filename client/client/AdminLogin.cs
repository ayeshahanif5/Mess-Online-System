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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            bool Adminisvalid, Adminisvalidpassed;
            s.Adminisvalid(txtusername.Text,  txtpassword.Text, out Adminisvalid, out Adminisvalidpassed);

            if (Adminisvalid)
            {
                MessageBox.Show("Valid admin");
                frmaddfood l = new frmaddfood();
                this.Hide();
                l.Show();
               
            }
            else
            {
                MessageBox.Show("inValid admin");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
