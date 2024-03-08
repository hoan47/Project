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
        private Color colorTextBoxLeave = Color.FromArgb(64, 64, 64);

        public FUpdateInfo()
        {
            InitializeComponent();
        }

        private void ButtonClickEdit(object sender, EventArgs e)
        {
            DisableControlInfo(panelInfo);
            ((Button)sender).Visible = false;
            foreach (Control control in ((Panel)((Control)sender).Parent).Controls)
            {
                if (control is Panel panelRoad)
                {
                    panelRoad.BackColor = colorTextBoxEnter;
                }
                else if (control is DateTimePicker || control is TextBox)
                {
                    control.Enabled = true;
                    control.Focus();
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = true;
                }
            }
        }

        private void DisableControlInfo(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if(control is Panel)
                {
                    DisableControlInfo((Panel)control);
                }    
                if (control is TextBox || control is RadioButton || control is DateTimePicker)
                {
                    control.Enabled = false;
                }
                if(control is Button)
                {
                    control.Visible = true;
                }    
                if(control.Size.Height < 5)
                {
                    control.BackColor = colorTextBoxLeave;
                }    
            }
        }

        private void ControlLeave(object sender, EventArgs e)
        {
            DisableControlInfo(panelInfo);
            foreach (Control control in ((Panel)((Control)sender).Parent).Controls)
            {
                if (control is Panel panelRoad)
                {
                    panelRoad.BackColor = colorTextBoxLeave; 
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

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            DisableControlInfo(panelInfo);
        }
    }
}
