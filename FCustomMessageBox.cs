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
    public partial class FCustomMessageBox : Form
    {
        public FCustomMessageBox(string tile, string content, EIcon eIcon)
        {
            InitializeComponent();
            switch(eIcon)
            {
                case EIcon.success:
                    pictureBoxIcon.Image = Properties.Resources.success;
                    break;
                case EIcon.warning:
                    pictureBoxIcon.Image = Properties.Resources.warning;
                    break;
                case EIcon.error:
                    pictureBoxIcon.Image = Properties.Resources.error;
                    break;
            }
            labelTile.Text = tile;
            labelContent.Text = content;
        }

        public enum EIcon
        {
            success,
            warning, 
            error
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FCustomMessageBoxLoad(object sender, EventArgs e)
        {
            button.Focus();
        }
    }
}
