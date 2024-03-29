using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class UpdatePrice
    {
        public DateTime Time { get; private set; }
        public int Value { get; private set; }
        public int NumberRoom { get; private set; }

        public UpdatePrice(DateTime time, int value, int numberRoom)
        {
            Time = time;
            Value = value;
            NumberRoom = numberRoom;
        }    
    }
}
