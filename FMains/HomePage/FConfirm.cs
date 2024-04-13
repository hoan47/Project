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
        private Room room;
        private DateTime firstDay;
        private DateTime lastDay;
        public FConfirm(Room room, DateTime firstDay, DateTime lastDay)
        {
            InitializeComponent();
            this.room = room;
            this.firstDay = firstDay;
            this.lastDay = lastDay;
        }

        private void ButtonYesClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            room.AddCheckInOuts(firstDay, lastDay);
            Close();
        }

        private void ButtonNoClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
