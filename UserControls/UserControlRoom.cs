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
    public partial class UserControlRoom : UserControl
    {
        private Room room;

        public UserControlRoom(Room room)
        {
            InitializeComponent();
            UpdateUI(room);
        }

        private void UserControlClick(object sender, EventArgs e)
        {
            ((FHotelManage)Tag).OpenUpdateRoom(room);
        }

        public void UpdateUI(Room room)
        {
            this.room = room;
            groupBox.Text = "Tên phòng: " + room.Name;
            labelStatus.Text = "Trạng thái: " + room.GetStatusStr();
        }

    }
}
