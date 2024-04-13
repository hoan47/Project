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
    public partial class FUpdatePrice : Form
    {
        private Hotel hotel;

        public FUpdatePrice(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            ((FHotelManage)Tag).LoadData();
            ((FHotelManage)Tag).EnabledGroupBox();
            Dispose();
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
        }

        private void FDiscountLoad(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void LoadUI()
        {
        }

        private string UpdateValueStr(int value)
        {
            return (value < 100 ? "Giảm: " : "Tăng: ") + Math.Abs(100 - value).ToString() + "%";
        }

        private void pictureBoxEnd_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDownValueChanged(object sender, EventArgs e)
        {
            label.Text = NumericUpDown.Value.ToString() + "%";
        }
    }
}
