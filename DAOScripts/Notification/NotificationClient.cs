using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationClient : Notification
    {
        public NotificationClient(User sender, User receiver, DateTime time, string content, bool isWatched, string type) : base(sender, receiver, time, content, isWatched, type)
        { }

    }
}
