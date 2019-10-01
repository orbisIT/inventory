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
    public partial class EntryArticle2 : MetroForm
    {
        asiainspEntities db;
        vw_articles art;
        public EntryArticle2(vw_articles obj)
        {
            InitializeComponent();
            db = new asiainspEntities();

            if (obj == null)
            {
                vw_articlesBindingSource.DataSource = new vw_articles();
                art = new vw_articles();
                //db.vw_articles.Add(vwarticlesBindingSource.Current as vw_articles);
                tbArticleCode.Focus();
            }
            else
            {
                vw_articlesBindingSource.DataSource = obj;
                cboShape.SelectedItem = cboShape.FindString(art.ShapeName);
                db.vw_articles.Attach(vw_articlesBindingSource.Current as vw_articles);
            }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {

        }
    }
}
