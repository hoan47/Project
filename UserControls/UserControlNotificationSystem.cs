﻿using System;
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
    public partial class UserControlNotificationSystem : UserControl
    {
        NotificationSystem notification;

        public UserControlNotificationSystem(NotificationSystem notification)
        {
            InitializeComponent();
            this.notification = notification;
            groupBox.Text = "Người gửi: Hệ thống";
            labelSendingTime.Text = notification.Time.ToString("dd/MM/yyyy HH:mm:ss");
            labelContent.Text = notification.Content;
            circleButton.Visible = !notification.IsWatched;
        }

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
            notification.Watched();
            QueryData.NotificationDAO.Update(notification);
        }
    }
}
