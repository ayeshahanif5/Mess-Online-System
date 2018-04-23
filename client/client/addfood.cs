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
    public partial class addfood : Form
    {
        public addfood()
        {
            InitializeComponent();
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtprice.Text) || string.IsNullOrWhiteSpace(txtday.Text) || string.IsNullOrWhiteSpace(txtdate.Text) || string.IsNullOrWhiteSpace(txtday.Text) || string.IsNullOrWhiteSpace(txttype.Text))
            {
                MessageBox.Show("please fill above boxes");
            }
            else
            {
                localhost.Service1 s = new localhost.Service1();
                s.Addfood(txtname.Text, txtprice.Text, txtday.Text, txtdate.Text, txttype.Text);
                MessageBox.Show("Food has been added");
                txtname.Text = "";
                txtprice.Text = "";
                txtday.Text = "";
                txtdate.Text = "";
                txttype.Text = "";


            }
        }

        private void cmdupdate_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtprice.Text) || string.IsNullOrWhiteSpace(txtday.Text) || string.IsNullOrWhiteSpace(txtdate.Text) || string.IsNullOrWhiteSpace(txtday.Text) )
            {
                MessageBox.Show("please fill above boxes");
            }
            else
            {
                localhost.Service1 s = new localhost.Service1();
                s.Update_food(txtname.Text, txtprice.Text, txtday.Text, txtdate.Text);
                MessageBox.Show("Food has been updated");
                txtname.Text = "";
                txtprice.Text = "";
                txtday.Text = "";
                txtdate.Text = "";
                

        }
    }
    }
}
