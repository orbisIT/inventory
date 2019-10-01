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
    public partial class EntrySupplier : MetroForm
    {
        asiainspEntities db;
        public EntrySupplier(Supplier obj)
        {
            InitializeComponent();
            db = new asiainspEntities();
            if (obj == null)
            {
                supplierBindingSource.DataSource = new Supplier();
                db.Suppliers.Add(supplierBindingSource.Current as Supplier);
            }
            else
            {
                supplierBindingSource.DataSource = obj;
                db.Suppliers.Attach(supplierBindingSource.Current as Supplier);
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            supplierBindingSource.EndEdit();
            db.SaveChangesAsync();
            System.Windows.Forms.MessageBox.Show("Saved!");
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            supplierBindingSource.EndEdit();
            db.SaveChangesAsync();
            System.Windows.Forms.MessageBox.Show("Saved!");
            this.Close();
        }
    }
}
