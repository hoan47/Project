using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadData();
        }

        private void LoadData()
        {
            labelUser.Text = FController.Instance.user.UserName;
            userControlTextBoxEditName.TextBoxText = FController.Instance.user.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = FController.Instance.user.DateOfBirth.ToString();
            userControlRadioButtonEditGender.GenderText = FController.Instance.user.Gender;
            userControlTextBoxEditAddress.TextBoxText = FController.Instance.user.Address;
            userControlTextBoxEditIdCard.TextBoxText = FController.Instance.user.IdCard;
            userControlTextBoxEditEmail.TextBoxText = FController.Instance.user.Email;
            userControlTextBoxEditPhone.TextBoxText = FController.Instance.user.Phone;
            if (ProcessImage.Comparer(FController.Instance.user.Image, Properties.Resources.man) ==true || ProcessImage.Comparer(FController.Instance.user.Image, Properties.Resources.girl) == true)
            {
                GetImageNormal();
            }    
            else
            {
                pictureBoxImage.Image = FController.Instance.user.Image;
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
                    pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch(Exception ex)
                {
                    ShowMessage.ShowError("Lỗi: Không thể mở tập tin!" + ex.Message);
                }
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            User newUser = new User();
            DateTime dateTime;

            if (DateTime.TryParse(userControlDateTimePackerEditDateOfBirth.DateTimePickerText, out dateTime) == true)
            {
                newUser.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, userControlTextBoxEditAddress.TextBoxText, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, pictureBoxImage.Image);
                if (newUser.IsName() == true && newUser.IsAddress() == true && newUser.IsIdCard() == true && newUser.IsEmail() == true && newUser.IsPhone() == true)
                {
                    FController.Instance.user.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, userControlTextBoxEditAddress.TextBoxText, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, pictureBoxImage.Image);
                    if(FController.Instance.infoDAO.Update() == true)
                    {
                        ShowMessage.ShowNotification("Cập nhật thành công");
                        LoadData();
                    }    
                }
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            GetImageNormal();
        }

        private void GetImageNormal()
        {
            pictureBoxImage.Image = FController.Instance.user.Gender == "Nam" ? Properties.Resources.man : Properties.Resources.girl;
        }
    }
}
