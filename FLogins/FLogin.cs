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
            VisibleControlPanelMain();
            currentFromChild = formChild;
            formChild.TopLevel = false;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
        }

        private void VisibleControlPanelMain()
        {
            foreach (Control control in panelMain.Controls)
            {
                control.Visible = !control.Visible;
            }
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


        private void ButtonLoginClick(object sender, EventArgs e)
        {
            FController.Instance.user = new User(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword1.TextBoxText, userControlTextBoxPassword1.TextBoxText);
            if (FController.Instance.accountDAO.Login() == true)
            {
                FController.Instance.InitializeMain();
                Close();
            }
        }

        private void ButtonCombackClick(object sender, EventArgs e)
        {
            VisibleControlPanelMain();
            buttonComback.Visible = false;
            currentFromChild.Close();
        }
    }
}
