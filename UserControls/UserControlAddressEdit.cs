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
    public partial class UserControlAddressEdit : UserControl
    {
        private string curentAddress;
        private bool isProvince;
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(64, 64, 64);
        public string ComboBoxText
        {
            get
            {
                return comboBox.Text;
            }
            set
            {
                comboBox.Items.Add(value);
                labelValue.Text = comboBox.Text = value;
            }
        }

        public UserControlAddressEdit()
        {
            InitializeComponent();
            isProvince = true;
            curentAddress = null;
            labelValue.Text = curentAddress;
        }

        private void Edit(object sender, EventArgs e)
        {
            labelValue.Visible = buttonEdit.Visible = !(comboBox.Visible = comboBox.Enabled = true);
            panelRoad.BackColor = colorTextBoxEnter;
        }

        private void UserControlComboBoxEditLeave(object sender, EventArgs e)
        {
            if(buttonEdit.Visible == false)
            {
                labelValue.Visible =  buttonEdit.Visible = !(comboBox.Visible = comboBox.Enabled = false);
                panelRoad.BackColor = colorTextBoxLeave;
            }
        }

        private void ComboBoxLeave(object sender, EventArgs e)
        {
            if (isProvince == false)
            {
                if (comboBox.Text == string.Empty)
                {
                    isProvince = true;
                }
                labelValue.Text = curentAddress = comboBox.Text;
            }
            else
            {
                string curentTextAddreed = curentAddress + ", " + comboBox.Text;
                comboBox.Items.Add(curentTextAddreed);
                labelValue.Text = comboBox.Text = curentTextAddreed;
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

        private void ComboBoxCSelectedValueChanged(object sender, EventArgs e)
        {
            label.Focus();
        }
    }
}
