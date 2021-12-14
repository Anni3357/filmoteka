using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Filmoteka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  string mainconn = ConfigurationManager.ConnectionStrings["Filmoteka"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[FilmDB] where director"+comboBox1.Text.ToString()+"^";
            SqlCommand sqlcomn = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomn);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            filmsDataGridView.DataSource = dt;
            sqlconn.Close(); */

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           /* string mainconn = ConfigurationManager.ConnectionStrings["Filmoteka"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select director from [dbo].[FilmDB]";
            SqlCommand sqlcomn = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomn);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            comboBox1.DisplayMember = "director";
            comboBox1.DataSource = dt;
            sqlconn.Close(); */
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Films". При необходимости она может быть перемещена или удалена.
            //this.filmsTableAdapter.Fill(this.dataSet1.Films);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Director". При необходимости она может быть перемещена или удалена.
            //this.directorTableAdapter.Fill(this.dataSet1.Director);
            
        }
    }
}
