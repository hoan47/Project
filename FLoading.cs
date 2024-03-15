using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FLoading : Form
    {
        private Form form;
        int time;

        public FLoading(Form form, int time)
        {
            InitializeComponent();
            BackColor = form.BackColor;
            this.form = form;
            this.time = time;
        }

        public void OnLoading()
        {
            TopLevel = false;
            Size = form.Size;
            if (form.Controls.Contains(this) == false)
            {
                form.Controls.Add(this);
            }
            Show();
            BringToFront();
        }

        public void OffLoading()
        {
            timer.Interval = time;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            form.Controls.Remove(this);
            Dispose();
        }
    }
}
