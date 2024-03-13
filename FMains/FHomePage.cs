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
    public partial class FHomePage : Form
    {
        FController fController;

        public FHomePage(FController fController)
        {
            InitializeComponent();
            this.fController = fController;
            userControlComboBoxAddress.GetData(fController.addressDAO.Addreses);
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelMinMax_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxNoRent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FHomePage_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
