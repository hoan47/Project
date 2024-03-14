using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Hotel
    {
        private List<Room> rooms;
        public User User { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public TimeSpan CheckInOut { get; private set; }
        public bool IsFood { get; private set; }
        public bool IsPool { get; private set; }
        public bool IsCarPark { get; private set; }
        public bool IsCook { get; private set; }
        public string Describe { get; private set; }
        public int Id { get; set; }

        public Hotel(User user, string name, string phone, string address, TimeSpan checkInOut, bool isFood, bool isPool, bool isCarPark, bool isCook, string describe, int id)
        {
            User = user;
            Name = name;
            Phone = phone;
            Address = address;
            CheckInOut = checkInOut;
            IsFood = isFood;
            IsPool = isPool;
            IsCarPark = isCarPark;
            IsCook = isCook;
            Describe = describe;
            Id = id;
        }

        public void AddRoom(Room room)
        {
            if (rooms == null)
            {
                rooms = new List<Room>();
            }
            rooms.Add(room);
        }

        public bool IsPhone()
        {
            return CheckInfo.IsPhone(Phone);
        }
    }
}
