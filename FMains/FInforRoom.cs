using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.FMains
{
    public partial class FInforRoom : Form
    {
        public FInforRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            
            toolTip1.SetToolTip(button1, "Thông Tin Phòng");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
