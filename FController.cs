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
        public ClientDAO clientDAO;
        public AddRessDAO addressDAO;
        public UserControlLoading userControlLoading;
        private Form currentFromChild;

        public FController()
        {
            user = new User();
            accountDAO = new AccountDAO(user);
            infoDAO = new InfoDAO(user);
            clientDAO = new ClientDAO(user);
            addressDAO = new AddRessDAO();
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
            Size = (panelMain.Size = formChild.Size)+ new Size(15, 40);
            ProcessOpenFormChild(formChild);
        }

        private void OpenFormMessage(Form formChild, Form formParent = null)
        {
            ProcessOpenFormChild(formChild, formParent);
            formChild.Size = formParent != null ? formParent.Size : Size;
        }

        private void ProcessOpenFormChild(Form formChild, Form formParent = null)
        {
            formChild.TopLevel = false;
            if (formParent == null)
            {
                panelMain.Controls.Add(formChild);
            }
            else
            {
                formParent.Controls.Add(formChild);
            }    
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
       
        public void MessageSuccess(string tile, string content, Form formParent = null)
        {
            OpenFormMessage(new FCustomMessageBox(tile, content, FCustomMessageBox.EIcon.success), formParent);
        }

        public void MessageWarning(string tile, string content, Form formParent = null)
        {
            OpenFormMessage(new FCustomMessageBox(tile, content, FCustomMessageBox.EIcon.warning), formParent);

        }
        public void MessageError(string tile, string content)
        {
            OpenFormMessage(new FCustomMessageBox(tile, content, FCustomMessageBox.EIcon.error));
        }
    }
}
