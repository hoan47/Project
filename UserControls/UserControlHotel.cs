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
    public partial class UserControlHotel : UserControl
    {
        public UserControlHotel()
        {
            InitializeComponent();
            userControlHotelEditAddress.GetData(this);
            userControlHotelEditName.GetData(this);
            userControlHotelEditPhone.GetData(this);
            userControlHotelEditPrice.GetData(this);
        }

        public void UserControlHottelDoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn khách sạn");
        }
    }
}