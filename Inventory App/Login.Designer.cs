namespace Inventory_App
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.cbRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.tbPass = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.DisplayIcon = true;
            this.tbUsername.Icon = ((System.Drawing.Image)(resources.GetObject("tbUsername.Icon")));
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(270, 108);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PromptText = "Enter your user name";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(342, 35);
            this.tbUsername.TabIndex = 11;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMark = "Enter your user name";
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Location = new System.Drawing.Point(270, 194);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(110, 17);
            this.cbRememberMe.TabIndex = 13;
            this.cbRememberMe.Text = "Remember me";
            this.cbRememberMe.UseSelectable = true;
            this.cbRememberMe.CheckedChanged += new System.EventHandler(this.CbRememberMe_CheckedChanged);
            // 
            // tbPass
            // 
            // 
            // 
            // 
            this.tbPass.CustomButton.Image = null;
            this.tbPass.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.tbPass.CustomButton.Name = "";
            this.tbPass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPass.CustomButton.TabIndex = 1;
            this.tbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPass.CustomButton.UseSelectable = true;
            this.tbPass.CustomButton.Visible = false;
            this.tbPass.DisplayIcon = true;
            this.tbPass.Icon = ((System.Drawing.Image)(resources.GetObject("tbPass.Icon")));
            this.tbPass.Lines = new string[0];
            this.tbPass.Location = new System.Drawing.Point(270, 149);
            this.tbPass.MaxLength = 32767;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.PromptText = "Enter your password";
            this.tbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPass.SelectedText = "";
            this.tbPass.SelectionLength = 0;
            this.tbPass.SelectionStart = 0;
            this.tbPass.ShortcutsEnabled = true;
            this.tbPass.Size = new System.Drawing.Size(342, 35);
            this.tbPass.TabIndex = 12;
            this.tbPass.UseSelectable = true;
            this.tbPass.WaterMark = "Enter your password";
            this.tbPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(483, 215);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 35);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 316);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbUsername;
        private MetroFramework.Controls.MetroCheckBox cbRememberMe;
        private MetroFramework.Controls.MetroTextBox tbPass;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

