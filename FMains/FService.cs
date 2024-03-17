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
        private FMain fMain;

        public FService(FMain fMain)
        {
            InitializeComponent();
            this.fMain = fMain;
            LoadData();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            OpenHotel();
        }

        public void OpenHotel(Hotel hotel = null)
        {
            fMain.OpenFormChild(new FUpdateService(hotel));
        }

        private  void LoadData()
        {
            if (FController.Instance.User.Hotels == null)
            {
                return; 
            }
            foreach(Hotel hotel in FController.Instance.User.Hotels)
            {
                flowLayoutPanelHottel.Controls.Add(new UserControlHotel(this, hotel));
            }    
        }
    }
}
