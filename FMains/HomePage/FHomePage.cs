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
            userControlDateTimePackerIn.DateTime = DateTime.Now;
            userControlDateTimePackerOut.DateTime = DateTime.Now.AddDays(1);
            ShowHotels(null);
        }

        public void OpenHotel(Hotel hotel)
        {
            ((FMain)Tag).OpenFormChild(null, new FShowHotelRoom(hotel), this);
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            if(userControlAddressHotel.ComboBoxText == "")
            {
                MessageBox.Show("Nhập đầy đủ địa chỉ!");
                return;
            }
            if(userControlDateTimePackerOut.DateTime <= userControlDateTimePackerIn.DateTime)
            {
                MessageBox.Show("Thời gian không hợp lệ");
                return;
            }
            flowLayoutPanel.Controls.Clear();
            ShowHotels(SearchCriteria);
        }

        private void ShowHotels(Func<Hotel, bool> SearchCriteria)
        {
            foreach (Hotel hotel in Data.HotelServices)
            {
                if (SearchCriteria == null || SearchCriteria(hotel) == true)
                {
                    UserControlShowHotel userControlHotel = new UserControlShowHotel(hotel);

                    userControlHotel.Tag = this;
                    flowLayoutPanel.Controls.Add(userControlHotel);
                }
            }
        }
        private bool SearchCriteria(Hotel hotel)
        {
            return userControlAddressHotel.ComboBoxText == hotel.Address.ProvinceAndDistrict &&
                CheckPriceDateTime(hotel) &&
                CheckService(hotel);
        }
        private bool CheckPriceDateTime(Hotel hotel)
        {
            foreach(Room room in hotel.Rooms)
            {
                if(room.Price <= userControlPrice.Price)
                {
                    if(room.CheckInOuts == null)
                    {
                        return true;
                    }
                    foreach (KeyValuePair<DateTime, DateTime> keyValuePair in room.CheckInOuts)
                    {
                        if (keyValuePair.Key <= userControlDateTimePackerIn.DateTime && userControlDateTimePackerIn.DateTime < keyValuePair.Value)
                        {
                            break;
                        }
                        if (keyValuePair.Key < userControlDateTimePackerOut.DateTime && userControlDateTimePackerOut.DateTime <= keyValuePair.Value)
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
    }
}