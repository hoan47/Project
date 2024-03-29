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
            labelNumberPeople.Text = "Số người: " + room.NumberPeople.ToString();
            labelNumberRoom.Text = "Số phòng ngủ: " + room.NumberRoom.ToString();
            labelNumberBed.Text = "Số giường: " + room.NumberBeds.ToString();
            labelAcreage.Text = "Diện tích: " + room.Acreage.ToString() + " m^2";
            labelOldPrice.Text = room.OldPrice.ToString();
            labelPrice.Text = room.Price.ToString();

            labelOldPrice .Visible = pictureBoxSale.Visible = room.OldPrice > room.Price;
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
