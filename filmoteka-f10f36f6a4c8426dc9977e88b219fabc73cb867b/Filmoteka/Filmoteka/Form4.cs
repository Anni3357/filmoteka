﻿using System;
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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            
            //поиск работает, но не правильно
            string stringCommand2 = "select [name] from [Director]";
            SqlDataAdapter da2 = new SqlDataAdapter(stringCommand2, connection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            //комбобокс рабочий
            this.comboBox1.DataSource = dt2;
            this.comboBox1.DisplayMember = "name";
          

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            if (this.comboBox1.SelectedIndex == 0)
            {
                
                string stringCommand = "select [name], [year], [director], [ganre] from [Films]";
                SqlDataAdapter da = new SqlDataAdapter(stringCommand, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                filmsDataGridView.DataSource = dt;
            }
            else { 
            
            //поиск
            string stringCommand3 = "select [name], [year], [director], [ganre] from [Films] WHERE [director]='" + comboBox1.Text + "'";
            SqlDataAdapter da3 = new SqlDataAdapter(stringCommand3, connection);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            filmsDataGridView.DataSource = dt3;
            
        }
            
        }

   

        private void filmsDataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            int X = filmsDataGridView.CurrentCell.ColumnIndex;
            int Y = filmsDataGridView.CurrentCell.RowIndex;
            //MessageBox.Show($"Выбран {X} {Y} элемент таблицы ");
            GlobalClass.Variant1 = filmsDataGridView[0, Y].Value.ToString();
            this.Hide();
            MarksForm marks = new MarksForm();
            marks.Show();
        }

       
    }
}
