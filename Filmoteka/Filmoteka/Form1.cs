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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.dataSet1.Films);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmsBindingSource.EndEdit();
            filmsTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void id_filmTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
