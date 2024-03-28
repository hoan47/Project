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
            Data.Notifications.Reverse();
            foreach (Notification notification in Data.Notifications)
            {
                Control control = new Control();

                switch (notification.Type)
                {
                    case Notification.EType.System:
                        control = new UserControlNotificationSystem(notification);
                        break;
                    case Notification.EType.Coins:
                        control = new UserControlNotificationCoins(notification);
                        break;
                }
                control.Tag = this;
                flowLayoutPanel.Controls.Add(control);

            }
            Data.Notifications.Reverse();
        }
    }
}
