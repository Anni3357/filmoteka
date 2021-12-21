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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            
        }
        
        enum Role { Failed, User1}
        static Role GetRole(string login)
        {
           // string alreadylogin = LoginBox.Text;
            Role role = Role.Failed;
            //Заменить в сервере строку подключения на свою добавив два слеша
            using (var connection = new SqlConnection("server=LAPTOP-6038JFDU;Trusted_Connection=Yes;Database=FilmDB;"))
            {
                connection.Open(); // открываем подключение
                var command = new SqlCommand("Select [login] From [Users] WHERE login=@Login", connection);
                command.Parameters.AddWithValue("@Login", login);
               
                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        
                        switch ((string)dataReader["login"])
                        {

                            default:
                                role = Role.User1; break;
                                
                        }
                    }
                }
            }
            return role;
        }
        private void Passbutton_Click(object sender, EventArgs e)
        {
            Role role = GetRole(LoginBox.Text);
            //Если существует
            if (role == Role.User1)
            {
                MessageBox.Show("Введенный логин уже существует, придумайте другой");
            }
            else
            {
                if(LoginBox.Text=="" || PasswordBox.Text=="")
                {
                    MessageBox.Show("Оба поля должны быть заполнены");
                }
                else
                { 
                string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString); // создаем подключение
                SqlCommand cmd = new SqlCommand("insert into Users values ('" + LoginBox.Text + "','" + PasswordBox.Text + "',0)", conn); // создаем SQL запрос
                conn.Open();
                cmd.ExecuteNonQuery(); // выполняем запрос на сервер
                conn.Close(); // закрываем соединение
                MessageBox.Show("Вы успешно зарегистрировались!");
                LoginForm logform = new LoginForm();
                logform.Show();
                }
            }
            






        }

        private void Registratebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start bazFilm = new Start();
            bazFilm.Show();
        }
    }
}
