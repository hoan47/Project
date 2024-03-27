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

            UserControl[] userControls = new UserControl[] { new UserControlNotificationService(), new UserControlNotificationHotel(), new UserControlNotificationCoins() };

            foreach(UserControl userControl in userControls)
            {
                userControl.Tag = this;
                flowLayoutPanel.Controls.Add(userControl);
            }    
        }

        public void OpenFormChild(Panel panel, Form formChild)
        {
            ((FMain)Tag).OpenFormChild(panel, formChild, this);
        }

        private void FNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
