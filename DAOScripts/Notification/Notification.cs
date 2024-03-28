using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Notification
    {
        public User Sender { get; private set; }
        public User Receiver { get; private set; }
        public DateTime Time { get; private set; }
        public string Content { get; private set; }
        public bool IsWatched { get; private set; }

        public Notification(User sender, User receiver, DateTime time, string content, bool isWatched)
        {
            Sender = sender;
            Receiver = receiver;
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
