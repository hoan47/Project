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
            if(numericUpDown.Value == 100)
            {
                FController.Instance.MessageWarning("Thông báo", "Không cập nhật lại giá cũ.", this);
                return;
            }    
            foreach(Room room in hotel.Rooms)
            {
                room.UpdatePrice((double)numericUpDown.Value / 100);
                QueryData.RoomDAO.Update(room);
            }
            UpdatePrice updatePrice = new UpdatePrice(DateTime.Now, (int)numericUpDown.Value, hotel.Rooms.Count);

            hotel.AddUpdatePrice(updatePrice);
            QueryData.UpdatePriceDAO.Insert(hotel, updatePrice);
            FController.Instance.MessageSuccess("Thông báo", "Cập nhật thành công.", this);

            Notification notification = new NotificationSystem(QueryData.IdDAO.SelectId, Data.User.UserName, Data.User.Name, DateTime.Now, $"Bạn vừa cập nhật giá ({UpdateValueStr((int)numericUpDown.Value)}) cho khách sạn {hotel.Name}.", false);

            Data.Notifications.Add(notification);
            QueryData.NotificationDAO.Insert(notification);
            QueryData.IdDAO.ChangeId();

            LoadUI();
        }

        private void FDiscountLoad(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void LoadUI()
        {
            if (hotel.UpdatePrices == null)
            {
                return;
            }
            numericUpDown.Value = 100;
            listBox.Items.Clear();
            foreach (UpdatePrice updatePrice in hotel.UpdatePrices)
            {
                string time = "Thời gian: " + updatePrice.Time.ToString("dd/MM/yyyy HH:mm:ss");
                string value = UpdateValueStr(updatePrice.Value);
                string number = "Tổng số phòng: " + updatePrice.NumberRoom.ToString();

                listBox.Items.Add($"{time}, {value}, {number}");
            }
        }

        private string UpdateValueStr(int value)
        {
            return (value < 100 ? "Giảm: " : "Tăng: ") + Math.Abs(100 - value).ToString() + "%";
        }
    }
}
