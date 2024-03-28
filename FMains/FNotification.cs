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
            ((FMain)Tag).OpenFormChild(panel, formChild, this);
        }

        private void FNotificationLoad(object sender, EventArgs e)
        {
            Data.Notifications.Sort((a, b) => b.Time.CompareTo(a.Time));
            foreach (Notification notification in Data.Notifications)
            {
                Control control = new Control();

                if (notification is NotificationSystem)
                {
                    control = new UserControlNotificationSystem((NotificationSystem)notification);
                }
                else if (notification is NotificationCoins)
                {
                    control = new UserControlNotificationCoins((NotificationCoins)notification);
                }
                else if (notification is NotificationHotel)
                {
                    control = new UserControlNotificationHotel((NotificationHotel)notification);
                }
                else
                {
                    control = new UserControlNotificationClient((NotificationClient)notification);
                }
                control.Tag = this;
                flowLayoutPanel.Controls.Add(control);
            }
        }
    }
}
