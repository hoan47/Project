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
    public partial class FUpdateInfo : Form
    {
        FController fController { get; set; }

        public FUpdateInfo(FController fController)
        {
            InitializeComponent();
            this.fController = fController;
        }

        private void LoadData()
        {
            labelUser.Text = fController.User.UserName;
            userControlTextBoxEditName.TextBoxText = fController.User.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = fController.User.DateOfBirth.ToString();
            userControlRadioButtonEditGender.GenderText = fController.User.Gender;
            if (fController.User.Address != null)
            {
                userControlAddressEditAddress.ComboBoxText = fController.User.Address.ProvinceAndDistrict;
                userControlTextBoxEditSpecificLocation.TextBoxText = fController.User.Address.SpecificLocation;
            }
            userControlTextBoxEditIdCard.TextBoxText = fController.User.IdCard;
            userControlTextBoxEditEmail.TextBoxText = fController.User.Email;
            userControlTextBoxEditPhone.TextBoxText = fController.User.Phone;
            pictureBoxImage.Image = fController.User.Image;
            labelRank.Text = fController.User.Client.RankStr();
            pictureBoxImageRank.Image = fController.User.Client.RankImage();
            toolTip.SetToolTip(pictureBoxImageRank, fController.User.Client.StatusRank());
        }

        private void ButtonChangeImageClick(object sender, EventArgs e)
        {
            pictureBoxImage.Image = ProcessImage.OpenFileImageDialog();
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            User newUser = new User();
            DateTime dateTime;
            string message;

            if (DateTime.TryParse(userControlDateTimePackerEditDateOfBirth.DateTimePickerText, out dateTime) == true)
            {
                Address address = new Address(userControlAddressEditAddress.ComboBoxText, userControlTextBoxEditSpecificLocation.TextBoxText);
                
                newUser.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, ProcessImage.ImageToByteArray(pictureBoxImage.Image), pictureBoxImage.Image);
                if (newUser.IsName(out message) == true && newUser.IsAddress(out message) == true && newUser.IsIdCard(out message) == true && newUser.IsEmail(out message) == true && newUser.IsPhone(out message) == true)
                {
                    FLoading fLoading = new FLoading(this, 2000);

                    fController.User.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, ProcessImage.ImageToByteArray(pictureBoxImage.Image), pictureBoxImage.Image);
                    fLoading.OnLoading();
                    if (fController.InfoDAO.Update() == true)
                    {
                        if(fController.User.Client.GetRank() == Client.ERank.noRank)
                        {
                            if (fController.ClientDAO.Update((int)Client.ERank.rankCopper) == true)
                            {
                                fController.User.Client.UpdateRank((int)Client.ERank.rankCopper);
                            }
                        }    
                        fController.MessageSuccess("Thông báo", "Cập nhật thành công.", this);
                        LoadData();
                    }
                    fLoading.OffLoading();
                }
                else
                {
                    fController.MessageWarning("Thông báo", message, this);
                }    
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            pictureBoxImage.Image = Properties.Resources.noImage;
        }

        private void FUpdateInfoLoad(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
