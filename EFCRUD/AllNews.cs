using EFCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCRUD
{
    public partial class AllNews : Form
    {
        bool flag;
        BlogDbContext db;
        public AllNews()
        {
            db = new BlogDbContext();
            InitializeComponent();
        }

        private void AllNews_Load(object sender, EventArgs e)
        {
            cb_catalog.DataSource = db.Catlogs.ToList();
            cb_catalog.ValueMember = "Id";
            cb_catalog.DisplayMember = "Title";
            flag = true;
        }

        private void cb_catalog_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                var news = db.News.Where(x => x.CatalogId == (int?)cb_catalog.SelectedValue).ToList();

                dgv_allNews.DataSource = news;
            }

        }
    }
}
