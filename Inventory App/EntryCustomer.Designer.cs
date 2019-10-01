namespace Inventory_App
{
    partial class EntryCustomer
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbContactPerson = new MetroFramework.Controls.MetroTextBox();
            this.tbCompanyName = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(249, 397);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(482, 30);
            this.metroTextBox2.TabIndex = 48;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Inventory_App.Customer);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel7.Location = new System.Drawing.Point(26, 397);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 20);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "Address";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(249, 349);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(482, 30);
            this.metroTextBox1.TabIndex = 46;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.Location = new System.Drawing.Point(26, 349);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 20);
            this.metroLabel6.TabIndex = 45;
            this.metroLabel6.Text = "Phone Number";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // tbAddress
            // 
            // 
            // 
            // 
            this.tbAddress.CustomButton.Image = null;
            this.tbAddress.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.tbAddress.CustomButton.Name = "";
            this.tbAddress.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAddress.CustomButton.TabIndex = 1;
            this.tbAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAddress.CustomButton.UseSelectable = true;
            this.tbAddress.CustomButton.Visible = false;
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.tbAddress.Lines = new string[0];
            this.tbAddress.Location = new System.Drawing.Point(249, 297);
            this.tbAddress.MaxLength = 32767;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAddress.SelectedText = "";
            this.tbAddress.SelectionLength = 0;
            this.tbAddress.SelectionStart = 0;
            this.tbAddress.ShortcutsEnabled = true;
            this.tbAddress.Size = new System.Drawing.Size(482, 30);
            this.tbAddress.TabIndex = 44;
            this.tbAddress.UseSelectable = true;
            this.tbAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbEmailAddress
            // 
            // 
            // 
            // 
            this.tbEmailAddress.CustomButton.Image = null;
            this.tbEmailAddress.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.tbEmailAddress.CustomButton.Name = "";
            this.tbEmailAddress.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbEmailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmailAddress.CustomButton.TabIndex = 1;
            this.tbEmailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmailAddress.CustomButton.UseSelectable = true;
            this.tbEmailAddress.CustomButton.Visible = false;
            this.tbEmailAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ContactName", true));
            this.tbEmailAddress.Lines = new string[0];
            this.tbEmailAddress.Location = new System.Drawing.Point(249, 245);
            this.tbEmailAddress.MaxLength = 32767;
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.PasswordChar = '\0';
            this.tbEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmailAddress.SelectedText = "";
            this.tbEmailAddress.SelectionLength = 0;
            this.tbEmailAddress.SelectionStart = 0;
            this.tbEmailAddress.ShortcutsEnabled = true;
            this.tbEmailAddress.Size = new System.Drawing.Size(482, 30);
            this.tbEmailAddress.TabIndex = 43;
            this.tbEmailAddress.UseSelectable = true;
            this.tbEmailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEmailAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbContactPerson
            // 
            // 
            // 
            // 
            this.tbContactPerson.CustomButton.Image = null;
            this.tbContactPerson.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.tbContactPerson.CustomButton.Name = "";
            this.tbContactPerson.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbContactPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbContactPerson.CustomButton.TabIndex = 1;
            this.tbContactPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbContactPerson.CustomButton.UseSelectable = true;
            this.tbContactPerson.CustomButton.Visible = false;
            this.tbContactPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyName", true));
            this.tbContactPerson.Lines = new string[0];
            this.tbContactPerson.Location = new System.Drawing.Point(249, 193);
            this.tbContactPerson.MaxLength = 32767;
            this.tbContactPerson.Name = "tbContactPerson";
            this.tbContactPerson.PasswordChar = '\0';
            this.tbContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContactPerson.SelectedText = "";
            this.tbContactPerson.SelectionLength = 0;
            this.tbContactPerson.SelectionStart = 0;
            this.tbContactPerson.ShortcutsEnabled = true;
            this.tbContactPerson.Size = new System.Drawing.Size(482, 30);
            this.tbContactPerson.TabIndex = 42;
            this.tbContactPerson.UseSelectable = true;
            this.tbContactPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbContactPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbCompanyName
            // 
            // 
            // 
            // 
            this.tbCompanyName.CustomButton.Image = null;
            this.tbCompanyName.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.tbCompanyName.CustomButton.Name = "";
            this.tbCompanyName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbCompanyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCompanyName.CustomButton.TabIndex = 1;
            this.tbCompanyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCompanyName.CustomButton.UseSelectable = true;
            this.tbCompanyName.CustomButton.Visible = false;
            this.tbCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyCode", true));
            this.tbCompanyName.Lines = new string[0];
            this.tbCompanyName.Location = new System.Drawing.Point(249, 142);
            this.tbCompanyName.MaxLength = 32767;
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.PasswordChar = '\0';
            this.tbCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCompanyName.SelectedText = "";
            this.tbCompanyName.SelectionLength = 0;
            this.tbCompanyName.SelectionStart = 0;
            this.tbCompanyName.ShortcutsEnabled = true;
            this.tbCompanyName.Size = new System.Drawing.Size(482, 30);
            this.tbCompanyName.TabIndex = 41;
            this.tbCompanyName.UseSelectable = true;
            this.tbCompanyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCompanyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(576, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(415, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 30);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.CustomButton.Image = null;
            this.tbID.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.tbID.CustomButton.Name = "";
            this.tbID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbID.CustomButton.TabIndex = 1;
            this.tbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbID.CustomButton.UseSelectable = true;
            this.tbID.CustomButton.Visible = false;
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ID", true));
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(249, 82);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.SelectionLength = 0;
            this.tbID.SelectionStart = 0;
            this.tbID.ShortcutsEnabled = true;
            this.tbID.Size = new System.Drawing.Size(482, 30);
            this.tbID.TabIndex = 38;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(26, 307);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 20);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Email";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.Location = new System.Drawing.Point(26, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 20);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Contact Person";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(26, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 20);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Company Name";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(26, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 20);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Company Code";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(26, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 20);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Customer ID";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 30);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // EntryCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 559);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.tbContactPerson);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EntryCustomer";
            this.Text = "EntryCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbAddress;
        private MetroFramework.Controls.MetroTextBox tbEmailAddress;
        private MetroFramework.Controls.MetroTextBox tbContactPerson;
        private MetroFramework.Controls.MetroTextBox tbCompanyName;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}