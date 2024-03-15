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
    public partial class UserControlHotel : UserControl
    {
        private int index;
        private FController fController;
        private FService fService;

        public UserControlHotel(FController fController, FService fService, int index)
        {
            this.index = index;
            this.fController = fController;
            this.fService = fService;
            InitializeComponent();
            userControlerLableName.LableText = fController.User.Hotels[index].Name;
            userControlerLableAddress.LableText = fController.User.Hotels[index].Address.AddressValue;
            userControlerLablePhone.LableText = "   -    ";
            userControlerLablePrice.LableText = fController.User.Hotels[index].Phone;
            userControlerLableName.GetData(this);
            userControlerLableAddress.GetData(this);
            userControlerLablePhone.GetData(this);
            userControlerLablePrice.GetData(this);
        }

        public void UserControlHottelDoubleClick(object sender, EventArgs e)
        {
            fService.OpenHotel(index);
        }
    }
}