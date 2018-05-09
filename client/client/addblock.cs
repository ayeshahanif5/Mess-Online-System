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
    public partial class addblock : Form
    {
        public addblock()
        {
            InitializeComponent();
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            s.Addfine();

        }

        private void cmdblock_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            s.block();
        }
    }
}
