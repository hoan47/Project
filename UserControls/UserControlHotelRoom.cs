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
    public partial class UserControlHotelRoom : UserControl
    {
        private HotelRoom hotelRoom;
        public UserControlHotelRoom(HotelRoom hotelRoom)
        {
            InitializeComponent();
            this.hotelRoom = hotelRoom;
            labelName.Text = "Tên: " + hotelRoom.NameHotel + ", " + hotelRoom.NameRoom;
            labelPhone.Text = "SDT: " + hotelRoom.Phone;
            labelPrice.Text = "Giá: " + hotelRoom.Price + " VND";
            labelAddress.Text = "Địa chỉ: " + hotelRoom.Address.AddressValue;
        }
       
        private void UserControlHomePaceSearchRoomDoubleClick(object sender, EventArgs e)
        {
            ((FHomePage)Tag).OpenInforHotelRoom(hotelRoom);
        }
    }
}
