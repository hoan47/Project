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
    public partial class UserControlServiceEdit : UserControl
    {
        public string GroupBoxText { get { return groupBox.Text; } set { groupBox.Text = value; } }
        public Color ListBoxBackColor { get { return listBox.BackColor; } set { listBox.BackColor = value; } }
        public string TextBoxPlaceholderText { get { return textBox.PlaceholderText; } set { textBox.PlaceholderText = value; } }
        public List<string> Value
        {
            get 
            { 
                return listBox.Items.Cast<string>().ToList(); 
            }
            set
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(value.ToArray());
            }
        }

        public UserControlServiceEdit()
        {
            InitializeComponent();
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (listBox.Items.Contains(textBox.Text) == true)
            {
                button.BackgroundImage = Properties.Resources.delete;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.add;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if(textBox.Text == string.Empty)
            {
                return;
            }    
            if(listBox.Items.Contains(textBox.Text) == true)
            {
                listBox.Items.Remove(textBox.Text);
                button.BackgroundImage = Properties.Resources.add;
            }
            else
            {
                listBox.Items.Add(textBox.Text);
                button.BackgroundImage = Properties.Resources.delete;
            }
        }

        private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex == -1)
            {
                return;
            }    
            textBox.Text = listBox.Items[listBox.SelectedIndex].ToString();
        }
    }
}
