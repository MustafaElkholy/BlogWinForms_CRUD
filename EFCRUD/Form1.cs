using EFCRUD.Models;

namespace EFCRUD
{
    public partial class Form1 : Form
    {
        BlogDbContext db;
        public Form1()
        {
            db = new BlogDbContext();
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.UserName = txt_name.Text;
            author.Email = txt_email.Text;
            author.Password = txt_password.Text;
            author.Age = int.Parse(txt_age.Text);
            try
            {
                db.Authors.Add(author);
                db.SaveChanges();
                MessageBox.Show($"{txt_name.Text} is Added");
                ShowLoginForm();


                txt_name.Text = txt_age.Text = txt_email.Text = txt_password.Text = "";

            }
            catch (Exception)
            {

                MessageBox.Show("Try register Again");

            }
        }

        private void ShowLoginForm()
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            ShowLoginForm();

        }
    }
}