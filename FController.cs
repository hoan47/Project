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
        static public FController Instance { get; private set; }
        public User user;
        public AccountDAO accountDAO;
        private Form currentFromChild;

        public FController()
        {
            FController.Instance = this;
            user = new User();
            accountDAO = new AccountDAO();
            InitializeComponent();
            InitializeMain();
        }

        private void OpenFormChild(Form formChild)
        {
            currentFromChild = formChild;
            formChild.TopLevel = false;
            Size = (panelMain.Size = formChild.Size) + new Size(15, 40);
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            CenterToScreen();
        }

        private void InitializeLogin()
        {
            OpenFormChild(new FLogin());
        }

        public void InitializeMain()
        {
            OpenFormChild(new FMain());
        }
    }
}
