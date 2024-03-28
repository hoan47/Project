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
            Data.Notifications.Sort((a, b) => a.Time.CompareTo(b.Time));
            foreach (Notification notification in Data.Notifications)
            {
                Control control = new Control();

                switch (notification.Type)
                {
                    case "system":
                        control = new UserControlNotificationSystem(notification);
                        break;
                    case "coins":
                        control = new UserControlNotificationCoins(notification);
                        break;
                    case "hotel":
                        control = new UserControlNotificationHotel(notification);
                        break;
                }
                control.Tag = this;
                flowLayoutPanel.Controls.Add(control);

            }
        }
    }
}
