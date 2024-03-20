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
    public partial class UserControlAddressRoom : UserControl
    {
        private string curentAddress;
        private bool isProvince;
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


        public UserControlAddressRoom()
        {
            InitializeComponent();
            isProvince = true;
            curentAddress = null;
        }

        private void ComboBoxLeave(object sender, EventArgs e)
        {
            if (isProvince == false)
            {
                if (comboBox.Text == string.Empty)
                {
                    isProvince = true;
                }
                curentAddress = comboBox.Text;
            }
            else
            {
                ComboBoxText = curentAddress + (comboBox.Text == string.Empty ? string.Empty : (", " + comboBox.Text));
            }
        }

        private void ComboBoxEnter(object sender, EventArgs e)
        {
            if (isProvince == true)
            {
                Address.UpdateProvince(comboBox);
            }
            else
            {
                Address.UpdateDistrict(comboBox, curentAddress);
            }
            isProvince = !isProvince;
        }

        private void ComboBoxSelectedValueChanged(object sender, EventArgs e)
        {
            pictureBox.Focus();
        }
    }
}
