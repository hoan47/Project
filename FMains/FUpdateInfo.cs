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
        FController FController { get; set; }
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }
        public ClientDAO ClientDAO { get; set; }

        public FUpdateInfo(FController fController, User user, AccountDAO accountDAO, InfoDAO infoDAO, ClientDAO clientDAO)
        {
            InitializeComponent();
            FController = fController;
            User = user;
            AccountDAO = accountDAO;
            InfoDAO = infoDAO;
            ClientDAO = clientDAO;
        }

        private void LoadData()
        {
            labelUser.Text = User.UserName;
            userControlTextBoxEditName.TextBoxText = User.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = User.DateOfBirth.ToString();
            userControlRadioButtonEditGender.GenderText = User.Gender;
            if (User.Address != null)
            {
                userControlAddressEditAddress.ComboBoxText = User.Address.ProvinceAndDistrict;
                userControlTextBoxEditSpecificLocation.TextBoxText = User.Address.SpecificLocation;
            }
            userControlTextBoxEditIdCard.TextBoxText = User.IdCard;
            userControlTextBoxEditEmail.TextBoxText = User.Email;
            userControlTextBoxEditPhone.TextBoxText = User.Phone;
            if (ProcessImage.Comparer(User.Image, Properties.Resources.man) == true || ProcessImage.Comparer(User.Image, Properties.Resources.girl) == true)
            {
                pictureBoxImage.Image = User.GetImageNormal();
            }
            else
            {
                pictureBoxImage.Image = User.Image;
            }
            labelRank.Text = User.Client.RankStr();
            pictureBoxImageRank.Image = User.Client.RankImage();
            toolTip.SetToolTip(pictureBoxImageRank, User.Client.StatusRank());
        }

        private void ButtonChangeImageClick(object sender, EventArgs e)
        {
            pictureBoxImage.Image = ProcessImage.OpenFileImageDialog();
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            User newUser = new User();
            DateTime dateTime;

            if (DateTime.TryParse(userControlDateTimePackerEditDateOfBirth.DateTimePickerText, out dateTime) == true)
            {
                Address address = new Address(userControlAddressEditAddress.ComboBoxText, userControlTextBoxEditSpecificLocation.TextBoxText);

                newUser.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, pictureBoxImage.Image);
                if (newUser.IsName() == true && newUser.IsAddress() == true && newUser.IsIdCard() == true && newUser.IsEmail() == true && newUser.IsPhone() == true)
                {
                    FLoading fLoading = new FLoading(this, 2000);

                    User.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, pictureBoxImage.Image);
                    fLoading.OnLoading();
                    if (InfoDAO.Update() == true)
                    {
                        if(User.Client.GetRank() == Client.ERank.noRank)
                        {
                            if (ClientDAO.Update() == true)
                            {
                                User.Client.UpdateRank((int)Client.ERank.rankCopper);
                            }
                        }    
                        FController.MessageSuccess("Thông báo", "Cập nhật thành công.", this);
                        LoadData();
                    }
                    fLoading.OffLoading();
                }
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            pictureBoxImage.Image = User.GetImageNormal();
        }

        private void FUpdateInfoLoad(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
