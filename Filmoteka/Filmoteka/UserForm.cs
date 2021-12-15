using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka
{
    public partial class UserForm : Form
    {
        
        public UserForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.dataSet1.Films);
        }

        private void filmsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.dataSet1.Films);

        }

        private void filmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          


        }

        private void filmsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filmsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.filmsTableAdapter.FillBy(this.dataSet1.Films);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filmsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string X = id_filmLabel3.Text;
            MessageBox.Show($"Выбран {X} элемент таблицы ");
            GlobalClass.Variant1 = nameLabel3.Text;
            GlobalClass.Variant2 = yearLabel3.Text;
            GlobalClass.Variant3 = ganreLabel1.Text;
            GlobalClass.Variant4 = directorLabel1.Text;
            this.Hide();
            MarksForm markform = new MarksForm();
            markform.Show();
        }

        private void posterPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

// string X = id_filmLabel1.Text;
// MessageBox.Show($"Выбран {X} элемент таблицы ");
// this.Hide();
// MarksForm markform = new MarksForm();
//markform.Show();