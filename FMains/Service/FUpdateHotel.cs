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
    public partial class FUpdateHotel : Form
    {
        private Hotel hotel;
        private Image_ currentImage;

        public FUpdateHotel(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            currentImage = null;
            LoadData();
        }

        private bool IsZeroImage()
        {
            return hotel.Images == null || hotel.Images.Count == 0;
        }

        private void LoadData()
        {
            if (hotel != null)
            {
                panelImage.Visible = true;
                userControlTextBoxSerciveName.TextBoxText = hotel.Name;
                userControlAddressHotel.AddressValue = hotel.Address;
                userControlTextBoxServicePhone.TextBoxText = hotel.Phone;
                userControlCheckInOutHotel.MaskedTextBoxInText = hotel.CheckIn.ToString();
                userControlCheckInOutHotel.MaskedTextBoxOutText = hotel.CheckOut.ToString();
                richTextBox.Text = hotel.Describe;
                userControlServiceEdit.Value = hotel.Services;
                currentImage = hotel.Images?.First();
                pictureBox.Image = hotel.GetImageHotel();
            }
            else
            {
                userControlServiceEdit.Value = new List<string>() { "Bãi giữ xe máy", "Bãi giữ xe ô tô", "Khu bán đồ ăn", "Wifi", "Hồ bơi", "Khu vực hút thuốc" };
                butonBack.Visible = panelImage.Visible = false;
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            string message;

            TimeSpan timeSpanIn = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxInText, out message);   
            TimeSpan timeSpanOut = ProcessTimeSpan.TimeSpanPrase(userControlCheckInOutHotel.MaskedTextBoxOutText, out message);

            if (timeSpanIn != TimeSpan.Zero && timeSpanOut != TimeSpan.Zero)
            {
                Hotel hotel = new Hotel(DataAccess.IdDAO.SelectId, userControlTextBoxSerciveName.TextBoxText,
                            userControlTextBoxServicePhone.TextBoxText,
                            userControlAddressHotel.AddressValue,
                            timeSpanIn,
                            timeSpanOut,
                            richTextBox.Text);

                if (hotel.IsName(out message) && hotel.IsAddress(out message) && hotel.IsPhone(out message))
                {
                    if (this.hotel == null)
                    {
                        Data.User.AddHotel(hotel);
                        this.hotel = hotel;
                        DataAccess.HotelDAO.Insert(Data.User, hotel);
                        FController.Instance.MessageSuccess("Thông báo", "Tạo khách sạn mới thành công.", this);
                    }
                    else
                    {
                        this.hotel.UpdateInfor(
                            userControlTextBoxSerciveName.TextBoxText,
                            userControlTextBoxServicePhone.TextBoxText,
                            userControlAddressHotel.AddressValue,
                            timeSpanIn,
                            timeSpanOut,
                            richTextBox.Text);
                        DataAccess.HotelDAO.Update(Data.User, this.hotel);
                        FController.Instance.MessageSuccess("Thông báo", "Cập nhật khách sạn thành công.", this);
                    }
                    this.hotel.UpdateService(userControlServiceEdit.Value);
                    DataAccess.ServiceDAO.Delete(this.hotel);
                    DataAccess.ServiceDAO.Insert(this.hotel);
                    DataAccess.IdDAO.ChangeId();
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
                currentImage = new Image_(DataAccess.IdDAO.SelectId, ProcessImage.ImageToByteArray(image), image);
                hotel.AddImage(currentImage);
                DataAccess.ImageHotelDAO.Insert(hotel, currentImage);
                DataAccess.IdDAO.ChangeId();
                pictureBox.Image = image;
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
            DataAccess.ImageHotelDAO.Delete(currentImage);
            currentImage = hotel.Images.Count != 0 ? hotel.Images[indexImage >= hotel.Images.Count ? 0 : indexImage] : null;
            pictureBox.Image = currentImage == null ? Properties.Resources.noImage : currentImage.Image;
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(currentImage) - 1;

            pictureBox.Image = (currentImage = indexImage < 0 ? hotel.Images.Last() : hotel.Images[indexImage]).Image;
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = hotel.Images.IndexOf(currentImage) + 1;

            pictureBox.Image = (currentImage = indexImage >= hotel.Images.Count ? hotel.Images.First() : hotel.Images[indexImage]).Image;
        }

        private void ButonBackClick(object sender, EventArgs e)
        {
            if(Tag is FHotelManage fHotelManage)
            {
                fHotelManage.LoadData();
                ((FMain)((FService)fHotelManage.Tag).Tag).ChangeColerToolStripButton(fHotelManage);
            }
            Dispose();
        }
    }
}
