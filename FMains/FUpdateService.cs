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
        private Image_ currentImage;
        public FUpdateService(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            currentImage = null;
            LoadData();
        }

        private bool IsZeroImage()
        {
            return hotel == null || hotel.Images == null || hotel.Images.Count == 0;
        }

        private void LoadData()
        {
            if (hotel != null)
            {
                panelImage.Visible = true;
                userControlTextBoxName.TextBoxText = hotel.Name;
                userControlAddressHotel.AddressValue = hotel.Address;
                userControlTextBoxPhone.TextBoxText = hotel.Phone;
                userControlCheckInOutHotel.MaskedTextBoxInText = hotel.CheckIn.ToString();
                userControlCheckInOutHotel.MaskedTextBoxOutText = hotel.CheckOut.ToString();
                textBoxDescribe.Text = hotel.Describe;
                userControlAddService.Services = hotel.Services;
                if (hotel.Images != null)
                {
                    pictureBoxImage.Image = hotel.Images.First().Image;
                    currentImage = hotel.Images.First();
                }
                else
                {
                    pictureBoxImage.Image = Properties.Resources.noImage;
                }
            }
            else
            {
                panelImage.Visible = false;
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            string message;

            TimeSpan timeSpanIn = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxInText, out message);   
            TimeSpan timeSpanOut = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxOutText, out message);

            if (timeSpanIn != TimeSpan.Zero && timeSpanOut != TimeSpan.Zero)
            {
                Hotel hotel = new Hotel(FController.Instance.User.SelectNewIdHotel(), userControlTextBoxName.TextBoxText,
                            userControlTextBoxPhone.TextBoxText,
                            userControlAddressHotel.AddressValue,
                            timeSpanIn,
                            timeSpanOut,
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
                            textBoxDescribe.Text);

                        FController.Instance.HotelDAO.Update(this.hotel);
                        FController.Instance.MessageSuccess("Thông báo", "Cập nhật khách sạn thành công.", this);
                    }
                    this.hotel.UpdateService(userControlAddService.Services);
                    FController.Instance.ServiceDAO.Delete(this.hotel);
                    FController.Instance.ServiceDAO.Insert(this.hotel);
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
                currentImage = new Image_(hotel.SelectNewIdImage(), ProcessImage.ImageToByteArray(image), image);
                hotel.AddImage(currentImage);
                FController.Instance.ImageHotelDAO.Insert(hotel, currentImage);
                pictureBoxImage.Image = image;
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            if(IsZeroImage() == true)
            {
                return;
            }    
            int indexImage = hotel.Images.IndexOf(currentImage) + 1;

            hotel.Images.Remove(currentImage);
            FController.Instance.ImageHotelDAO.Delete(hotel, currentImage);
            currentImage = hotel.Images.Count != 0 ? hotel.Images[indexImage >= hotel.Images.Count ? 0 : indexImage] : null;
            pictureBoxImage.Image = currentImage == null ? Properties.Resources.noImage : currentImage.Image;
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(currentImage) - 1;

            pictureBoxImage.Image = (currentImage = indexImage < 0 ? hotel.Images.Last() : hotel.Images[indexImage]).Image;
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(currentImage) + 1;

            pictureBoxImage.Image = (currentImage = indexImage >= hotel.Images.Count ? hotel.Images.First() : hotel.Images[indexImage]).Image;
        }
    }
}
