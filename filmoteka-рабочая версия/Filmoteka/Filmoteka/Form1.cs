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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            Console.Read();
            string stringCommand = "select [id_film] as [id фильма], [name] as [Название], [year] as [Год выпуска], [director] as [Режиссер], [ganre] as [Жанр] from [Films]";
            SqlDataAdapter da = new SqlDataAdapter(stringCommand, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int f = Convert.ToInt32(yearBox.Text);
            //SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // создаем подключение
            conn.Open();
            com.Connection = conn;
            com.CommandText = ("INSERT INTO Films (name, year, url, director, ganre) VALUES ('" + nameBox.Text + "','" + f + "','" + urlBox.Text + "','" + directorBox.Text + "','" + ganreBox.Text + "');");
            //com.CommandText = ("INSERT INTO Films (name, url, director, ganre) VALUES ('" + nameBox.Text + "','" + urlBox.Text + "','" + directorBox.Text + "','" + ganreBox.Text + "');");
            com.ExecuteNonQuery();
            conn.Close();
            nameBox.Clear();
            yearBox.Clear();
            urlBox.Clear();
            directorBox.Clear();
            ganreBox.Clear();
            MessageBox.Show("Изменения сохранены!");
            ///*SqlCommand cmd = new SqlCommand("insert into Films values ('" + nameBox.Text + "','" + yearBox.Text + "','" + urlBox.Text + "','" + directorBox.Text + "','" + ganreBox.Text + "')", conn);*/ // создаем SQL запрос
            //SqlCommand cmd = new SqlCommand(" INSERT INTO Films (name, year, url, director, ganre) values (nameBox.Text, yearBox.Text,urlBox.Text,directorBox.Text,ganreBox.Text)", conn);
            //conn.Open();
            //cmd.ExecuteNonQuery(); // выполняем запрос на сервер
            //conn.Close(); // закрываем соединение
            //MessageBox.Show("Вы успешно зарегистрировались!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentCell.Value.ToString();
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string command_model_kar = "DELETE FROM Films WHERE (id_film=" + Convert.ToInt16(s) + ");";
            SqlCommand command_model_kar_add = new SqlCommand(command_model_kar, connection);
            command_model_kar_add.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись удалена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string stringCommand = "select [id_film], [name], [year], [director], [ganre] from [Films]";
            SqlDataAdapter da = new SqlDataAdapter(stringCommand, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Записи обновлены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start bazFilm = new Start();
            bazFilm.Show();
        }
    }
}
