using Guna.UI2.WinForms;
using Project.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Project.FMains
{
    public partial class FHotelManage : Form
    {
        public FHotelManage()
        {
            InitializeComponent();
           
            for(int i=1;i<5;i++)
            {
                flowLayoutPanel1.Controls.Add(new UserControlRoom());
            }
            
        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void guna2HtmlToolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }
        private void SetButtonToolTip(Guna2Button button, string tooltipText)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button, tooltipText);
        }
        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            SetButtonToolTip(guna2Button2, "Thêm Phòng");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            SetButtonToolTip(guna2Button1, "Thông Tin Khách Sạn");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
