
namespace Project
{
    partial class UserControlRadioButtonEdit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRadioButtonEdit));
            this.radioButtonBoy = new System.Windows.Forms.RadioButton();
            this.radioButtonGirl = new System.Windows.Forms.RadioButton();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelRoad = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonBoy
            // 
            this.radioButtonBoy.Enabled = false;
            this.radioButtonBoy.Location = new System.Drawing.Point(129, 16);
            this.radioButtonBoy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBoy.Name = "radioButtonBoy";
            this.radioButtonBoy.Size = new System.Drawing.Size(77, 20);
            this.radioButtonBoy.TabIndex = 19;
            this.radioButtonBoy.Text = "Nam";
            this.radioButtonBoy.UseVisualStyleBackColor = true;
            // 
            // radioButtonGirl
            // 
            this.radioButtonGirl.Enabled = false;
            this.radioButtonGirl.Location = new System.Drawing.Point(252, 16);
            this.radioButtonGirl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonGirl.Name = "radioButtonGirl";
            this.radioButtonGirl.Size = new System.Drawing.Size(63, 20);
            this.radioButtonGirl.TabIndex = 20;
            this.radioButtonGirl.Text = "Nữ";
            this.radioButtonGirl.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(519, 6);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(33, 31);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.Edit);
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRoad.Location = new System.Drawing.Point(16, 38);
            this.panelRoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(533, 2);
            this.panelRoad.TabIndex = 22;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 20);
            this.label.TabIndex = 23;
            this.label.Text = "Giới Tính";
            // 
            // UserControlRadioButtonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.radioButtonBoy);
            this.Controls.Add(this.radioButtonGirl);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panelRoad);
            this.Controls.Add(this.label);
            this.Name = "UserControlRadioButtonEdit";
            this.Size = new System.Drawing.Size(568, 46);
            this.Leave += new System.EventHandler(this.UserControlRadioButtonEditLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBoy;
        private System.Windows.Forms.RadioButton radioButtonGirl;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelRoad;
        private System.Windows.Forms.Label label;
    }
}
