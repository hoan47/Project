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
        public DateTime CheckInOut { get; private set; }
        public bool IsFood { get; private set; }
        public bool IsPool { get; private set; }
        public bool IsCarPark { get; private set; }
        public bool IsCook { get; private set; }

        public Hotel(User user, string name, string phone, string address, DateTime checkInOut, bool isFood, bool isPool, bool isCarPark, bool isCook)
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
        }
    }
}
