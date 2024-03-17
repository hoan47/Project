using Project.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FUpdateService : Form
    {
        private Hotel hotel;
        private Image cureentImage;

        public FUpdateService(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            pictureBoxImage.Image = cureentImage = IsZeroImage() == true ? Properties.Resources.noImage : hotel.Images.First();
            LoadData();
        }

        private bool IsZeroImage()
        {
            return hotel == null || hotel.Images == null || hotel.Images.Count == 0;
        }

        private void LoadData()
        {
            if(hotel != null)
            {
                panelImage.Visible = true;
                userControlTextBoxName.TextBoxText = hotel.Name;
                userControlAddressHotel.AddressValue = hotel.Address;
                userControlTextBoxPhone.TextBoxText = hotel.Phone;
                userControlCheckInOutHotel.MaskedTextBoxInText = hotel.CheckIn.ToString();
                userControlCheckInOutHotel.MaskedTextBoxOutText = hotel.CheckOut.ToString();
                textBoxDescribe.Text = hotel.Describe;
                bool[] checks = { hotel.IsPool,
                    hotel.IsFoodServingArea, 
                    hotel.IsCarPark, 
                    hotel.IsWifi, 
                    hotel.IsServeFullTime, 
                    hotel.IsLaundryService, 
                    hotel.IsSmokingArea, 
                    hotel.IsPark };

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, checks[i]);
                }
            }
            else
            {
                panelImage.Visible = false;
            }    
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            bool[] checks = new bool[8];

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checks[i] = checkedListBox.GetItemChecked(i);
            }
            string message;

            TimeSpan timeSpanIn = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxInText, out message);   
            TimeSpan timeSpanOut = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxOutText, out message);

            if (timeSpanIn != TimeSpan.Zero && timeSpanOut != TimeSpan.Zero)
            {
                Hotel hotel = new Hotel(FController.Instance.User.Hotels.Count, userControlTextBoxName.TextBoxText,
                            userControlTextBoxPhone.TextBoxText,
                            userControlAddressHotel.AddressValue,
                            timeSpanIn,
                            timeSpanOut,
                            checks[0], checks[1], checks[2], checks[3], checks[4], checks[5], checks[6], checks[7],
                            textBoxDescribe.Text);

                if (hotel.IsName(out message) && hotel.IsAddress(out message) && hotel.IsPhone(out message))
                {
                    if (this.hotel == null)
                    {
                        FController.Instance.User.AddHotel(hotel);
                        this.hotel = hotel;
                        FController.Instance.HotelDAO.Insert(hotel);
                        FController.Instance.MessageSuccess("Thông báo", "Tạo khách sạn mới thành công.", this);
                    }
                    else
                    {
                        this.hotel.UpdateInfo(
                            userControlTextBoxName.TextBoxText,
                            userControlTextBoxPhone.TextBoxText,
                            userControlAddressHotel.AddressValue,
                            timeSpanIn,
                            timeSpanOut,
                            checks[0], checks[1], checks[2], checks[3], checks[4], checks[5], checks[6], checks[7],
                            textBoxDescribe.Text);

                        FController.Instance.HotelDAO.Update(this.hotel);
                        FController.Instance.MessageSuccess("Thông báo", "Cập nhật khách sạn thành công.", this);
                    }
                    LoadData();
                    return;
                }
            }
            FController.Instance.MessageWarning("Thông báo", message, this);
        }

        private void ButtonUploadImageClick(object sender, EventArgs e)
        {
            Image image = ProcessImage.OpenFileImageDialog();

            if (image != null)
            {
                hotel.AddImage(image);
                FController.Instance.ImageHotelDAO.Insert(hotel, image);
                pictureBoxImage.Image = image;
                cureentImage = image;
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            if(IsZeroImage() == true)
            {
                return;
            }    
            int indexImage = hotel.Images.IndexOf(cureentImage) + 1;

            hotel.Images.Remove(cureentImage);
            FController.Instance.ImageHotelDAO.Delete(hotel, cureentImage);
            pictureBoxImage.Image = hotel.Images.Count != 0 ? hotel.Images[indexImage >= hotel.Images.Count ? 0 : indexImage] : pictureBoxImage.Image = Properties.Resources.noImage;
            cureentImage = hotel.Images.Count != 0 ? hotel.Images[indexImage >= hotel.Images.Count ? 0 : indexImage] : null;
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(cureentImage) - 1;

            pictureBoxImage.Image = cureentImage =  indexImage < 0 ? hotel.Images.Last() : hotel.Images[indexImage];
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(cureentImage) + 1;

            pictureBoxImage.Image = cureentImage = indexImage >= hotel.Images.Count ? hotel.Images.First() : hotel.Images[indexImage];
        }
    }
}
