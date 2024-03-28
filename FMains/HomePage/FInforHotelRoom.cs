using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FInforHotelRoom : Form
    {
        private Hotel hotel;
        private Room room;
        private DateTime firstDay;
        private DateTime lastDay;
        private TimeSpan roomRentalPeriod;
        private Image_ currentImage;

        public FInforHotelRoom(Hotel hotel, Room room, DateTime firstDay, DateTime lastDay)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.room = room;
            this.firstDay = firstDay;
            this.lastDay = lastDay;
            roomRentalPeriod = lastDay - firstDay;
        }

        private void HotelRoomLoad(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            userControlLableRoomName.LableText = "Tên phòng: " + room.Name;
            userControlLableNumnberPeople.LableText = "Số người: " + room.NumberPeople.ToString();
            userControlLableNumberRoom.LableText = "Số phòng ngủ: " + room.NumberRoom.ToString();
            userControlLableNumberBed.LableText = "Tên giường: " + room.NumberBeds.ToString();
            userControlLableCheckIn.LableText = "Check in: " + firstDay.ToString("dd/MM/yyyy") + " " + hotel.CheckIn.ToString(@"hh\:mm");
            userControlLableCheckOut.LableText = "Check out: " + lastDay.ToString("dd/MM/yyyy") + " " + hotel.CheckOut.ToString(@"hh\:mm");
            userControlLableAcreage.LableText = "Diện tích: " + room.Acreage.ToString() + " m^2";
            userControlLablePrice.LableText = "Giá ngày: " + room.Price.ToString("N0").Replace(",", ".");
            labelOldTotalPrice.Text = (roomRentalPeriod.Days * room.Price).ToString("N0").Replace(",", ".");
            userControlLableTotalPrice.LableText = $"Giá {roomRentalPeriod.Days} ngày: " + (roomRentalPeriod.Days * room.Price * (double)(100 - Data.User.Client.Discount()) / 100).ToString("N0").Replace(",", ".");
            labelContent.Text = $"-{Data.User.Client.RankStr()} được giảm {Data.User.Client.Discount()} %\n" +
                                $"-Phải cọc trước {(room.Price * 0.1).ToString("N0").Replace(",", ".")} xu\n" +
                                $"-Bạn sẽ nhận được 1 điểm vào mức hạng hiện tại.";

            pictureBox.Image = room.GetImageRoom();
            currentImage = room.Images?.First();
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if (room.Images == null)
            {
                return;
            }
            int index = room.Images.IndexOf(currentImage) - 1;

            pictureBox.Image = (currentImage = index < 0 ? room.Images.Last() : room.Images[index]).Image;
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (room.Images == null)
            {
                return;
            }
            int index = room.Images.IndexOf(currentImage) + 1;

            pictureBox.Image = (currentImage = index >= room.Images.Count ? room.Images.First() : room.Images[index]).Image;
        }
    }
}