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
        string curentAddress;
        private bool isProvince;
        public Size SizeUserControl { get { return Size; } set { comboBox.Size = (comboBox.Size = value) - new Size(Size.Width / 4, 2); } }
        public Color ComboBoxColor { get { return comboBox.BackColor; } set { comboBox.BackColor = value; } }
        public Font ComboBoxFont { get { return comboBox.Font; } set { comboBox.Font = value; } }
        public string ComboBoxText 
        { 
            get 
            { 
                return comboBox.Text; 
            } 
            set 
            {
                comboBox.Items.Add(value);
                comboBox.Text = value;
            } 
        }

        public UserControlComboBoxAddress()
        {
            InitializeComponent();
            isProvince = true;
            curentAddress = null;
        }

        public void UpdateProvince()
        {
            comboBox.Items.Clear();
            foreach(string province in AddRessDAO.addresses.Keys)
            {
                comboBox.Items.Add(province);
            }    
        }

        public void UpdateDistrict()
        {
            comboBox.Items.Clear();
            if (AddRessDAO.addresses.ContainsKey(curentAddress) == false)
            {
                return;
            }
            foreach (string district in AddRessDAO.addresses[curentAddress])
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

        public void GetComboBoxText(string address)
        {
            comboBox.Items.Add(address);
            comboBox.Text = address;
        }
    }
}
