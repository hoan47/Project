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
    public partial class FController : Form
    {
        public User user;
        public AccountDAO accountDAO;
        public InfoDAO infoDAO;
        private Form currentFromChild;

        public FController()
        {
            user = new User();
            accountDAO = new AccountDAO(user);
            infoDAO = new InfoDAO(user);
            InitializeComponent();
            InitializeFLogin();
        }

        private void OpenFormChild(Form formChild)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = formChild;
            formChild.TopLevel = false;
            Size = (panelMain.Size = formChild.Size) + new Size(15, 40);
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            CenterToScreen();
        }

        public void InitializeFLogin()
        {
            OpenFormChild(new FLogin(this, user, accountDAO, infoDAO));
        }

        public void InitializeFCreateAccount()
        {
            OpenFormChild(new FCreateAccount(this, user, accountDAO, infoDAO));
        }

        public void InitializeFForgetPassword()
        {
            OpenFormChild(new FForgetPassword(this, user, accountDAO, infoDAO));
        }

        public void InitializeFMain()
        {
            OpenFormChild(new FMain(this, user, accountDAO, infoDAO));
        }
    }
}
