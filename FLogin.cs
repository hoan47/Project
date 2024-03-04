using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FLogin : Form
    {
        private Form currentFromChild;

        public FLogin()
        {
            InitializeComponent();
        }

        private void OpenFormChild(Form formChild)
        {
            currentFromChild = formChild;
            formChild.TopLevel = false;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
        }

        private void LinkLabelCreateAccountLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormChild(new FCreateAccount());
            buttonComback.Visible = true;
        }

        private void LinkLabelForgetPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormChild(new FForgetPassword());
            buttonComback.Visible = true;
        }

        private void TextBoxAccountKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextBoxPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonLoginClick(sender, e);
                e.Handled = true;
            }
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {

        }

        private void ButtonCombackClick(object sender, EventArgs e)
        {
            buttonComback.Visible = false;
            currentFromChild.Close();
        }
    }
}
