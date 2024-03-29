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
    public partial class FHomePage : Form
    {
        public FHomePage()
        {
            InitializeComponent();
        }

        private void FHomePageLoad(object sender, EventArgs e)
        {
            ShowHotels();
        }

        private void ShowHotels(Func<Hotel, bool> searchCriteria = null)
        {
            foreach (Hotel hotel in Data.HotelServices)
            {
                if (searchCriteria == null || searchCriteria(hotel) == true)
                {
                    UserControlShowHotel userControlHotel = new UserControlShowHotel(hotel);

                    userControlHotel.Tag = this;
                    flowLayoutPanel.Controls.Add(userControlHotel);
                }
            }
        }

        public void OpenHotel(Hotel hotel)
        {
            FMain.Instance.OpenFormChild(null, new FShowHotelRoom(hotel, userControlDateTimePackerIn.DateTimePacker, userControlDateTimePackerOut.DateTimePacker), this);
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            ShowHotels(SearchCriteria);
        }

        private bool SearchCriteria(Hotel hotel)
        {
            return userControlAddressRoom.ComboBoxText == hotel.Address.ProvinceAndDistrict &&
                    CheckPrice(userControlPrice.Price, hotel.Rooms) &&
                    CheckService(checkedListBoxService, hotel);
        }
        private bool CheckPrice(int price, List<Room> rooms)
        {
            foreach (Room room in rooms)
            {
                if (price <= room.Price)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckService(CheckedListBox checkedListBoxService, Hotel hotel)
        {
            foreach (string item in checkedListBoxService.CheckedItems)
            {
                if (hotel.Services.Contains(item) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}