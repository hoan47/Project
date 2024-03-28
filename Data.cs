using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Data
    {
        public static User User { get; private set; }
        public static List<Hotel> HotelServices { get; private set; }
        public static List<Notification> Notifications { get; private set; }

        static Data()
        {
            User = new User();
            HotelServices = new List<Hotel>();
            Notifications = new List<Notification>();
        }
    }
}
