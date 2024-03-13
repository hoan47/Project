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
    public partial class FHomePage : Form
    {
        FController fController;

        public FHomePage(FController fController)
        {
            InitializeComponent();
            this.fController = fController;
            userControlComboBoxAddress.GetData(fController.addressDAO.Addreses);
            for(int i=0; i<10; i++)
            {
                flowLayoutPanelHomePageSearch.Controls.Add(new UserControls.UserControlHomePaceSearch());
            }
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelMinMax_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxNoRent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
