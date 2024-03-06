using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            Form x = new FUpdateInfo();
            x.TopLevel = false;
            panel1.Controls.Add(x);
            x.BringToFront();
            x.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
