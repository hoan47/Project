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
    public partial class FNotification : Form
    {
        public FNotification()
        {
            InitializeComponent();
        }

        public void OpenFormChild(Panel panel, Form formChild)
        {
            FMain.Instance.OpenFormChild(panel, formChild, this);
        }

        private void FNotificationLoad(object sender, EventArgs e)
        {
            Data.Notifications.Sort((a, b) => b.Time.CompareTo(a.Time));
            foreach (Notification notification in Data.Notifications)
            {
                Control control = new Control();

                if (notification is NotificationSystem notificationSystem)
                {
                    control = new UserControlNotificationSystem(notificationSystem);
                }
                else if (notification is NotificationCoins notificationCoins)
                {
                    control = new UserControlNotificationCoins(notificationCoins);
                }
                else if (notification is NotificationHotel notificationHotel)
                {
                    control = new UserControlNotificationHotel(notificationHotel);
                }
                else if (notification is NotificationClient notificationClient)
                {
                    control = new UserControlNotificationClient(notificationClient);
                }
                control.Tag = this;
                flowLayoutPanel.Controls.Add(control);
            }
        }
       public void LoadData(object sender, EventArgs e)
        {
            FNotificationLoad(sender,e);
        }
    }
}
