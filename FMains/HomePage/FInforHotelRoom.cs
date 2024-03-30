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
        private TimeSpan roomRentalPeriod;
        private DateTime checkIn;
        private DateTime checkOut;
        private Image_ currentImage;
        private int deposits;

        public FInforHotelRoom(Hotel hotel, Room room, DateTime firstDay, DateTime lastDay)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.room = room;
            roomRentalPeriod = lastDay - firstDay;

            DateTime.TryParseExact(firstDay.ToString("dd/MM/yyyy") + " " + hotel.CheckIn.ToString(@"hh\:mm"), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out checkIn);
            DateTime.TryParseExact(lastDay.ToString("dd/MM/yyyy") + " " + hotel.CheckOut.ToString(@"hh\:mm"), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out checkOut);
            deposits = (int)(roomRentalPeriod.Days * room.Price * 0.1f);
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
            userControlLableCheckIn.LableText = checkIn.ToString("dd/MM/yyyy HH:mm:ss");
            userControlLableCheckOut.LableText = checkOut.ToString("dd/MM/yyyy HH:mm:ss");
            userControlLableAcreage.LableText = "Diện tích: " + room.Acreage.ToString() + " m^2";
            userControlLablePrice.LableText = "Giá ngày: " + room.Price.ToString("N0").Replace(",", ".");
            labelOldTotalPrice.Text = (roomRentalPeriod.Days * room.Price).ToString("N0").Replace(",", ".");
            userControlLableTotalPrice.LableText = $"Giá {roomRentalPeriod.Days} ngày: " + (roomRentalPeriod.Days * room.Price * (double)(100 - Data.User.Client.Discount()) / 100).ToString("N0").Replace(",", ".");
            labelContent.Text = $"-{Data.User.Client.RankStr()} được giảm {Data.User.Client.Discount()}%\n" +
                                $"-Phải cọc trước {deposits.ToString("N0").Replace(",", ".")} xu\n";

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

        private void ButtonConfirmClick(object sender, EventArgs e)
        {
            FConfirm fConfirm = new FConfirm();

            fConfirm.FormClosing += ConfirmFormClosing;
            FMain.Instance.OpenFormChild(panel, fConfirm, this);
        }

        private void ConfirmFormClosing(object sender, FormClosingEventArgs e)
        {
            FConfirm fConfirm = (FConfirm)sender;

            if (fConfirm.DialogResult == DialogResult.Yes)
            {
                Notification notification1 = new NotificationHotel(QueryData.IdDAO.SelectId, 
                    Data.User.UserName, Data.User.Name,
                    hotel.UserName, QueryData.InfoDAO.FindAccount(hotel.UserName), 
                    DateTime.Now,
                    fConfirm.RichTextBoxText, 
                    false,
                    hotel,
                    room,
                    deposits,
                    "Khách hàng đang chờ xác nhận.",
                    checkIn,
                    checkOut);

                QueryData.NotificationDAO.Insert(notification1);
                QueryData.IdDAO.ChangeId();

                Notification notification2 = new NotificationClient(QueryData.IdDAO.SelectId,
                    hotel.UserName, QueryData.InfoDAO.FindAccount(hotel.UserName),
                    Data.User.UserName, Data.User.Name,
                    DateTime.Now,
                    "Rất hân hạnh được phục vụ quý khách.\nSự hài lòng của quý khách là thành công của chúng tôi.",
                    false,
                    hotel,
                    room,
                    deposits,
                    "Khách sạn đang xác nhận.",
                    checkIn,
                    checkOut);

                Data.Notifications.Add(notification2);
                QueryData.NotificationDAO.Insert(notification2);
                QueryData.IdDAO.ChangeId();


                Notification notification3 = new NotificationCoins(QueryData.IdDAO.SelectId, null, "Hệ thống", Data.User.UserName, Data.User.Name, DateTime.Now, $"Bạn bị trừ {deposits} xu. Chuyển cho {QueryData.InfoDAO.FindAccount(hotel.UserName)}.", false);

                Data.Notifications.Add(notification3);
                QueryData.NotificationDAO.Insert(notification3);
                QueryData.IdDAO.ChangeId();

                Notification notification4 = new NotificationCoins(QueryData.IdDAO.SelectId, Data.User.UserName, Data.User.Name, hotel.UserName, QueryData.InfoDAO.FindAccount(hotel.UserName), DateTime.Now, $"Bạn nhận được {deposits} xu.", false);

                QueryData.NotificationDAO.Insert(notification4);
                QueryData.IdDAO.ChangeId();

                FController.Instance.MessageSuccess("Thông báo", "Bạn đã cọc phòng thành công vui lòng đợi khách sạn phản hồi.", this, (s, ev) => { Dispose(); });
            }
        }
    }
}