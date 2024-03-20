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
    public partial class UserControlTextBoxHotel : UserControl
    {
        public string LabelText { get { return groupBoxInforService.Text; } set { groupBoxInforService.Text = value; } }
        public string TextBoxText { get { return textBox.Text; } set { textBox.Text = value; } }
        public Image Image { get { return pictureBoxInforService.Image; } set { pictureBoxInforService.Image = value; } }

        public UserControlTextBoxHotel()
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

        private void userControlTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxInforService_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}