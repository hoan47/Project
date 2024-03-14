using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UserControls
{
    public partial class UserControlHomePaceSearchItem : UserControl
    {
        public string GroupBox { get { return groupBox1.Text; } set { groupBox1.Text = value; } }
        public Image PictureBox { get { return pictureBox1.Image; } set { pictureBox1.Image = value; } }
        public string Label { get { return label1.Text; } set { label1.Text = value; } }
        public UserControlHomePaceSearchItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
