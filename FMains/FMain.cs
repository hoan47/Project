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

        private void ToolStripButtonClick(object sender, EventArgs e)
        {
            if (sender == toolStripButtonInfor)
            {
                NormalColorToolStripButton();
                OpenFormChild(new FUpdateInfor(), this);
                return;
            }
            else if (Data.User.Client.RankInt == 0)
            {
                FController.Instance.MessageWarning("Yêu cầu", $"Bạn vui lòng cập nhật thông tin trước để sử dụng tính năng {((ToolStripButton)sender).Text}.");
                return;
            }
            NormalColorToolStripButton();
            if (sender == toolStripButtonHomePage)
            {
                OpenFormChild(new FHomePage(), this);
            }
            else if (sender == toolStripButtonHistory)
            {
                OpenFormChild(new FHistory(), this);
            }
            else if (sender == toolStripButtonNotification)
            {
                OpenFormChild(new FNotification(), this);
            }
            else if (sender == toolStripButtonService)
            {
                OpenFormChild(new FService(), this);
            }
            else if (sender == toolStripButtonLogOut)
            {
                Close();
            }
        }

        private void NormalColorToolStripButton()
        {
            foreach (ToolStripButton toolStripButton in toolStripOption.Items)
            {
                toolStripButton.BackColor = colorNormal;
            }
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
            OpenFormChild(panelMain, formChild, fromTag);
            fLoading.OffLoading();
        }

        public void OpenFormChild(Panel panel, Form formChild, Form fromTag)
        {
            formChild.Tag = fromTag;
            formChild.Size = panelMain.Size;
            formChild.TopLevel = false;
            panel.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
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
            else if (formChild is FNotification)
            {
                toolStripButtonNotification.BackColor = formChild.BackColor;
            }
            else if (formChild is FService || formChild is FHotelManage || formChild is FUpdateHotel || formChild is FUpdateRoom)
            {
                toolStripButtonService.BackColor = formChild.BackColor;
            }
            else if (formChild is FUpdateHotel)
            {
                toolStripButtonService.BackColor = formChild.BackColor;
            }
        }

        public void UpdateConins()
        {
            labelCoins.Text = Data.User.Client.Coins.ToString("N0").Replace(",", ".");
        }

        private void FMainLoad(object sender, EventArgs e)
        {
            UpdateConins();
        }
    }
}