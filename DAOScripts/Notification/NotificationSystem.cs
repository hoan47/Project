using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationSystem : Notification
    {
        public NotificationSystem(int idNotification, string userNameReceiver, string nameReceiver, DateTime time, string content, bool isWatched) : base(idNotification, null, null, userNameReceiver, nameReceiver, time, content, isWatched)
        { }
    }
}
