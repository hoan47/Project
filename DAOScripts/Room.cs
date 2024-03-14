using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Room
    {
        private Hotel hotel;
        public bool IsEmptyRoom { get; private set; }

        public Room(Hotel hotel)
        {
            this.hotel = hotel;
        }
    }
}
