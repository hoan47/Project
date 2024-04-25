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
    public partial class UserControlNotificationClient : UserControl
    {
        private NotificationClient notification;

        public UserControlNotificationClient(NotificationClient notification)
        {
            InitializeComponent();
            this.notification = notification;
            groupBox.Text = "Tên khách sạn: " + notification.Hotel.Name;
            labelSendingTime.Text = notification.Time.ToString("dd/MM/yyyy HH:mm:ss");
            richTextBoxMessage.Text = notification.Content;
            labelPhone.Text = "SĐT: " + notification.Hotel.Phone;
            labelNameRoom.Text = "Tên phòng: " + notification.Room.Name;
            labelPrice.Text = "Xu cọc: " + notification.DepositCoins.ToString();
            labelIn.Text = notification.CheckIn.ToString("dd/MM/yyyy HH:mm:ss");
            labelOut.Text = notification.CheckOut.ToString("dd/MM/yyyy HH:mm:ss");
            labelStatus.Text = notification.Status;
            circleButton.Visible = !notification.IsWatched;

            switch (notification.Status)
            {
                case "Bạn đã hủy phòng thành công.":
                    buttonCancel.Visible = false;
                    break;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            FCancelRoom fCancelRoom = new FCancelRoom();

            fCancelRoom.FormClosing += CancelRoomClosing;
            ((FNotification)Tag).OpenFormChild(panel, fCancelRoom);
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
            notification.Watched();
            QueryData.NotificationDAO.Update(notification);
        }

        private void CancelRoomClosing(object sender, FormClosingEventArgs e)
        {
            FCancelRoom fCancelRoom = (FCancelRoom)sender;
            if (fCancelRoom.DialogResult == DialogResult.Yes)
            {
                int idNotificationClient = QueryData.IdDAO.SelectId;
                QueryData.IdDAO.ChangeId();
                int idNotificationHotel = QueryData.IdDAO.SelectId;
                QueryData.IdDAO.ChangeId();

                Notification notification1 = new NotificationHotel(idNotificationClient,
                    Data.User.UserName, Data.User.Name,
                    notification.Hotel.UserName, QueryData.InfoDAO.FindAccount(notification.Hotel.UserName),
                    DateTime.Now,
                    fCancelRoom.RichTextBoxText,
                    false,
                    notification.Hotel,
                    notification.Room,
                    notification.DepositCoins,
                    "Khách hàng đã hủy phòng.",
                    notification.CheckIn,
                    notification.CheckOut,
                    idNotificationHotel);

                QueryData.NotificationDAO.Insert(notification1);
                QueryData.IdDAO.ChangeId();

                Notification notification2 = new NotificationClient(idNotificationHotel,
                    notification.Hotel.UserName, QueryData.InfoDAO.FindAccount(notification.Hotel.UserName),
                    Data.User.UserName, Data.User.Name,
                    DateTime.Now,
                    "Cảm ơn quý khách đã tin tưởng.\nHẹn gặp lại quý khách.",
                    false,
                    notification.Hotel,
                    notification.Room,
                    notification.DepositCoins,
                    "Bạn đã hủy phòng thành công.",
                    notification.CheckIn,
                    notification.CheckOut,
                    idNotificationClient);

                Data.Notifications.Add(notification2);
                QueryData.NotificationDAO.Insert(notification2);
                QueryData.IdDAO.ChangeId();

                QueryData.NotificationDAO.Delete(notification);

                FController.Instance.MessageSuccess("Thông báo", "Bạn đã hủy phòng thành công.", (FNotification)Tag, (s, ev) => { Dispose(); });
            }
        }
    }
}
