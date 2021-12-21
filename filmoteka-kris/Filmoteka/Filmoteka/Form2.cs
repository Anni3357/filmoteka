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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            string stringCommand = "select [id], [login], [password], [role] from [Users]";
            SqlDataAdapter da = new SqlDataAdapter(stringCommand, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // создаем подключение
            conn.Open();
            com.Connection = conn;
            //com.CommandText = ("INSERT INTO Films (name, year, url, director, ganre) VALUES ('" + nameBox.Text + "','" + yearBox.Text + "','" + urlBox.Text + "','" + directorBox.Text + "','" + ganreBox.Text +  "');");
            //com.CommandText = ("INSERT INTO Films (name, url, director, ganre) VALUES ('" + nameBox.Text + "','" + urlBox.Text + "','" + directorBox.Text + "','" + ganreBox.Text + "');");
            com.ExecuteNonQuery();
            conn.Close();
            //nameBox.Clear();
            //yearBox.Clear();
            //urlBox.Clear();
            //directorBox.Clear();
            //ganreBox.Clear();
            MessageBox.Show("Изменения сохранены!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentCell.Value.ToString();
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string command_model_kar = "DELETE FROM Users WHERE (id=" + Convert.ToInt16(s) + ");";
            SqlCommand command_model_kar_add = new SqlCommand(command_model_kar, connection);
            command_model_kar_add.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись удалена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string stringCommand = "select [id], [login], [password], [role] from [Users]";
            SqlDataAdapter da = new SqlDataAdapter(stringCommand, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Записи обновлены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 bazFilm = new Form2();
            bazFilm.Show();
        }
    }
}
