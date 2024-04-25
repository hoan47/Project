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
        public static List<User> NotMeUsers { get; private set; }
        public static List<Notification> Notifications { get; private set; }

        static Data()
        {
            User = new User();
            NotMeUsers = new List<User>();
            Notifications = new List<Notification>();
        }
    }
}
