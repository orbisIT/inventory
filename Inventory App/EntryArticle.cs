using MetroFramework;
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
    public partial class EntryArticle : MetroForm
    {
        asiainspEntities db;
        vw_articles art;

        public EntryArticle(vw_articles obj)
        {
            InitializeComponent();
            db = new asiainspEntities();
            
            if (obj == null)
            {
                vwarticlesBindingSource.DataSource = new vw_articles();
                art = new vw_articles();
                //db.vw_articles.Add(vwarticlesBindingSource.Current as vw_articles);
                tbArticleCode.Focus();
            }
            else
            {
                vwarticlesBindingSource.DataSource = obj;
                cboShape.SelectedItem = cboShape.FindString(art.ShapeName);
                db.vw_articles.Attach(vwarticlesBindingSource.Current as vw_articles);
            }
        }
        private void EntryArticle_Load(object sender, EventArgs e)
        {
            tbArticleCode.Focus();
            vwarticlesBindingSource.ResetBindings(true);
            try
            {
                cboAdditional.DataSource = db.Additionals.ToList();
                cboAdditional.ValueMember = "AdditionalID";
                cboAdditional.DisplayMember = "AdditionalName";

                cboFinishing.DataSource = db.Finishings.ToList();
                cboFinishing.ValueMember = "FinishingID";
                cboFinishing.DisplayMember = "FinishingName";

                cboMaterial.DataSource = db.Materials.ToList();
                cboMaterial.ValueMember = "MaterialID";
                cboMaterial.DisplayMember = "MaterialName";

                cboShape.DataSource = db.Shapes.ToList();
                cboShape.ValueMember = "ShapeID";
                cboShape.DisplayMember = "ShapeName";

                cboSize.DataSource = db.Sizes.ToList();
                cboSize.ValueMember = "SizeID";
                cboSize.DisplayMember = "SizeName";

                cboType.DataSource = db.Types.ToList();
                cboType.ValueMember = "TypeID";
                cboType.DisplayMember = "TypeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database is not connected" + ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            art = vwarticlesBindingSource.Current as vw_articles;
            //currency cbo
            string value = "";
            bool isChecked = rb_idr.Checked;
            if (isChecked)
                value = rb_idr.Text;
            else
                value = rb_usd.Text;
            art.Currency = value;

            db.sp_insert_articles(art.ID, art.SupplierCode, art.TypeName, art.MaterialName, art.SizeName, art.FinishingName, art.AdditionalName, art.ShapeName, art.Description, art.SizeL, art.SizeW, art.SizeD, art.BoxSizeL, art.BoxSizeW, art.BoxSizeD, art.GrossWeight, art.NetWeight, art.PriceSales, art.PriceSupplier, art.Currency);
            vwarticlesBindingSource.EndEdit();
            db.SaveChanges();
            MetroMessageBox.Show(this, "New article with article-id = " + art.ID + " is saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (EntryArticle frm = new EntryArticle(vwarticlesBindingSource.Current as vw_articles))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    vwarticlesBindingSource.DataSource = db.vw_articles.ToList();
                }
            }
            art = vwarticlesBindingSource.Current as vw_articles;
            db.vw_articles.Remove(art);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnUpload_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
