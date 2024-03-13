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
    public partial class UserControlComboBoxAddress : UserControl
    {
        private Dictionary<string, List<string>> addresses;
        string curentAddress;
        private bool isProvince;

        public UserControlComboBoxAddress()
        {
            InitializeComponent();
            isProvince = true;
            curentAddress = null;
        }

        public void GetData(Dictionary<string, List<string>> addresses)
        {
            this.addresses = addresses;
        }

        public void UpdateProvince()
        {
            comboBox.Items.Clear();
            foreach(string province in addresses.Keys)
            {
                comboBox.Items.Add(province);
            }    
        }

        public void UpdateDistrict()
        {
            comboBox.Items.Clear();
            if (addresses.ContainsKey(curentAddress) == false)
            {
                return;
            }
            foreach (string district in addresses[curentAddress])
            {
                comboBox.Items.Add(curentAddress + ", " + district);
            }
        }

        private void ComboBoxEnter(object sender, EventArgs e)
        {
            if(isProvince == true)
            {
                UpdateProvince();
            }   
            else
            {
                UpdateDistrict();
            }
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Focus();
        }

        private void ComboBoxLeave(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                return;
            }
            curentAddress = comboBox.Text;
            if (isProvince == false)
            {
                comboBox.Text = curentAddress;
            }
            isProvince = !isProvince;
        }
    }
}
