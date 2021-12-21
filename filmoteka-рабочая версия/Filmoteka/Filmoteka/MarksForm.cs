using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka
{
    public partial class MarksForm : Form
    {
        string mark;
        int x;
        string Z = GlobalClass.Variant1;
        public MarksForm()
        {
            InitializeComponent();
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
            namefilmLabel.Text = GlobalClass.Variant1;
            //год
            string stringCommand2 = "select [year] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            SqlCommand da2 = new SqlCommand(stringCommand2, connection);
            connection.Open();
            year.Text = da2.ExecuteScalar().ToString();
            connection.Close();
            //жанр
            string stringCommand3 = "select [ganre] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            SqlCommand da3 = new SqlCommand(stringCommand3, connection);
            connection.Open();
            genre.Text = da3.ExecuteScalar().ToString();
            connection.Close();
            //режиссер
            string stringCommand4 = "select [director] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            SqlCommand da4 = new SqlCommand(stringCommand4, connection);
            connection.Open();
            director.Text = da4.ExecuteScalar().ToString();
            connection.Close();
            //постер
            byte[] byteArray = new byte[0];
            string sqlCommand = "select [poster] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            connection.Open();
            try
            {
                SqlCommand myCommand = new SqlCommand(sqlCommand, connection);
                SqlDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    byteArray = new byte[((byte[])myDataReader["poster"]).Length];
                    byteArray = (byte[])myDataReader["poster"];
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            connection.Close();
            MemoryStream ms = new MemoryStream(byteArray);
            Image img = Image.FromStream(ms);
            this.pictureBox1.Image = img;
            ms.Close();
          
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valuelabel.Text = trackBar1.Value.ToString();
            mark = trackBar1.Value.ToString();
            x = Convert.ToInt32(mark);
           /* if (x==2)
            {
                pictureBox2.Visible = false;
            }
            if (x == 3)
            {
                pictureBox3.Visible = false;

            }
            if (x == 4)
            {
                pictureBox4.Visible = false;
                

            }
            if (x == 5)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            } */
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ссылка на просмотр фильма
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string stringCommand5 = "select [url] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            SqlCommand da5 = new SqlCommand(stringCommand5, connection);
            connection.Open();
            System.Diagnostics.Process.Start(da5.ExecuteScalar().ToString());
            connection.Close();
        }
    }
}
