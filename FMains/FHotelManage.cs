using Guna.UI2.WinForms;
using Project.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Project
{
    public partial class FHotelManage : Form
    {
        private Hotel hotel;

        public FHotelManage(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {

        }
    }
}
