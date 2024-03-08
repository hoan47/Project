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

        private void OpenFormChild(Form formChild, ToolStripButton toolStripButton)
        {
            if(formChildCurrent != null)
            {
                formChildCurrent.Close();
            }
            formChildCurrent = formChild;
            formChild.TopLevel = false;
            panelMain.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            toolStripButton.BackColor = formChild.BackColor;
        }

        private void ToolStripButtonClick(object sender, EventArgs e)
        {
            foreach (ToolStripButton toolStripButton in toolStripOption.Items)
            {
                toolStripButton.BackColor = colorNormal;
            }

            if (sender == toolStripButtonInfo)
            {
                OpenFormChild(new FUpdateInfo(), toolStripButtonInfo);
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
