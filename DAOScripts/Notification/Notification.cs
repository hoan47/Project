using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Notification
    {
        public int IdNotification { get; private set; }
        public string UserNameSender { get; private set; }
        public string NameSender { get; private set; }
        public string UserNameReceiver { get; private set; }
        public string NameReceiver { get; private set; }
        public DateTime Time { get; private set; }
        public string Content { get; private set; }
        public bool IsWatched { get; private set; }

        public Notification(int idNotification, string userNameSender, string nameSender, string userNameReceiver, string nameReceiver, DateTime time, string content, bool isWatched)
        {
            IdNotification = idNotification;
            UserNameReceiver = userNameReceiver;
            NameReceiver = nameReceiver;
            UserNameSender = userNameSender;
            NameSender = nameSender;
            Time = time;
            Content = content;
            IsWatched = isWatched;
        }

        public void Watched()
        {
            IsWatched = true;
        }

        public string GetTypeStr()
        {
            if(this is NotificationSystem)
            {
                return "system";
            }
            if(this is NotificationCoins)
            {
                return "coins";
            }
            if (this is NotificationHotel)
            {
                return "hotel";
            }
            return "client";
        } 
    }
}
