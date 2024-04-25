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
    public partial class FConfirm : Form
    {
        private Hotel hotel;
        private Room room;
        private DateTime firstDay;
        private DateTime lastDay;
        private int deposits;
        private Action loadYes;

        public FConfirm(Hotel hotel, Room room, DateTime firstDay, DateTime lastDay, int deposits, Action loadYes)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.room = room;
            this.firstDay = firstDay;
            this.lastDay = lastDay;
            this.deposits = deposits;
            this.loadYes = loadYes;
        }

        private void ButtonYesClick(object sender, EventArgs e)
        {
            Notification notification1 = new NotificationHotel(QueryData.IdDAO.SelectId,
                    Data.User.UserName, Data.User.Name,
                    hotel.UserName, QueryData.InfoDAO.FindAccount(hotel.UserName),
                    DateTime.Now,
                    richTextBox.Text,
                    false,
                    hotel,
                    room,
                    deposits,
                    "Khách hàng đang chờ xác nhận.",
                    firstDay,
                    lastDay);

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
                firstDay,
                lastDay);

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

            QueryData.RentalDAO.Insert(Data.User, room, firstDay, lastDay);
            room.AddCheckInOuts(firstDay, lastDay);
            FController.Instance.MessageSuccess("Thông báo", "Bạn đã cọc phòng thành công vui lòng đợi khách sạn phản hồi.", this, Successes());
        }

        private FormClosedEventHandler Successes()
        {
            return (s, ev) => { 
                loadYes();
                Close(); 
            };
        }

        private void ButtonNoClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
