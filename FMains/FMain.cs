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
    public partial class FMain : Form, IUser
    {
        private Color colorNormal = Color.White;
        private Form formChildCurrent;

        public FController fController { get; set; }
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }

        public FMain(FController fController, User user, AccountDAO accountDAO, InfoDAO infoDAO)
        {
            InitializeComponent();
            this.fController = fController;
            User = user;
            AccountDAO = accountDAO;
            InfoDAO = infoDAO;
        }

        private void OpenFormChild(Form formChild, ToolStripButton toolStripButton)
        {
            if(formChildCurrent != null)
            {
                if (formChild.GetType() == formChildCurrent.GetType())
                {
                    return;
                }
                formChildCurrent.Close();
            }
            UserControlLoading userControlLoading = new UserControlLoading(formChild, 300);

            userControlLoading.OnLoading();
            formChildCurrent = formChild;
            formChild.TopLevel = false;
            formChild.Size = panelMain.Size;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            toolStripButton.BackColor = formChild.BackColor;
            userControlLoading.OffLoading();
        }

        private void ToolStripButtonClick(object sender, EventArgs e)
        {
            foreach (ToolStripButton toolStripButton in toolStripOption.Items)
            {
                toolStripButton.BackColor = colorNormal;
            }

            if (sender == toolStripButtonInfo)
            {
                OpenFormChild(new FUpdateInfo(fController, User, AccountDAO, InfoDAO), toolStripButtonInfo);
            }
            else if(User.Client == null)
            {
                fController.MessageWarning("Yêu cầu", $"Bạn vui lòng cập nhật thông tin trước để sử dụng tính năng {((ToolStripButton)sender)?.Text}.", this);
            }    
            else if (sender == toolStripButtonHomePage)
            {
                OpenFormChild(new FHomePage(), toolStripButtonHomePage);
            }
            else if (sender == toolStripButtonHistory)
            {
                OpenFormChild(new FHistory(), toolStripButtonHistory);

            }
            else if (sender == toolStripButtonPreferential)
            {
                OpenFormChild(new FPreferential(), toolStripButtonPreferential);

            }
            else if(sender == toolStripButtonService)
            {
                OpenFormChild(new FService(), toolStripButtonService);

            }
            else if(sender == toolStripButtonSetting)
            {
                OpenFormChild(new FSetting(), toolStripButtonSetting);

            }
            else if(sender == toolStripButtonLogOut)
            {
                Close();
            }
        }
    }
}
