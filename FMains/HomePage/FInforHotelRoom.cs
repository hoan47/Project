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
    public partial class FInforHotelRoom : Form
    {
        public FInforHotelRoom(Hotel hotel, Room room)
        {
            InitializeComponent();
        }

        private void FHomePaceInformationRoomLoad(object sender, EventArgs e)
        {

        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}