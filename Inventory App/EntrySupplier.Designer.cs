namespace Inventory_App
{
    partial class EntrySupplier
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.tbPhone = new MetroFramework.Controls.MetroTextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEmail = new MetroFramework.Controls.MetroTextBox();
            this.tbType = new MetroFramework.Controls.MetroTextBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tbKTP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbDistance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbContactPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(412, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 30);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // tbPhone
            // 
            // 
            // 
            // 
            this.tbPhone.CustomButton.Image = null;
            this.tbPhone.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbPhone.CustomButton.Name = "";
            this.tbPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPhone.CustomButton.TabIndex = 1;
            this.tbPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPhone.CustomButton.UseSelectable = true;
            this.tbPhone.CustomButton.Visible = false;
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Phone", true));
            this.tbPhone.Lines = new string[0];
            this.tbPhone.Location = new System.Drawing.Point(198, 401);
            this.tbPhone.MaxLength = 32767;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhone.SelectedText = "";
            this.tbPhone.SelectionLength = 0;
            this.tbPhone.SelectionStart = 0;
            this.tbPhone.ShortcutsEnabled = true;
            this.tbPhone.Size = new System.Drawing.Size(411, 30);
            this.tbPhone.TabIndex = 22;
            this.tbPhone.UseSelectable = true;
            this.tbPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Inventory_App.Supplier);
            // 
            // tbEmail
            // 
            // 
            // 
            // 
            this.tbEmail.CustomButton.Image = null;
            this.tbEmail.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbEmail.CustomButton.Name = "";
            this.tbEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmail.CustomButton.TabIndex = 1;
            this.tbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmail.CustomButton.UseSelectable = true;
            this.tbEmail.CustomButton.Visible = false;
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Email", true));
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(198, 348);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.ShortcutsEnabled = true;
            this.tbEmail.Size = new System.Drawing.Size(411, 30);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.UseSelectable = true;
            this.tbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbType
            // 
            // 
            // 
            // 
            this.tbType.CustomButton.Image = null;
            this.tbType.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbType.CustomButton.Name = "";
            this.tbType.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbType.CustomButton.TabIndex = 1;
            this.tbType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbType.CustomButton.UseSelectable = true;
            this.tbType.CustomButton.Visible = false;
            this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Type", true));
            this.tbType.Lines = new string[0];
            this.tbType.Location = new System.Drawing.Point(198, 191);
            this.tbType.MaxLength = 32767;
            this.tbType.Name = "tbType";
            this.tbType.PasswordChar = '\0';
            this.tbType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbType.SelectedText = "";
            this.tbType.SelectionLength = 0;
            this.tbType.SelectionStart = 0;
            this.tbType.ShortcutsEnabled = true;
            this.tbType.Size = new System.Drawing.Size(411, 30);
            this.tbType.TabIndex = 20;
            this.tbType.UseSelectable = true;
            this.tbType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "NameSupplier", true));
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(198, 134);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(411, 30);
            this.tbName.TabIndex = 19;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.CustomButton.Image = null;
            this.tbID.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbID.CustomButton.Name = "";
            this.tbID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbID.CustomButton.TabIndex = 1;
            this.tbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbID.CustomButton.UseSelectable = true;
            this.tbID.CustomButton.Visible = false;
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierCode", true));
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(198, 78);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.SelectionLength = 0;
            this.tbID.SelectionStart = 0;
            this.tbID.ShortcutsEnabled = true;
            this.tbID.Size = new System.Drawing.Size(411, 30);
            this.tbID.TabIndex = 18;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(28, 411);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 20);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Phone No.";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.Location = new System.Drawing.Point(27, 358);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 20);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Email";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(27, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 20);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Type";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(27, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 20);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(27, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Supplier ID";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // tbKTP
            // 
            // 
            // 
            // 
            this.tbKTP.CustomButton.Image = null;
            this.tbKTP.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbKTP.CustomButton.Name = "";
            this.tbKTP.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbKTP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbKTP.CustomButton.TabIndex = 1;
            this.tbKTP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbKTP.CustomButton.UseSelectable = true;
            this.tbKTP.CustomButton.Visible = false;
            this.tbKTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "NoKTP", true));
            this.tbKTP.Lines = new string[0];
            this.tbKTP.Location = new System.Drawing.Point(198, 295);
            this.tbKTP.MaxLength = 32767;
            this.tbKTP.Name = "tbKTP";
            this.tbKTP.PasswordChar = '\0';
            this.tbKTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKTP.SelectedText = "";
            this.tbKTP.SelectionLength = 0;
            this.tbKTP.SelectionStart = 0;
            this.tbKTP.ShortcutsEnabled = true;
            this.tbKTP.Size = new System.Drawing.Size(411, 30);
            this.tbKTP.TabIndex = 27;
            this.tbKTP.UseSelectable = true;
            this.tbKTP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbKTP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.Location = new System.Drawing.Point(27, 305);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 20);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "No. KTP";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // tbDistance
            // 
            // 
            // 
            // 
            this.tbDistance.CustomButton.Image = null;
            this.tbDistance.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbDistance.CustomButton.Name = "";
            this.tbDistance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbDistance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDistance.CustomButton.TabIndex = 1;
            this.tbDistance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDistance.CustomButton.UseSelectable = true;
            this.tbDistance.CustomButton.Visible = false;
            this.tbDistance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "DistanceFromFactory", true));
            this.tbDistance.Lines = new string[0];
            this.tbDistance.Location = new System.Drawing.Point(198, 466);
            this.tbDistance.MaxLength = 32767;
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.PasswordChar = '\0';
            this.tbDistance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDistance.SelectedText = "";
            this.tbDistance.SelectionLength = 0;
            this.tbDistance.SelectionStart = 0;
            this.tbDistance.ShortcutsEnabled = true;
            this.tbDistance.Size = new System.Drawing.Size(411, 30);
            this.tbDistance.TabIndex = 31;
            this.tbDistance.UseSelectable = true;
            this.tbDistance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDistance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel7.Location = new System.Drawing.Point(28, 466);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(133, 20);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Distance from office";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // tbContactPerson
            // 
            // 
            // 
            // 
            this.tbContactPerson.CustomButton.Image = null;
            this.tbContactPerson.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.tbContactPerson.CustomButton.Name = "";
            this.tbContactPerson.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbContactPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbContactPerson.CustomButton.TabIndex = 1;
            this.tbContactPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbContactPerson.CustomButton.UseSelectable = true;
            this.tbContactPerson.CustomButton.Visible = false;
            this.tbContactPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "PersonInCharge", true));
            this.tbContactPerson.Lines = new string[0];
            this.tbContactPerson.Location = new System.Drawing.Point(198, 246);
            this.tbContactPerson.MaxLength = 32767;
            this.tbContactPerson.Name = "tbContactPerson";
            this.tbContactPerson.PasswordChar = '\0';
            this.tbContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContactPerson.SelectedText = "";
            this.tbContactPerson.SelectionLength = 0;
            this.tbContactPerson.SelectionStart = 0;
            this.tbContactPerson.ShortcutsEnabled = true;
            this.tbContactPerson.Size = new System.Drawing.Size(411, 30);
            this.tbContactPerson.TabIndex = 29;
            this.tbContactPerson.UseSelectable = true;
            this.tbContactPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbContactPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel8.Location = new System.Drawing.Point(28, 256);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 20);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Contact Person";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // EntrySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbContactPerson);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbKTP);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EntrySupplier";
            this.Text = "EntrySupplier";
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox tbPhone;
        private MetroFramework.Controls.MetroTextBox tbEmail;
        private MetroFramework.Controls.MetroTextBox tbType;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox tbKTP;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbDistance;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbContactPerson;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}