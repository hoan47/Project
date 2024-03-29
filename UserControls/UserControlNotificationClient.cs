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
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            ((FNotification)Tag).OpenFormChild(panel, new FCancelRoom());
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
            notification.Watched();
            QueryData.NotificationDAO.Update(notification);
        }
    }
}
