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
    public partial class FUpdateInfo : Form
    {
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(255, 128, 255);

        public FUpdateInfo()
        {
            InitializeComponent();
        }

        private void TextBoxNameEnter(object sender, EventArgs e)
        {
            panelRoadName.BackColor = colorTextBoxEnter;
        }

        private void LeaveEdit(Panel panel, Control control, Button button)
        {
            panel.BackColor = colorTextBoxLeave;
            control.Enabled = !(button.Visible = true);
        }

        private void ClickEdit(Control control, Button button)
        {
            control.Enabled = !(button.Visible = false);
            control.Focus();
        }

        private void TextBoxNameLeave(object sender, EventArgs e)
        {
            LeaveEdit(panelRoadName, textBoxName, buttonEditName);
        }

        private void DateTimePickerDateOfBirthEnter(object sender, EventArgs e)
        {
            panelRoadDateOfBirth.BackColor = colorTextBoxEnter;
        }

        private void DateTimePickerDateOfBirthLeave(object sender, EventArgs e)
        {
            LeaveEdit(panelRoadDateOfBirth, dateTimePickerDateOfBirth, buttonEditDateOfBirth);
        }

        private void RadioButtonEnter(object sender, EventArgs e)
        {
            panelRoadGender.BackColor = colorTextBoxEnter;
        }

        private void TextBoxAddressEnter(object sender, EventArgs e)
        {
            panelRoadAddress.BackColor = colorTextBoxEnter;
        }

        private void TextBoxAddressLeave(object sender, EventArgs e)
        {
            panelRoadAddress.BackColor = colorTextBoxLeave;
        }

        private void TextBoxEmailEnter(object sender, EventArgs e)
        {
            panelRoadEmail.BackColor = colorTextBoxEnter;
        }

        private void TextBoxEmailLeave(object sender, EventArgs e)
        {
            panelRoadEmail.BackColor = colorTextBoxLeave;
        }

        private void TextBoxPhoneLeave(object sender, EventArgs e)
        {
            panelRoadPhone.BackColor = colorTextBoxLeave;
        }

        private void TextBoxPhoneEnter(object sender, EventArgs e)
        {
            panelRoadPhone.BackColor = colorTextBoxEnter;
        }


        private void TextBoxIdCardLeave(object sender, EventArgs e)
        {
            panelRoadIdCard.BackColor = colorTextBoxLeave;
        }

        private void ButtonEditNameClick(object sender, EventArgs e)
        {
            ClickEdit(textBoxName, buttonEditName);
        }

        private void ButtonEditDateOfBirthClick(object sender, EventArgs e)
        {
            ClickEdit(dateTimePickerDateOfBirth, buttonEditDateOfBirth);
        }

        private void ButtonEditGenderClick(object sender, EventArgs e)
        {
            ClickEdit(panelRadioGender, buttonEditGender);
        }

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {

        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGirl_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
