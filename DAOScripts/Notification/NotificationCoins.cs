using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationCoins : Notification
    {
        public NotificationCoins(int idNotification, string userNameSender, string nameSender, string userNameReceiver, string nameReceiver, DateTime time, string content, bool isWatched) : base(idNotification, userNameSender, nameSender, userNameReceiver, nameReceiver, time, content, isWatched)
        { }
    }
}
