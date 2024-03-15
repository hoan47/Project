using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserControlAddressHotel : UserControl
    {
        public string ComboBoxText { get { return userControlComboBoxAddress.ComboBoxText; } set { userControlComboBoxAddress.ComboBoxText = value; } }
        public string TextBoxText { get { return textBox.Text; } set { textBox.Text = value; } }
        public Address AddressText
        {
            get 
            { 
                return new Address(userControlComboBoxAddress.ComboBoxText, TextBoxText); 
            }
            set
            {
                userControlComboBoxAddress.ComboBoxText = value.ProvinceAndDistrict;
                textBox.Text = value.SpecificLocation;
            }
        }

        public UserControlAddressHotel()
        {
            InitializeComponent();
        }
    }
}
