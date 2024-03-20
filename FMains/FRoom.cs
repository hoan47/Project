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
    public partial class FRoom : Form
    {
        public FRoom()
        {
            InitializeComponent();
        }

        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CheckBox newCheckBox = new CheckBox();
            string inputText = ShowInputDialog(" Dịch Vụ Khác");
            newCheckBox.Text = inputText;
            checkedListBox1.Items.Add(newCheckBox.Text);
            checkedListBox1.Refresh();
        }
        private string ShowInputDialog(string prompt)
        {
            using (Form promptForm = new Form())
            {
                promptForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                promptForm.StartPosition = FormStartPosition.CenterParent;
                promptForm.Width = 250;
                promptForm.Height = 150;
                promptForm.Text = "Nhập thông tin";
                promptForm.TopMost = true;

                Label promptLabel = new Label() { Left = 20, Top = 20, Width = 200, Text = prompt };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 200 };
                Button confirmation = new Button() { Text = "OK", Left = 150, Width = 70, Top = 80 };
                confirmation.Click += (sender, e) => { promptForm.DialogResult = DialogResult.OK; };
                promptForm.AcceptButton = confirmation;

                promptForm.Controls.Add(confirmation);
                promptForm.Controls.Add(textBox);
                promptForm.Controls.Add(promptLabel);

                return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void userControlBackground1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
