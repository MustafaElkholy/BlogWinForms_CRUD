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
    public partial class Login : Form
    {
        BlogDbContext db;
        public Login()
        {
            db = new BlogDbContext();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.Authors.Where(u => u.UserName == txt_username.Text).FirstOrDefault();
                if (user.UserName == txt_username.Text && user.Password == txt_password.Text)
                {
                    UserNews news = new UserNews(user.Id,user.UserName);
                    Hide();
                    news.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("The user don't exist");
            }
        }
    }
}
