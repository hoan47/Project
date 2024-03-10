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
    public partial class UserControlLoading : UserControl
    {
        private Form form;
        int time;

        public UserControlLoading(Form form, int time)
        {
            InitializeComponent();
            this.form = form;
            this.time = time;
        }

        public void OnLoading()
        {
            form.Controls.Add(this);
            Size = form.Size;
            Show();
            BringToFront();
        }

        public void OffLoading()
        {
            new Thread(() =>
            {
                Thread.Sleep(time);
                form.Controls.Remove(this);
                Dispose();
            }).Start();
        }
    }
}
