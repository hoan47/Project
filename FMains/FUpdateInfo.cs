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
        public FUpdateInfo()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            labelUser.Text = FController.Instance.user.UserName;
            userControlTextBoxEditName.TextBoxText = FController.Instance.user.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = FController.Instance.user.DateOfBirth.ToString();
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
