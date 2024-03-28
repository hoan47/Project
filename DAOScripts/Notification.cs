using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Notification
    {
        public string Sender { get; private set; }
        public DateTime Time { get; private set; }
        public string Content { get; private set; }
        public bool IsWatched { get; private set; }
        public EType Type { get; private set; }

        public Notification(string sender, DateTime time, string content, EType type)
        {
            Sender = sender;
            Time = time;
            Content = content;
            IsWatched = false;
            Type = type;
        }

        public void Watched()
        {
            IsWatched = true;
        }

        public enum EType
        {
            Coins,
            System,
            Hotel,
            Client
        }
    }
}
