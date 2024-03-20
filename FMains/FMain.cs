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


        public FMain()
        {
            InitializeComponent();
        }

        public void OpenFormChild(Form formChild, bool isClearCurrent = true)
        {
            if(formChildCurrent != null)
            {
                if (formChild.GetType() == formChildCurrent.GetType())
                {
                    return;
                }
                if (isClearCurrent == true)
                {
                    formChildCurrent.Close();
                    formChildCurrent = formChild;
                }
            }
            if (formChild is FUpdateInfor)
            {
                toolStripButtonInfor.BackColor = formChild.BackColor;
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

            formChild.Size = panelMain.Size;
            formChild.TopLevel = false;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Tag = this;
            formChild.Show();
            fLoading.OffLoading();
        }

        private void ToolStripButtonClick(object sender, EventArgs e)
        {
            foreach (ToolStripButton toolStripButton in toolStripOption.Items)
            {
                toolStripButton.BackColor = colorNormal;
            }

            if (sender == toolStripButtonInfor)
            {
                OpenFormChild(new FUpdateInfor());
            }
            else if(FController.Instance.User.Client.RankInt == 0)
            {
                FController.Instance.MessageWarning("Yêu cầu", $"Bạn vui lòng cập nhật thông tin trước để sử dụng tính năng {((ToolStripButton)sender)?.Text}.");
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
                OpenFormChild(new FService());
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
