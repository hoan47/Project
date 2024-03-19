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
        private List<Room> rooms;
        public int IdHotel { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
        public TimeSpan CheckIn { get; private set; }
        public TimeSpan CheckOut { get; private set; }
        public string Describe { get; private set; }
        public List<string> Services { get; private set; }
        public List<Image> Images { get; private set; }

        public Hotel()
        { }


        public Hotel(int id, string name, string phone, Address address, TimeSpan checkIn, TimeSpan checkOut, string describe)
        {
            IdHotel = id;
            Name = name;
            Phone = phone;
            Address = address;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Describe = describe;
        }

        public void UpdateInfo(string name, string phone, Address address, TimeSpan checkIn, TimeSpan checkOut, string describe)
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

        public void AddImage(Image image)
        {
            if (Images == null)
            {
                Images = new List<Image>();
            }
            Images.Add(image);
        }

        public void AddRoom(Room room)
        {
            if (rooms == null)
            {
                rooms = new List<Room>();
            }
            rooms.Add(room);
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
            return CheckInfo.IsAddRess(Address.ProvinceAndDistrict, out message);
        }

        public bool IsPhone(out string message)
        {
            return CheckInfo.IsPhone(Phone, out message);
        }

    }
}