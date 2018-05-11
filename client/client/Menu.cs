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
            localhost.Service1 s = new localhost.Service1();

            List<localhost.Food> l = new List<localhost.Food>();
           // = s.ViewMenu();
            BindingSource d = new BindingSource();
            d.DataSource = s.ViewMenu();
            dataGridView1.DataSource = d;
           // dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
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
