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
        public InfoDAO infoDAO;
        private Form currentFromChild;

        public FController()
        {
            FController.Instance = this;
            user = new User();
            accountDAO = new AccountDAO();
            infoDAO = new InfoDAO();
            InitializeComponent();
            InitializeLogin();
        }

        private void OpenFormChild(Form formChild)
        {
            if(currentFromChild != null)
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

        public void InitializeLogin()
        {
            OpenFormChild(new FLogin());
        }

        public void InitializeMain()
        {
            OpenFormChild(new FMain());
        }

    }
}
