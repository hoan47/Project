using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationHotel : Notification
    {
        public Hotel Hotel { get; private set; }
        public Room Room { get; private set; }
        public int DepositCoins { get; private set; }
        public string Status { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public NotificationHotel(int idNotification, string userNameSender, string nameSender, string userNameReceiver, string nameReceiver, DateTime time, string content, bool isWatched, Hotel hotel, Room room, int depositCoins, string status, DateTime checkIn, DateTime checkOut) : base(idNotification, userNameSender, nameSender, userNameReceiver, nameReceiver, time, content, isWatched)
        {
            Hotel = hotel;
            Room = room;
            DepositCoins = depositCoins;
            Status = status;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
