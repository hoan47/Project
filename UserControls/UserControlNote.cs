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
    public partial class UserControlNote : UserControl
    {
        public string TextContent { get { return label.Text; } set { label.Text = value; } }
        public Color FillColorContentCircle { get { return circlePictureBox.FillColor; } set { circlePictureBox.FillColor = value; } }

        public UserControlNote()
        {
            InitializeComponent();
        }
    }
}
