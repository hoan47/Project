using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    static class ProcessAddress
    {
        public static string AppendAddress(string provinceAndDistrict, string specificLocation)
        {
            return provinceAndDistrict + (string.IsNullOrWhiteSpace(specificLocation) == true ? null : ", " + specificLocation);
        }

        public static bool IsAddRess(string addresses)
        {
            if (addresses?.Count(c => c == ',') != 1)
            {
                ShowMessage.ShowWarning("Vui lòng chọn đầy đủ địa chỉ.");
                return false;
            }
            return true;
        }

        public static string SelectProvinceAndDistrict(string addresses)
        {
            if (addresses == null)
            {
                return null;
            }
            int index = 0;
            int count = 0;

            foreach (char c in addresses)
            {
                count++;
                if(c == ',')
                {
                    index++;
                    if(index == 2)
                    {
                        break;
                    }    
                }    
            }
            return addresses.Substring(0, count - 1);
        }

        public static string SelectSpecificLocation(string addresses)
        {
            if (addresses == null)
            {
                return null;
            }
            int index = 0;
            int count = 0;

            foreach (char c in addresses)
            {
                count++;
                if (c == ',')
                {
                    index++;
                    if (index == 2)
                    {
                        break;
                    }
                }
            }
            return addresses.Substring(count).Trim();
        }
    }
}
