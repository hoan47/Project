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
    public partial class UserControlHotelEdit : UserControl
    {
        private UserControl userParent;
        public string GroupBoxText { get { return groupBoxHotelEdit.Text; } set { groupBoxHotelEdit.Text = value; } }
        public Image PictureBoxHotelEdit { get { return pictureBoxHotelEdit.Image; } set { pictureBoxHotelEdit.Image = value; } }
        public string LabelHotelEdit { get { return labelHotelEdit.Text; } set { labelHotelEdit.Text = value; } }

        public UserControlHotelEdit(UserControl userParent)
        {
            InitializeComponent();
            this.userParent = userParent;
        }

        private void DoubleClickUser(object sender, EventArgs e)
        {
            if(userParent is UserControlHotel user)
            {
                user.UserControlHottelDoubleClick(sender, e);
            }
        }
    }
}
