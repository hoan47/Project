using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Address
    {
        public string Province { set; private get; }
        public string District { set; private get; }

        public string SpecificAddress { set; private get; }

        public Address(string province, string district, string specifiAddress = "")
        {
            Province = province;
            District = district;
            SpecificAddress = specifiAddress;
        }
    }
}
