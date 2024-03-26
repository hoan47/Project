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
        public FShowHotelRoom(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            userControlLableAddress.LableText = hotel.Address.AddressValue;
            userControlLableName.LableText = hotel.Name;
            userControlLablePhone.LableText = hotel.Phone;
            pictureBox.Image = hotel.GetImageHotel();
            currentImage = hotel.Images?.First();
            listBoxService.DataSource = hotel.Services;
            richTextBoxDescribe.Text = hotel.Describe;
            foreach(Room room in hotel.Rooms)
            {
                UserControlShowRoom userControlShowRoom = new UserControlShowRoom(room);

                userControlShowRoom.Tag = this;
                flowLayoutPanel.Controls.Add(userControlShowRoom);
            }    
        }

        private void FShowRoom_Load(object sender, EventArgs e)
        {

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
    }
}
