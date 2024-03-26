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
        private Form formChildCurrent1;
        private Form formChildCurrent2;

        public FMain()
        {
            InitializeComponent();
        }

        public void OpenFormChild(Form formChild, Form fromTag, bool isClearCurrent = true)
        {
            if (formChildCurrent2 != null)
            {
                formChildCurrent2.Close();
                formChildCurrent2 = null;
            }
            if (formChildCurrent1 != null)
            {
                if (formChild.GetType() == formChildCurrent1.GetType())
                {
                    return;
                }
                if (isClearCurrent == true)
                {
                    formChildCurrent1.Close();
                    formChildCurrent1 = formChild;
                }
                else
                {
                    formChildCurrent2 = formChild;
                }
            }
            else
            {
                formChildCurrent1 = formChild;
            }
            FLoading fLoading = new FLoading(formChild, 400);

            ChangeColerToolStripButton(formChild);
            fLoading.OnLoading();
            formChild.Tag = fromTag;
            formChild.Size = panelMain.Size;
            formChild.TopLevel = false;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            fLoading.OffLoading();
        }

        public void ChangeColerToolStripButton(Form formChild)
        {
            if (formChild is FUpdateInfor)
            {
                toolStripButtonInfor.BackColor = formChild.BackColor;
            }
            else if (formChild is FHomePage || formChild is FInforHotelRoom | formChild is FShowHotelRoom)
            {
                toolStripButtonHomePage.BackColor = formChild.BackColor;
            }
            else if (formChild is FHistory)
            {
                toolStripButtonHistory.BackColor = formChild.BackColor;
            }
            else if (formChild is FPreferential)
            {
                toolStripButtonPreferential.BackColor = formChild.BackColor;
            }
            else if (formChild is FService || formChild is FHotelManage || formChild is FUpdateHotel || formChild is FUpdateRoom)
            {
                toolStripButtonService.BackColor = formChild.BackColor;
            }
            else if (formChild is FSetting)
            {
                toolStripButtonSetting.BackColor = formChild.BackColor;
            }
            else if (formChild is FUpdateHotel)
            {
                toolStripButtonService.BackColor = formChild.BackColor;
            }
        }

        private void ToolStripButtonClick(object sender, EventArgs e)
        {
            foreach (ToolStripButton toolStripButton in toolStripOption.Items)
            {
                toolStripButton.BackColor = colorNormal;
            }

            if (sender == toolStripButtonInfor)
            {
                OpenFormChild(new FUpdateInfor(), this);
            }
            else if (Data.User.Client.RankInt == 0)
            {
                FController.Instance.MessageWarning("Yêu cầu", $"Bạn vui lòng cập nhật thông tin trước để sử dụng tính năng {((ToolStripButton)sender)?.Text}.");
            }
            else if (sender == toolStripButtonHomePage)
            {
                OpenFormChild(new FHomePage(), this);
            }
            else if (sender == toolStripButtonHistory)
            {
                OpenFormChild(new FHistory(), this);
            }
            else if (sender == toolStripButtonPreferential)
            {
                OpenFormChild(new FPreferential(), this);
            }
            else if (sender == toolStripButtonService)
            {
                OpenFormChild(new FService(), this);
            }
            else if (sender == toolStripButtonSetting)
            {
                OpenFormChild(new FSetting(), this);
            }
            else if (sender == toolStripButtonLogOut)
            {
                Close();
            }
        }
    }
}