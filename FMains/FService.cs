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
        public FController fController;
        private FMain fMain;

        public FService(FController fController, FMain fMain)
        {
            InitializeComponent();
            this.fController = fController;
            this.fMain = fMain;
            LoadData();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            OpenHotel();
        }

        public void OpenHotel(int index = -1)
        {
            fMain.OpenFormChild(new FUpdateService(fController, index));
        }

        private  void LoadData()
        {
            if (fMain.fController.User.Hotels == null)
            {
                return; 
            }

            for (int i = 0; i < fController.User.Hotels.Count; i++)
            {
                flowLayoutPanelHottel.Controls.Add(new UserControlHotel(fController, this, i));
            }    
        }
    }
}
