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
    public partial class FConfirm : Form
    {
        public string RichTextBoxText { get { return richTextBox.Text; } }

        public FConfirm()
        {
            InitializeComponent();
        }

        private void ButtonYesClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void ButtonNoClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
