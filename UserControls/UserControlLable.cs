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
    public partial class UserControlerLable : UserControl
    {
        private UserControl userParent;
        public string GroupBoxText { get { return groupBox.Text; } set { groupBox.Text = value; } }
        public Image PictureBoxImage { get { return pictureBoxHotelEdit.Image; } set { pictureBoxHotelEdit.Image = value; } }
        public string LableText { get { return labelContect.Text; } set { labelContect.Text = value; } }

        public UserControlerLable()
        {
            InitializeComponent();

        }

        public void GetData(UserControl userParent)
        {
            this.userParent = userParent;
        }

        private void DoubleClickUser(object sender, EventArgs e)
        {
            if (userParent is UserControlHotel user)
            {
                user.UserControlHottelDoubleClick(sender, e);
            }
        }
    }
}