﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationHotel : Notification
    {

        public NotificationHotel(User sender, User receiver, DateTime time, string content, bool isWatched, string type) : base(sender, receiver, time, content, isWatched, type)
        { }

    }
}
