using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class HotelRoom
    {
        public string NameHotel { get; private set; }
        public Address Address { get; private set; }
        public string NameRoom { get; private set; }
        public int Bedroom { get; private set; }
        public int Bed { get; private set; }
        public int People { get; private set; }
        public TimeSpan CheckIn { get; private set; }
        public TimeSpan CheckOut { get; private set; }
        public DateTime DateCheckIn { get; private set; }
        public DateTime DateCheckOut { get; private set; }
        public string Phone { get; private set; }
        public double Area { get; private set; }
        public int Price { get; private set; }
        public string Describe { get; private set; }
        public List<Image_> ImagesHotel { get; private set; }
        public List<Image_> ImagesRoom { get; private set; }
        public List<string> Services { get; private set; }
        public HotelRoom()
        {

        }
        public HotelRoom(string NameHotel, Address Address, string NameRoom, int Bedroom, int Bed, int People, TimeSpan CheckIn, TimeSpan CheckOut, DateTime DateCheckIn, DateTime DateCheckOut, string Phone, double Area, int Price, string Describe)
        {
            this.NameHotel = NameHotel;
            this.NameHotel = NameHotel;
            this.Address = Address;
            this.NameRoom = NameRoom;
            this.Bedroom = Bedroom;
            this.Bed = Bed;
            this.People = People;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.DateCheckIn = DateCheckIn;
            this.DateCheckOut = DateCheckOut;
            this.Phone = Phone;
            this.Area = Area;
            this.Price = Price;
            this.Describe = Describe;
        }
        public HotelRoom(string NameHotel, Address address)
        {
            this.NameHotel = NameHotel;
        }
    }
}