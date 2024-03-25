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
        public static FController Instance { get; private set; }
        private Form currentFromChild;

        public FController()
        {
            Instance = this;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            OpenLogin();

        }

        private void OpenFormChild(Form formChild)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = formChild;
            Size = formChild.Size + new Size(15, 40);
            ProcessOpenFormChild(formChild);
        }

        private void OpenFormMessage(Form formChild, Form formParent = null)
        {
            ProcessOpenFormChild(formChild, formParent);
            formChild.Size = formParent != null ? formParent.Size : Size;
        }

        public void ProcessOpenFormChild(Form formChild, Form formParent = null)
        {
            formChild.Location = new Point(0, 0);
            formChild.TopLevel = false;
            if (formParent == null)
            {
                Controls.Add(formChild);
            }
            else
            {
                formParent.Controls.Add(formChild);
            }    
            formChild.BringToFront();
            formChild.Show();
            CenterToScreen();
        }
      
        public void OpenLogin()
        {
            OpenFormChild(new FLogin());
        }

        public void OpenCreateAccount()
        {
            OpenFormChild(new FCreateAccount());
        }

        public void OpenForgetPassword()
        {
            OpenFormChild(new FForgetPassword());
        }

        public void OpenMain()
        {
            OpenFormChild(new FMain());
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
