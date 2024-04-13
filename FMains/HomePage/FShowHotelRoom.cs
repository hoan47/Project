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
    public partial class FShowHotelRoom : Form
    {
        private Hotel hotel;
        private Image_ currentImage;
        private DateTime firstDay;
        private DateTime lastDay;
        private int price;

        public FShowHotelRoom(Hotel hotel, DateTime firstDay, DateTime lastDay, int price)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.firstDay = firstDay;
            this.lastDay = lastDay;
            this.price = price;
        }

        private void FShowRoom_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        public void LoadUI()
        {
            userControlLableAddress.LableText = hotel.Address.AddressValue;
            userControlLableName.LableText = hotel.Name;
            userControlLablePhone.LableText = hotel.Phone;
            pictureBox.Image = hotel.GetImageHotel();
            currentImage = hotel.Images?.First();
            listBoxService.DataSource = hotel.Services;
            richTextBoxDescribe.Text = hotel.Describe;
            ShowRooms();
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if(hotel.Images == null)
            {
                return;
            }
            int index = hotel.Images.IndexOf(currentImage) - 1;

            pictureBox.Image = (currentImage = index < 0 ? hotel.Images.Last() : hotel.Images[index]).Image;
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (hotel.Images == null)
            {
                return;
            }
            int index = hotel.Images.IndexOf(currentImage) + 1;

            pictureBox.Image = (currentImage = index >= hotel.Images.Count ? hotel.Images.First() : hotel.Images[index]).Image;
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            ShowRooms(SearchCriteria);
        }

        private bool SearchCriteria(Room room)
        {
            return numericUpDownPeople.Value <= room.NumberPeople &&
                numericUpDownBed.Value <= room.NumberBeds &&
                numericUpDownRoom.Value <= room.NumberRoom &&
                CheckAmenities(room);
        }

        private void ShowRooms(Func<Room, bool> SearchCriteria = null)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Room room in hotel.Rooms)
            {
                if(room.Price <= price)
                {
                    if(CheckDateTime(firstDay, lastDay, room) == true)
                    {
                        if (SearchCriteria == null || SearchCriteria(room) == true)
                        {
                            UserControlShowRoom userControlShowRoom = new UserControlShowRoom(room);

                            userControlShowRoom.Tag = this;
                            flowLayoutPanel.Controls.Add(userControlShowRoom);
                        }
                    }
                }
            }
        }

        private bool CheckDateTime(DateTime firstDay, DateTime lastDay, Room room)
        {
            if(room.CheckInOuts == null)
            {
                return true;
            }
            foreach(KeyValuePair<DateTime, DateTime> keyValuePair in room.CheckInOuts)
            {
                if (keyValuePair.Key.Date <= firstDay.Date && firstDay.Date < keyValuePair.Value.Date)
                {
                    return false;
                }
                if (keyValuePair.Key.Date < lastDay.Date && lastDay.Date <= keyValuePair.Value.Date)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckAmenities(Room room)
        {
            foreach(string item in checkedListBoxAmenities.CheckedItems)
            {
                if (room.Amenitiese.Contains(item) == false) return false;
            }
            return true;
        }

        public void OpenInfoHotelRoom(Room room)
        {
            FMain.Instance.OpenFormChild(panel, new FInforHotelRoom(hotel, room, firstDay, lastDay), this);
        }

        private void ButonBackClick(object sender, EventArgs e)
        {
            FMain.Instance.ChangeColerToolStripButton((FHomePage)Tag);
            Dispose();
        }
    }
}
