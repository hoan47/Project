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
            userControlDateTimePackerIn.DateTimePacker = DateTime.Now;
            userControlDateTimePackerOut.DateTimePacker = DateTime.Now.AddDays(1);
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
            FMain.Instance.OpenFormChild(null, new FShowHotelRoom(hotel, userControlDateTimePackerIn.DateTimePacker, userControlDateTimePackerOut.DateTimePacker, userControlPrice.Price), this);
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            if (userControlDateTimePackerOut.DateTimePacker <= userControlDateTimePackerIn.DateTimePacker)
            {
                FController.Instance.MessageWarning("Thông báo", "Thời gian không hợp lệ", this);
                return;
            }
            flowLayoutPanel.Controls.Clear();
            ShowHotels(SearchCriteria);
        }

        private bool SearchCriteria(Hotel hotel)
        {
            return CheckAddress(hotel) &&
                CheckPriceDateTime(hotel) &&
                CheckService(hotel);
        }

        private bool CheckAddress(Hotel hotel)
        {
            if (userControlAddressRoom.ComboBoxText == "")
            {
                return true;
            }
            if (hotel.Address.ProvinceAndDistrict.Contains(userControlAddressRoom.ComboBoxText) == true)
            {
                return true;
            }
            if( hotel.Address.ProvinceAndDistrict == userControlAddressRoom.ComboBoxText)
            {
                return true;
            }
            return false;
        }

        private bool CheckPriceDateTime(Hotel hotel)
        {
            if(hotel.Rooms == null)
            {
                return false;
            }
            foreach (Room room in hotel.Rooms)
            {
                if (room.Price <= userControlPrice.Price)
                {
                    if (room.CheckInOuts == null)
                    {
                        return true;
                    }
                    foreach (KeyValuePair<DateTime, DateTime> keyValuePair in room.CheckInOuts)
                    {
                        if (keyValuePair.Key <= userControlDateTimePackerIn.DateTimePacker && userControlDateTimePackerIn.DateTimePacker < keyValuePair.Value)
                        {
                            break;
                        }
                        if (keyValuePair.Key < userControlDateTimePackerOut.DateTimePacker && userControlDateTimePackerOut.DateTimePacker <= keyValuePair.Value)
                        {
                            break;
                        }
                        return true;
                    }
                }
            }
            return false;
        }
        private bool CheckService(Hotel hotel)
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

        private void userControlPrice_Load(object sender, EventArgs e)
        {

        }
    }
}