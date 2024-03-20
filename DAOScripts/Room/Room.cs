using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Room
    {
        public int IdRoom { get; private set; }
        public string Name { get; private set; }
        public int NumberRoom { get; private set; }
        public int NumberOfBeds { get; private set; }
        public int NumberOfPeople { get; private set; }
        public string Acreage { get; private set; }
        public int Price { get; private set; }
        public bool IsEmptyRoom { get; private set; }

        public Room()
        {
        }
    }
}
