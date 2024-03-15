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
    public partial class FMain : Form
    {
        private Color colorNormal = Color.White;
        private Form formChildCurrent;
        public FController fController { get; set; }

        public FMain(FController fController)
        {
            InitializeComponent();
            this.fController = fController;
        }

        public void OpenFormChild(Form formChild)
        {
            if(formChildCurrent != null)
            {
                if (formChild.GetType() == formChildCurrent.GetType())
                {
                    return;
                }
                formChildCurrent.Close();
            }
            if (formChild is FUpdateInfo)
            {
                toolStripButtonInfo.BackColor = formChild.BackColor;
            }
            else if(formChild is FHomePage)
            {
                toolStripButtonHomePage.BackColor = formChild.BackColor;
            }
            else if(formChild is FHistory)
            {
                toolStripButtonHistory.BackColor = formChild.BackColor;
            }
            else if(formChild is FPreferential)
            {
                toolStripButtonPreferential.BackColor = formChild.BackColor;
            }
            else if(formChild is FService)
            {
                toolStripButtonService.BackColor = formChild.BackColor;
            }
            else if (formChild is FSetting)
            {
                toolStripButtonSetting.BackColor = formChild.BackColor;
            }
            else if(formChild is FUpdateService)
            {
                toolStripButtonService.BackColor = formChild.BackColor;
            }
            FLoading fLoading = new FLoading(formChild, 300);

            fLoading.OnLoading();
            formChildCurrent = formChild;
            formChild.Size = panelMain.Size;
            formChild.TopLevel = false;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            fLoading.OffLoading();
        }

        private void ToolStripButtonClick(object sender, EventArgs e)
        {
            foreach (ToolStripButton toolStripButton in toolStripOption.Items)
            {
                toolStripButton.BackColor = colorNormal;
            }

            if (sender == toolStripButtonInfo)
            {
                OpenFormChild(new FUpdateInfo(fController));
            }
            else if(fController.User.Client.RankInt == 0)
            {
                fController.MessageWarning("Yêu cầu", $"Bạn vui lòng cập nhật thông tin trước để sử dụng tính năng {((ToolStripButton)sender)?.Text}.", this);
            }    
            else if (sender == toolStripButtonHomePage)
            {
                OpenFormChild(new FHomePage());
            }
            else if (sender == toolStripButtonHistory)
            {
                OpenFormChild(new FHistory());
            }
            else if (sender == toolStripButtonPreferential)
            {
                OpenFormChild(new FPreferential());
            }
            else if(sender == toolStripButtonService)
            {
                OpenFormChild(new FService(fController, this));
            }
            else if(sender == toolStripButtonSetting)
            {
                OpenFormChild(new FSetting());
            }
            else if(sender == toolStripButtonLogOut)
            {
                Close();
            }
        }
    }
}
