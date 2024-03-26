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
    public partial class UserControlLable : UserControl
    {
        public string LableText { get { return label.Text; } set { label.Text = value; } }
        public Image ImageIcon { get { return pictureBox.Image; } set { pictureBox.Image = value; } }
        public Size SizeUserControl { get { return Size; } set { label.Size = new Size(value.Width - label.Location.X, label.Height); } }

        public UserControlLable()
        {
            InitializeComponent();
        }
    }
}
