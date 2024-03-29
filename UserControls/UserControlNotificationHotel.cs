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
    public partial class UserControlNotificationHotel : UserControl
    {
        private NotificationHotel notification;

        public UserControlNotificationHotel(NotificationHotel notification)
        {
            InitializeComponent();
            this.notification = notification;
            groupBox.Text = "Tên khách hàng: " + notification.NameSender;
            labelSendingTime.Text = notification.Time.ToString("dd/MM/yyyy HH:mm:ss");
            richTextBoxMessage.Text = notification.Content;
            labelPhone.Text = "SĐT: " + notification.Hotel.Phone;
            labelNameHotel.Text = "Tên khách sạn: " + notification.Hotel.Name;
            labelNameRoom.Text = "Tên phòng: " + notification.Room.Name;
            labelPrice.Text = "Xu cọc: " + notification.DepositCoins.ToString();
            labelIn.Text = notification.CheckIn.ToString("dd/MM/yyyy HH:mm:ss");
            labelOut.Text = notification.CheckOut.ToString("dd/MM/yyyy HH:mm:ss");
            labelStatus.Text = notification.Status;
            circleButton.Visible = !notification.IsWatched;
        }

        private void ButtonProcessedClick(object sender, EventArgs e)
        {
            ((FNotification)Tag).OpenFormChild(panel, new FProcessedNotification());
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
            notification.Watched();
            QueryData.NotificationDAO.Update(notification);
        }
    }
}
