using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Hotel
    {
        public string UserName { get; private set; }
        public int IdHotel { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
        public TimeSpan CheckIn { get; private set; }
        public TimeSpan CheckOut { get; private set; }
        public string Describe { get; private set; }
        public List<Image_> Images { get; private set; }
        public List<string> Services { get; private set; }
        public List<Room> Rooms { get; private set; }
        public List<UpdatePrice> UpdatePrices { get; private set; }


        public Hotel(string userName, int id, string name, string phone, Address address, TimeSpan checkIn, TimeSpan checkOut, string describe)
        {
            UserName = userName;
            IdHotel = id;
            Name = name;
            Phone = phone;
            Address = address;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Describe = describe;
        }

        public string PriceMinMaxStr()
        {
            if(Rooms == null)
            {
                return "0 - 0";
            }
            int minPrice = int.MaxValue;
            int maxPrice = int.MinValue;
            foreach (Room room in Rooms)
            {
                minPrice = Math.Min(minPrice, room.Price);
                maxPrice = Math.Max(maxPrice, room.Price);
            }
            return minPrice.ToString() + " - " + maxPrice.ToString();
        }

        public void UpdateInfor(string name, string phone, Address address, TimeSpan checkIn, TimeSpan checkOut, string describe)
        {
            Name = name;
            Phone = phone;
            Address = address;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Describe = describe;
        }

        public void UpdateService(List<string> services)
        {
            Services = services;
        }

        public Image GetImageHotel(bool isFirst = true)
        {
            return Images != null ? (Images.Count > 0 ? (isFirst == true ? Images.First().Image : Images.Last().Image) : Properties.Resources.noImage) : Properties.Resources.noImage;
        }

        public void AddImage(Image_ image)
        {
            if (Images == null)
            {
                Images = new List<Image_>();
            }
            Images.Add(image);
        }

        public void AddRoom(Room room)
        {
            if (Rooms == null)
            {
                Rooms = new List<Room>();
            }
            Rooms.Add(room);
        }

        public void AddUpdatePrice(UpdatePrice updatePrice)
        {
            if (UpdatePrices == null)
            {
                UpdatePrices = new List<UpdatePrice>();
            }
            UpdatePrices.Add(updatePrice);
        }

        public bool IsName(out string message)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                message = "Tên khách sạn không được để trống.";
                return false;
            }
            message = "Tên khách sạn hợp lệ.";
            return true;
        }

        public bool IsAddress(out string message)
        {
            return CheckInfor.IsAddRess(Address.ProvinceAndDistrict, out message);
        }

        public bool IsPhone(out string message)
        {
            return CheckInfor.IsPhone(Phone, out message);
        }

    }
}

public class Image_
{
    public int IdImage { get; private set; }
    public byte[] ImageBytes { get; private set; }
    public Image Image { get; private set; }

    public Image_(int idImage, byte[] imageBytes, Image image)
    {
        IdImage = idImage;
        ImageBytes = imageBytes;
        Image = image;
    }
}