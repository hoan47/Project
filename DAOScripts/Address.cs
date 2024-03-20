using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool IsAddRess(out string massage)
        {
            return CheckInfor.IsAddRess(ProvinceAndDistrict, out massage);
        }

        static public void UpdateProvince(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (string province in AddRessDAO.addresses.Keys)
            {
                comboBox.Items.Add(province);
            }
        }

        static public void UpdateDistrict(ComboBox comboBox, string curentAddress)
        {
            comboBox.Items.Clear();
            if (AddRessDAO.addresses.ContainsKey(curentAddress) == false)
            {
                return;
            }
            foreach (string district in AddRessDAO.addresses[curentAddress])
            {
                comboBox.Items.Add(district);
            }
        }
    }
}
