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

namespace Filmoteka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        enum Role { Failed, User1, User2 }
        static Role GetRole(string login, string password)
        {
            Role role = Role.Failed;
            //Заменить в сервере строку подключения на свою добавив два слеша
            using (var connection = new SqlConnection("server=LAPTOP-6038JFDU;Trusted_Connection=Yes;Database=FilmDB;"))
            {
                connection.Open();
                var command = new SqlCommand("Select [Role] From [Users] WHERE Login=@Login AND Password=@Password", connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        switch ((int)dataReader["Role"])
                        {
                            case 0: role = Role.User2; break;
                            case 1: role = Role.User1; break;
                        }
                    }
                }
            }
            return role;
        }

        private void Passbutton_Click(object sender, EventArgs e)
        {
            Role role = GetRole(LoginBox.Text, PasswordBox.Text);
            //Если неправильно
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else {
                //MessageBox.Show("Верный логин и пароль");
                if (role == Role.User1)
                {
                    this.Hide();
                   Form1 bazFilm = new Form1();
                    bazFilm.Show();
                }
                else if (role == Role.User2)
                {
                    this.Hide();
                    User user = new User();
                    user.Show();
                }
            }
            



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    

