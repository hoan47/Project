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
    public partial class UserControlService : UserControl
    {
        public string LabelText { get { return groupBox1.Text; } set { groupBox1.Text = value; } }
        public string TextBoxText { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public Image Image {  get { return pictureBox1.Image; } set { pictureBox1.Image = value; } }
        public UserControlService()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
