using Dapper;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Inventory_App
{
    public partial class Login : MetroForm
    {
        asiainspEntities db;

        [Obsolete]
        public Login()
        {
            InitializeComponent();
            db = new asiainspEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                tbUsername.Text = Properties.Settings.Default.UserName;
                tbPass.Text = Properties.Settings.Default.Password;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return;
            }
            try
            {

                using (db)
                {

                    User obj = db.Users.Where(u => u.Username == tbUsername.Text).FirstOrDefault<User>();
                    if (obj != null)
                    {
                        if (obj.Password == tbPass.Text)
                        {
                            Homepage form = new Homepage(obj);
                            this.Hide();
                            form.Show();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Your username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your username doesn't exsist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = tbUsername.Text;
                Properties.Settings.Default.Password = tbPass.Text;
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.RememberMe = cbRememberMe.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
