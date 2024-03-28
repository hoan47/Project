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
    public partial class UserControlNotificationService : UserControl
    {
        public UserControlNotificationService()
        {
            InitializeComponent();
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
