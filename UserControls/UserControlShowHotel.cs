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
    public partial class UserControlShowHotel : UserControl
    {
        private Hotel hotel;

        public UserControlShowHotel(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            labelName.Text = "Tên: " + hotel.Name;
            labelAddress.Text = "Địa chỉ: " + hotel.Address.AddressValue;
            labelPhone.Text = "Số điện thoại: " + hotel.Phone;
            labelPrice.Text = hotel.PriceMinMaxStr();
            pictureBox.Image = hotel.GetImageHotel();
        }

        private void UserControlHomePaceSearchRoomClick(object sender, EventArgs e)
        {
            ((FHomePage)Tag).OpenHotel(hotel);
        }
    }
}