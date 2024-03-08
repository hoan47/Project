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
    public partial class FUpdateInfo : Form
    {
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(255, 128, 255);

        public FUpdateInfo()
        {
            InitializeComponent();
        }

        private void ButtonClickEdit(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
            foreach (Control control in ((Panel)((Control)sender).Parent).Controls)
            {
                if(control is Panel panelRoad)
                {
                    panelRoad.BackColor = colorTextBoxEnter;
                }
                else if(control is DateTimePicker timePicker)
                {
                    timePicker.Enabled = true;
                    timePicker.Focus();
                }
                else if(control is RadioButton radioButton)
                {
                    radioButton.Enabled = true;
                }
                else if(control is TextBox textBox)
                {
                    textBox.Enabled = true;
                    textBox.Focus();
                }
            }
        }

        private void ControlLeave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Enabled = false;
            }
            else if (sender is DateTimePicker timePicker)
            {
                timePicker.Enabled = false;
            }
            else if (sender is RadioButton radioButton)
            {
                radioButton.Enabled = false;
            }
            foreach (Control control in ((Panel)((Control)sender).Parent).Controls)
            {
                if (control is Panel panelRoad)
                {
                    panelRoad.BackColor = colorTextBoxLeave; 
                }
                else if(control is Button button)
                {
                    button.Visible = true;
                }
            }
        }

        private void ButtonChangeImageClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);
                    pictureBoxImage.Image = image;
                    pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxImage.Dock = DockStyle.Fill;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: Không thể mở tập tin!" + ex.Message);
                }
            }
        }
    }
}
