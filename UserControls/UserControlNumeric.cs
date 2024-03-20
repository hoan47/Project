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
    public partial class UserControlNumeric : UserControl
    {
        public string GrupBoxText { get { return groupBox.Text; } set { groupBox.Text = value; } }
        public Image Image { get { return pictureBox.Image; } set { pictureBox.Image = value; } }
        public int NumericValue { get { return (int)numericUpDownPeople.Value; } set { numericUpDownPeople.Value = value; } }

        public UserControlNumeric()
        {
            InitializeComponent();
        }

        private void userControlNumericUpDown1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
