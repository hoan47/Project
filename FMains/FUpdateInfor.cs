﻿using System;
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
    public partial class FUpdateInfor : Form
    {
        public FUpdateInfor()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            labelUser.Text = Data.User.UserName;
            userControlTextBoxEditName.TextBoxText = Data.User.Name;
            userControlDateTimePackerEditDateOfBirth.DateTimePickerText = Data.User.DateOfBirth.ToString();
            userControlRadioButtonEditGender.GenderText = Data.User.Gender;
            if (Data.User.Address != null)
            {
                userControlAddressEditAddress.ComboBoxText = Data.User.Address.ProvinceAndDistrict;
                userControlTextBoxEditSpecificLocation.TextBoxText = Data.User.Address.SpecificLocation;
            }
            userControlTextBoxEditIdCard.TextBoxText = Data.User.IdCard;
            userControlTextBoxEditEmail.TextBoxText = Data.User.Email;
            userControlTextBoxEditPhone.TextBoxText = Data.User.Phone;
            pictureBoxImage.Image = Data.User.Image;
            labelRank.Text = Data.User.Client.RankStr();
            pictureBoxImageRank.Image = Data.User.Client.RankImage();
            toolTip.SetToolTip(pictureBoxImageRank, Data.User.Client.StatusRank());
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
                
                newUser.UpdateInfor(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, ProcessImage.ImageToByteArray(pictureBoxImage.Image), pictureBoxImage.Image);
                if (newUser.IsName(out message) == true && newUser.IsAddress(out message) == true && newUser.IsIdCard(out message) == true && newUser.IsEmail(out message) == true && newUser.IsPhone(out message) == true)
                {
                    FLoading fLoading = new FLoading(this, 2000);

                    Data.User.UpdateInfor(userControlTextBoxEditName.TextBoxText, dateTime, userControlRadioButtonEditGender.GenderText, address, userControlTextBoxEditIdCard.TextBoxText, userControlTextBoxEditEmail.TextBoxText, userControlTextBoxEditPhone.TextBoxText, ProcessImage.ImageToByteArray(pictureBoxImage.Image), pictureBoxImage.Image);
                    fLoading.OnLoading();
                    if (DataAccess.InfoDAO.Update(Data.User) == true)
                    {
                        if(Data.User.Client.GetRank() == Client.ERank.noRank)
                        {
                            if (DataAccess.ClientDAO.Update(Data.User, (int)Client.ERank.rankCopper, Client.coninsStar) == true)
                            {
                                Data.User.Client.UpdateRank((int)Client.ERank.rankCopper);
                                Data.User.Client.UpdateCoins(Client.coninsStar);
                                ((FMain)Tag).UpdateConins();
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
