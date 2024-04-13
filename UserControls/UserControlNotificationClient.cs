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
  
        public string TextButtonCanCel { get { return buttonCancel.Text; } set { buttonCancel.Text = value; } }
        
       
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
            CheckStatus();



        }
      

       
        private void ButtonCancelClick(object sender, EventArgs e)
        {

            FCancelRoom fCancel = new FCancelRoom(notification);
            ((FNotification)Tag).OpenFormChild(panel, fCancel); 
           
       }
        public bool CheckStatus()
        {
            if(notification.Status=="Đã Huỷ Phòng")
            {
                buttonCancel.Text = "Đã Huỷ";
                buttonCancel.Enabled = false;
              
                return true;
            }
            return false;
        }
      

        private void CircleButtonClick(object sender, EventArgs e)
        {
            circleButton.Visible = false;
            notification.Watched();
            QueryData.NotificationDAO.Update(notification);
        }

       
    }
}
