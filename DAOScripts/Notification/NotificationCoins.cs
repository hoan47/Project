using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationCoins : Notification
    {
        public NotificationCoins(User sender, User receiver, DateTime time, string content, bool isWatched) : base(sender, receiver, time, content, isWatched)
        { }
    }
}
