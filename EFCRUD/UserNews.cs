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

    public partial class UserNews : Form
    {
        BlogDbContext db;
        private int userId;
        private string userName;
        public UserNews(int userId, string userName)
        {
            db = new BlogDbContext();
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
        }

        private void UserNews_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome {userName}";
            dgv_usernews.DataSource = db.News.Where(u => u.Id == userId).ToList();
            cb_category.DataSource = db.Catlogs.ToList();
            cb_category.ValueMember = "Id";
            cb_category.DisplayMember = "Title";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var title = txt_title.Text;
            var descreption = txt_desc.Text;
            var brief = txt_brief.Text;
            var photo = txt_photo.Text;
            var date = DateTime.Parse(txt_date.Text);

            var news = new News
            {
                Title = title,
                Brief = brief,
                BriefDescription = descreption,
                Photo = photo,
                PublishDate = date,
                AuthorId = userId,
                CatalogId = (int)cb_category.SelectedValue
            };
            db.Add(news);
            db.SaveChanges();
            dgv_usernews.DataSource = db.News.Where(u => u.Id == userId).ToList();
            MessageBox.Show("News Added.");
            txt_brief.Text = txt_desc.Text = txt_photo.Text = txt_title.Text = "";


        }



        int id;

        private void dgv_usernews_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_usernews.SelectedRows[0].Cells[0].Value;
            var news = db.News.Where(s => s.Id == id).SingleOrDefault();

            txt_title.Text = news?.Title;
            txt_brief.Text = news.Brief;
            txt_desc.Text = news.BriefDescription;
            txt_photo.Text = news.Photo;
            cb_category.SelectedValue = news.CatalogId;

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            var news = db.News.Where(n => n.Id == id).SingleOrDefault();

            txt_title.Text = news?.Title;
            txt_brief.Text = news.Brief;
            txt_desc.Text = news.BriefDescription;
            txt_photo.Text = news.Photo;
            cb_category.SelectedValue = news.CatalogId;

            db.SaveChanges();
            dgv_usernews.DataSource = db.News.Where(n => n.Id == userId).ToList();
            MessageBox.Show("News Updated.");
            txt_brief.Text = txt_desc.Text = txt_photo.Text = txt_title.Text = "";




        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var news = db.News.Where(n => n.Id == id).SingleOrDefault();
            db.News.Remove(news);
            db.SaveChanges();
            dgv_usernews.DataSource = db.News.Where(n => n.Id == userId).ToList();
            MessageBox.Show("News Deleted.");
            txt_brief.Text = txt_desc.Text = txt_photo.Text = txt_title.Text = "";

        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            AllNews allNews = new AllNews();
            allNews.ShowDialog();
        }
    }
}
