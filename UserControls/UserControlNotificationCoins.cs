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
    public partial class UserControlNotificationCoins : UserControl
    {
        private Notification notification;
        public UserControlNotificationCoins(Notification notification)
        {
            InitializeComponent();
            this.notification = notification;
            groupBox.Text = "Người gửi: " + (notification.Sender == null ? "Hệ thống" : notification.Sender.Name);
            labelSendingTime.Text = notification.Time.ToString("dd/MM/yyyy HH:mm");
            labelContent.Text = notification.Content;
            circleButton.Visible = !notification.IsWatched;
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
            notification.Watched();
            ((FMain)((FNotification)Tag).Tag).UpdateNotificationNumber();
        }
    }
}
