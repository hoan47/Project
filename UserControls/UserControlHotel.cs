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
        private Hotel hotel;

        public UserControlHotel(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
            groupBox.Text = "Tên Khách Sạn: " + hotel.Name;
            labelAddress.Text = hotel.Address.AddressValue;
            labelPhone.Text = hotel.Phone;
            labelPrice.Text = hotel.PriceMinMaxStr();
            pictureBoxHotel.Image = hotel.GetImageHotel();
        }
        public void UserControlHottelDoubleClick(object sender, EventArgs e)
        {
            ((FService)Tag).OpenHotelManager(hotel);
        }
    }
}