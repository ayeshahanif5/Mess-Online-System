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
    public partial class on_off : Form
    {
        public on_off()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblviewmenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void on_off_Load(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();

            BindingSource d = new BindingSource();
            d.DataSource = s.ViewMenu();
            dataGridView1.DataSource = d;
           // dataGridView1.Columns[0].Visible = false;
           // dataGridView1.Columns[1].Visible = false;
           // dataGridView1.Columns[2].Visible = false;
           // dataGridView1.Columns[3].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            s.submit();
        }
    }
}
