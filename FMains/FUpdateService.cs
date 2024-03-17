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
        private FController fControler;
        private Hotel hotel;
        private Image_ cureentImage;
        private int index;

        public FUpdateService(FController fController, int index)
        {
            InitializeComponent();
            fControler = fController;
            this.index = index;
            hotel = fController.User.GetIndex(index);
            pictureBoxImage.Image = IsZeroImage() == true ? Properties.Resources.noImage : hotel.Images.First().Image;
            cureentImage = IsZeroImage() == true ? null : hotel.Images.First();
            LoadData();
        }

        private bool IsZeroImage()
        {
            return index == -1 || hotel.Images == null || hotel.Images.Count == 0;
        }

        private void LoadData()
        {
            if(index != -1)
            {
                panelImage.Visible = true;
                userControlTextBoxName.TextBoxText = hotel.Name;
                userControlAddressHotel.AddressText = hotel.Address;
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

            if(timeSpanIn == TimeSpan.Zero)
            {
                fControler.MessageWarning("Thông báo", message);
                return;
            }    
            TimeSpan timeSpanOut = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxOutText, out message);

            if(timeSpanOut != TimeSpan.Zero)
            {
                Hotel hotel = new Hotel(
                    fControler.User,
                    index == -1 ? fControler.User.Hotels == null ? 0 : fControler.User.Hotels.Count : this.hotel.IdHotel,
                    userControlTextBoxName.TextBoxText,
                    userControlTextBoxPhone.TextBoxText,
                    userControlAddressHotel.AddressText,
                    timeSpanIn,
                    timeSpanOut,
                    checks[0], checks[1], checks[2], checks[3], checks[4], checks[5], checks[6], checks[7],
                    textBoxDescribe.Text,
                    index == -1 ? null : this.hotel.Images);

                if (hotel.IsPhone(out message) && hotel.IsAddress(out message))
                {
                    if (index == -1)
                    {
                        fControler.User.AddHotel(hotel);
                        index = fControler.User.Hotels.Count - 1;
                        fControler.HotelDAO.Insert(hotel);
                        fControler.MessageSuccess("Thông báo", "Tạo khách sạn mới thành công.", this);
                    }
                    else
                    {
                        fControler.User.Hotels[index] = hotel;
                        fControler.HotelDAO.Update(hotel);
                        fControler.MessageSuccess("Thông báo", "Cập nhật khách sạn thành công.", this);
                    }
                    this.hotel = hotel;
                    LoadData();
                    return;
                }
            }
            fControler.MessageWarning("Thông báo", message, this);
        }

        private void ButtonUploadImageClick(object sender, EventArgs e)
        {
            Image image = ProcessImage.OpenFileImageDialog();

            if (image != null)
            {
                Image_ image_ = new Image_(fControler.User, hotel.IdHotel, image);

                hotel.AddImage(image_);
                fControler.ImageHotelDAO.Insert(image_);
                pictureBoxImage.Image = image;
                cureentImage = image_;
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
            fControler.ImageHotelDAO.Delete(cureentImage);
            pictureBoxImage.Image = hotel.Images.Count != 0 ? hotel.Images[indexImage >= hotel.Images.Count ? 0 : indexImage].Image : pictureBoxImage.Image = Properties.Resources.noImage;
            cureentImage = hotel.Images.Count != 0 ? hotel.Images[indexImage >= hotel.Images.Count ? 0 : indexImage] : null;
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(cureentImage) - 1;

            pictureBoxImage.Image = (cureentImage =  indexImage < 0 ? hotel.Images.Last() : hotel.Images[indexImage]).Image;
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(cureentImage) + 1;

            pictureBoxImage.Image = (cureentImage = indexImage >= hotel.Images.Count ? hotel.Images.First() : hotel.Images[indexImage]).Image;
        }
    }
}
