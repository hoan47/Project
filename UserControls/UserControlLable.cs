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
    public partial class UserControlLable : UserControl
    {
        private UserControl userParent;
        public string GroupBoxText { get { return groupBox.Text; } set { groupBox.Text = value; } }
        public Image PictureBoxImage { get { return pictureBox.Image; } set { pictureBox.Image = value; } }
        public string LableText { get { return label.Text; } set { label.Text = value; } }

        public UserControlLable()
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