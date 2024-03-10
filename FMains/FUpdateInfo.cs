using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FUpdateInfo : Form, IUser
    {
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }

        public FUpdateInfo(User user, AccountDAO accountDAO, InfoDAO infoDAO)
        {
            InitializeComponent();
            User = user;
            AccountDAO = accountDAO;
            InfoDAO = infoDAO;
            LoadData();
        }

        private void LoadData()
        {
            labelUser.Text = User.UserName;
            userControlTextBoxEditName.TextBoxText = User.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = User.DateOfBirth.ToString();
            userControlRadioButtonEditGender.GenderText = User.Gender;
            userControlTextBoxEditAddress.TextBoxText = User.Address;
            userControlTextBoxEditIdCard.TextBoxText = User.IdCard;
            userControlTextBoxEditEmail.TextBoxText = User.Email;
            userControlTextBoxEditPhone.TextBoxText = User.Phone;
            if (ProcessImage.Comparer(User.Image, Properties.Resources.man) ==true || ProcessImage.Comparer(User.Image, Properties.Resources.girl) == true)
            {
                GetImageNormal();
            }    
            else
            {
                pictureBoxImage.Image = User.Image;
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
                    UserControlLoading userControlLoading = new UserControlLoading(this, 500);

                    User.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, userControlTextBoxEditAddress.TextBoxText, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, pictureBoxImage.Image);
                    userControlLoading.OnLoading();
                    if (InfoDAO.Update() == true)
                    {
                        ShowMessage.ShowNotification("Cập nhật thành công");
                        LoadData();
                    }
                    userControlLoading.OffLoading();
                }
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            GetImageNormal();
        }

        private void GetImageNormal()
        {
            pictureBoxImage.Image = User.Gender == "Nam" ? Properties.Resources.man : Properties.Resources.girl;
        }
    }
}
