using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App
{
    public partial class EntryCustomer : MetroForm
    {
        asiainspEntities db;
        public EntryCustomer(Customer obj)
        {
            
            InitializeComponent();
            db = new asiainspEntities();
            if (obj == null)
            {
                customerBindingSource.DataSource = new Customer();
                db.Customers.Add(customerBindingSource.Current as Customer);
            }
            else
            {
                customerBindingSource.DataSource = obj;
                db.Customers.Attach(customerBindingSource.Current as Customer);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();
            db.SaveChangesAsync();
            System.Windows.Forms.MessageBox.Show("Saved!");
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
