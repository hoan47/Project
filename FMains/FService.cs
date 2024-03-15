using Project.FMains;
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
    public partial class FService : Form
    {
        FController fController;
        private Form formChildCurrent;
        public FService(FController fController)
        {
            InitializeComponent();
            formChildCurrent = this;
            this.fController = fController;
            for(int i=1; i<5; i++)
            {
                flowLayoutPanelService.Controls.Add(new UserControlHotel());
            }
        }

        private void OpenFormChild(Form formChild)
        {
            FLoading fLoading = new FLoading(formChild, 300);
            fLoading.OnLoading();
            formChild.TopLevel = false;
            Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
            fLoading.OffLoading();
        }
        private void flowLayoutPanelService_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FUpdateService());
           
        }
    }
}
