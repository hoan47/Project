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
    public partial class UserControlShowRoom : UserControl
    {
        private Room room;

        public UserControlShowRoom(Room room)
        {
            InitializeComponent();
            this.room = room;

        }

        private void LoadUI()
        {
            pictureBox.Image = room.GetImageRoom();
            groupBox.Text = "Tên phòng: " + room.Name;
            labelNumberPeople.Text = room.NumberPeople.ToString();
            labelNumberRoom.Text = room.NumberRoom.ToString();
            labelNumberBed.Text = room.NumberBeds.ToString();
            labelOldPrice.Text = room.OldPrice.ToString();
            labelPrice.Text = room.Price.ToString();
        }

        private void ShowRoomClick(object sender, EventArgs e)
        {
            ((FShowHotelRoom)Tag).OpenInfoHotelRoom(room);
        }

        private void UserControlShowRoomLoad(object sender, EventArgs e)
        {
            LoadUI();
        }
    }
}
