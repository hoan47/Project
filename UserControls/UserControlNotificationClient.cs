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
        private Notification notification;

        public UserControlNotificationClient(Notification notification)
        {
            InitializeComponent();
            this.notification = notification;
            groupBox.Text = "Tên khách hàng: " + notification.Sender.Name;
            labelSendingTime.Text = notification.Time.ToString("dd/MM/yyyy HH:mm");
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            ((FNotification)Tag).OpenFormChild(panel, new FCancelRoom());
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {

        }
    }
}
