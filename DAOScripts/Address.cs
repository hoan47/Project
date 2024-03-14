using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public class Address
    {
        public string ProvinceAndDistrict { get; private set; }
        public string SpecificLocation { get; private set; }
        public string AddressValue { get; private set; }

        public Address(string provinceAndDistrict, string specificLocation)
        {
            ProvinceAndDistrict = provinceAndDistrict;
            SpecificLocation = specificLocation;
            AddressValue = provinceAndDistrict + (string.IsNullOrWhiteSpace(specificLocation) == true ? null : ", " + specificLocation);
        }

        public Address(string AddressValue)
        {
            int count = 0;
            int index = 0; 

            foreach (char c in AddressValue)
            {
                index++;
                if (c == ',')
                {
                    count++;
                    if (count == 2)
                    {
                        break;
                    }    
                }
            }    
            ProvinceAndDistrict = AddressValue.Substring(0, index < AddressValue.Length ? index - 1: index);
            SpecificLocation = AddressValue.Substring(index).Trim();
            this.AddressValue = AddressValue;
        }

        public bool IsAddRess()
        {
            if (ProvinceAndDistrict?.Count(c => c == ',') != 1)
            {
                ShowMessage.ShowWarning("Vui lòng chọn đầy đủ địa chỉ.");
                return false;
            }
            return true;
        }
    }
}
