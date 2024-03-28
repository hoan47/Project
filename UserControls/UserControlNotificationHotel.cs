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
        private Notification notification;

        public UserControlNotificationHotel(Notification notification)
        {
            InitializeComponent();
            this.notification = notification;

        }

        private void ButtonProcessedClick(object sender, EventArgs e)
        {
            ((FNotification)Tag).OpenFormChild(panel, new FProcessedNotification());
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
        }
    }
}
