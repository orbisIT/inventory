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
    public partial class Homepage : MetroForm
    {
        asiainspEntities db;
        string currentView;
        public Homepage(User obj)
        {
            InitializeComponent();
            db = new asiainspEntities();
            lblUsername.Text = obj.Username;
            lblUsername.TextAlign = ContentAlignment.TopRight;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            currentView = "articles";
           
        }

        private void BtnArticles_Click(object sender, EventArgs e)
        {
            vwarticlesBindingSource.DataSource = db.vw_articles.ToList();
            currentView = "articles";
            mg_articles.Show();
            mg_cust.Hide();
            mg_supplier.Hide();


        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = db.Suppliers.ToList();
            currentView = "suppliers";
            mg_articles.Hide();
            mg_cust.Hide();
            mg_supplier.Show();
        }

        private void BtnCust_Click(object sender, EventArgs e)
        {
            currentView = "customers";
            customerBindingSource.DataSource = db.Customers.ToList();
            mg_articles.Hide();
            mg_cust.Show();
            mg_supplier.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch (currentView)
            {
                case "articles":
                    EntryArticle artForm = new EntryArticle(null);
                    artForm.Show();
                    break;
                case "customers":
                    EntryCustomer custFrom = new EntryCustomer(null);
                    custFrom.Show();
                    break;
                case "suppliers":
                    EntrySupplier supForm = new EntrySupplier(null);
                    supForm.Show();
                    break;
            }
        }

        private void Mg_cust_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (EntryCustomer frm = new EntryCustomer(customerBindingSource.Current as Customer))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customerBindingSource.DataSource = db.Customers.ToList();
                }
            }
        }

        private void Mg_supplier_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (EntrySupplier frm = new EntrySupplier(supplierBindingSource.Current as Supplier))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    supplierBindingSource.DataSource = db.Suppliers.ToList();
                }
            }
        }

        private void Mg_articles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (EntryArticle frm = new EntryArticle(vwarticlesBindingSource.Current as vw_articles))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    vwarticlesBindingSource.DataSource = db.vw_articles.ToList();
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }
    }
}
