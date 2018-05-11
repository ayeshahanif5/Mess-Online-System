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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            s.UpdateStatus(txtregno.Text);
        }

        private void Update_Student_s_Status_Load(object sender, EventArgs e)
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
