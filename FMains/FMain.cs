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
        public static FMain Instance { get; private set; }
        private Color colorNormal = Color.White;
        private Form formChildCurrent;

        public FMain()
        {
            InitializeComponent();
            Instance = this;
            timer.Interval = 1000;
            timer.Start();
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

        public void OpenFormChild(Form formChild, Form fromTag)
        {
            if (formChildCurrent != null)
            {
                formChildCurrent.Close();
            }
            formChildCurrent = formChild;
            ChangeColerToolStripButton(formChild);
            OpenFormChild(panelMain, formChild, fromTag);
        }

        public void OpenFormChild(Control panel, Form formChild, Form fromTag)
        {
            FLoading fLoading = new FLoading(formChild, 400);

            fLoading.OnLoading();
            if (panel == null)
            {
                panel = panelMain;
                ChangeColerToolStripButton(formChild);
            }
            formChild.Tag = fromTag;
            formChild.TopLevel = false;
            panel.Controls.Add(formChild);
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

        private void TimerTick(object sender, EventArgs e)
        {
            QueryData.Access();
            labelCoins.Text = Data.User.Client.Coins.ToString("N0").Replace(",", ".");
            int count = Data.Notifications.Count(n => n.IsWatched == false);
            toolStripButtonNotification.Text = count > 0 ? $"Thông báo({count})" : "Thông báo";
        }
    }
}