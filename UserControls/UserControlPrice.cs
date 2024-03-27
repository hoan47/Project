using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UserControls
{
    public partial class UserControlPrice : UserControl
    {
        const int priceStart = 100000;
        private int price;
        public int Price 
        { 
            get 
            { 
                return price; 
            } 
            set 
            {
                labelPrice.Text = (price = value).ToString("N0").Replace(",", ".");
                guna2HScrollBar.Value = value / priceStart;
            } 
        }
        public Color ColorUserControl { get { return guna2HScrollBar.ThumbColor; } set { guna2HScrollBar.ThumbColor = panelRoad.BackColor = value; } }

        public UserControlPrice()
        {
            InitializeComponent();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            labelPrice.Text = (price = priceStart * guna2HScrollBar.Value).ToString("N0").Replace(",", ".");
        }
    }
}
