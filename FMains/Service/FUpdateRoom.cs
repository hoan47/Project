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
    public partial class FUpdateRoom : Form
    {
        private Hotel hotel;
        private Room room;
        private Image_ currentImage;

        public FUpdateRoom(Hotel hotel, Room room)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.room = room;
            LoadData();
        }

        private void LoadData()
        {
            if (room != null)
            {
                panelImage.Visible = true;
                userControlTextBoxServiceName.TextBoxText = room.Name;
                userControlTextBoxServicePrice.TextBoxText = room.Price.ToString();
                userControlTextBoxAcreage.TextBoxText = room.Acreage.ToString();
                userControlServiceEdit.Value = room.Amenitiese;
                userControlNumericNumberRoom.NumericValue = room.NumberRoom;
                userControlNumericNumnberBed.NumericValue = room.NumberBeds;
                userControlNumericNumberPeople.NumericValue = room.NumberPeople;
                currentImage = room.Images?.First();
                pictureBox.Image = room.GetImageRoom();
            }
            else
            {
                panelImage.Visible = false;
                userControlServiceEdit.Value = new List<string>() { "Bếp điện", "Lò nướng", "Tủ lạnh", "Máy giặt", "Ban công" };
            }
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            ((FMain)((FService)((FHotelManage)Tag).Tag).Tag).ChangeColerToolStripButton((FHotelManage)Tag);
            ((FService)((FHotelManage)Tag).Tag).OpenHotelManager(hotel);
            Dispose();
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            string message;
            int acreage;
            decimal price;

            if(CheckInfor.IsPrice(userControlTextBoxServicePrice.TextBoxText, out message, out price) && CheckInfor.IsAcreage(userControlTextBoxAcreage.TextBoxText, out message, out acreage))
            {
                Room room = new Room(
                    DataAccess.IdDAO.SelectId,
                    userControlTextBoxServiceName.TextBoxText,
                    userControlNumericNumberRoom.NumericValue,
                    userControlNumericNumnberBed.NumericValue,
                    userControlNumericNumberPeople.NumericValue,
                    acreage,
                    (int)price);

                if(this.room == null)
                {
                    this.room = room;
                    hotel.AddRoom(room);
                    DataAccess.RoomDAO.Insert(hotel, room);
                    FController.Instance.MessageSuccess("Thông báo", "Tạo phòng mới thành công.", this);
                }
                else
                {
                    this.room.UpdateInfor(
                        userControlTextBoxServiceName.TextBoxText,
                        userControlNumericNumberRoom.NumericValue,
                        userControlNumericNumnberBed.NumericValue,
                        userControlNumericNumberPeople.NumericValue,
                        acreage,
                        (int)price);
                    DataAccess.RoomDAO.Update(this.room);
                    FController.Instance.MessageSuccess("Thông báo", "Cập nhật phòng thành công.", this);
                }
                this.room.UpdateAmenities(userControlServiceEdit.Value);
                DataAccess.AmenitiesDAO.Delete(this.room);
                DataAccess.AmenitiesDAO.Insert(this.room);
                DataAccess.IdDAO.ChangeId();
                LoadData();
                return;
            }
            FController.Instance.MessageWarning("Thông báo", message, this);
        }

        private void ButtonUploadImageClick(object sender, EventArgs e)
        {
            Image image = ProcessImage.OpenFileImageDialog();

            if (image != null)
            {
                currentImage = new Image_(DataAccess.IdDAO.SelectId, ProcessImage.ImageToByteArray(image), image);
                room.AddImage(currentImage);
                DataAccess.ImageRoomDAO.Insert(room, currentImage);
                DataAccess.IdDAO.ChangeId();
                pictureBox.Image = image;
            }
        }

        private void ButtonDeleteImageClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = room.Images.IndexOf(currentImage) + 1;

            room.Images.Remove(currentImage);
            DataAccess.ImageRoomDAO.Delete(currentImage);
            currentImage = room.Images.Count != 0 ? room.Images[indexImage >= room.Images.Count ? 0 : indexImage] : null;
            pictureBox.Image = currentImage == null ? Properties.Resources.noImage : currentImage.Image;
        }

        private void ButtonLeftClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = room.Images.IndexOf(currentImage) - 1;

            pictureBox.Image = (currentImage = indexImage < 0 ? room.Images.Last() : room.Images[indexImage]).Image;
        }

        private void ButtonRightClick(object sender, EventArgs e)
        {
            if (IsZeroImage() == true)
            {
                return;
            }
            int indexImage = room.Images.IndexOf(currentImage) + 1;

            pictureBox.Image = (currentImage = indexImage >= room.Images.Count ? room.Images.First() : room.Images[indexImage]).Image;
        }

        private bool IsZeroImage()
        {
            return room.Images == null || room.Images.Count == 0;
        }
    }
}
