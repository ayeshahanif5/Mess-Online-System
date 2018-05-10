using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace client
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
          //  localhost.Service1 s = new localhost.Service1();
           
            //BindingSource d = new BindingSource();
            //d.DataSource = s.ViewMenu();
            //dataGridView1.DataSource = d;
            localhost.Service1 s = new localhost.Service1();
            BindingSource d = new BindingSource();
            d.DataSource = s.ViewMenu();
            dataGridView1.DataSource = d;
            dataGridView1.Columns[0].Visible = false;
        dataGridView1.Columns[1].Visible = false;
           dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;

            


        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lbllGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddfood f = new frmaddfood();
            f.Show();
            this.Hide();
        }
    }
}
