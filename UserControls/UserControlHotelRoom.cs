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
        public UserControlHotelRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlHomePaceSearchRoomDoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Thông tin phòng");
        }
    }
}
