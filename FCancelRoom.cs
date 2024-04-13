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
    public partial class FCancelRoom : Form
    {
   

        private NotificationClient notification;
    
        public FCancelRoom(NotificationClient notification)
        {
            InitializeComponent();
            this.notification = notification;
          
          
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            Dispose();
        }

        public void ButtonComfirmClick(object sender, EventArgs e)
        {
          
            notification.Status = "Đã Huỷ Phòng";
            QueryData.NotificationDAO.Update(notification);
            QueryData.Access();
            FMain.Instance.OpenFormChild(new FNotification(), null);

           





        }
    }
}