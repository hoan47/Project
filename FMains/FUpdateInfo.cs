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
        public FUpdateInfo()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            labelUser.Text = FController.Instance.User.UserName;
            userControlTextBoxEditName.TextBoxText = FController.Instance.User.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = FController.Instance.User.DateOfBirth.ToString();
            userControlRadioButtonEditGender.GenderText = FController.Instance.User.Gender;
            if (FController.Instance.User.Address != null)
            {
                userControlAddressEditAddress.ComboBoxText = FController.Instance.User.Address.ProvinceAndDistrict;
                userControlTextBoxEditSpecificLocation.TextBoxText = FController.Instance.User.Address.SpecificLocation;
            }
            userControlTextBoxEditIdCard.TextBoxText = FController.Instance.User.IdCard;
            userControlTextBoxEditEmail.TextBoxText = FController.Instance.User.Email;
            userControlTextBoxEditPhone.TextBoxText = FController.Instance.User.Phone;
            pictureBoxImage.Image = FController.Instance.User.Image;
            labelRank.Text = FController.Instance.User.Client.RankStr();
            pictureBoxImageRank.Image = FController.Instance.User.Client.RankImage();
            toolTip.SetToolTip(pictureBoxImageRank, FController.Instance.User.Client.StatusRank());
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

                    FController.Instance.User.UpdateInfo(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, ProcessImage.ImageToByteArray(pictureBoxImage.Image), pictureBoxImage.Image);
                    fLoading.OnLoading();
                    if (FController.Instance.InfoDAO.Update() == true)
                    {
                        if(FController.Instance.User.Client.GetRank() == Client.ERank.noRank)
                        {
                            if (FController.Instance.ClientDAO.Update((int)Client.ERank.rankCopper) == true)
                            {
                                FController.Instance.User.Client.UpdateRank((int)Client.ERank.rankCopper);
                            }
                        }    
                        FController.Instance.MessageSuccess("Thông báo", "Cập nhật thành công.", this);
                        LoadData();
                    }
                    fLoading.OffLoading();
                }
                else
                {
                    FController.Instance.MessageWarning("Thông báo", message, this);
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
