using Project.UserControls;
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
    public partial class FUpdateService : Form
    {
        Form formChildCurrent;
       
        public FUpdateService()
        {
            InitializeComponent();
            formChildCurrent = this;
            for (int i = 1; i < 10; i++)
            {
               flowLayoutPanel1.Controls.Add(new UserControlRoom());
            }
            dateTimePicker1.ShowUpDown=true;
            dateTimePicker2.ShowUpDown=true;
        }
        private void OpenFormChild(Form formChild)
        {

            UserControlLoading userControlLoading = new UserControlLoading(formChild, 300);
            userControlLoading.OnLoading();
            formChild.TopLevel = false;
            Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            userControlLoading.OffLoading();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FRegisterRoom());
        }

        private void userControlTextBoxService1_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextBoxService2_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextBoxService3_Load(object sender, EventArgs e)
        {

        }

        private void userControlComboBoxAddress1_Load(object sender, EventArgs e)
        {



        }

        private void userControlComboBoxAddress1_Load_1(object sender, EventArgs e)
        {


        }

        private void userControlComboBoxAddress1_Load_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
