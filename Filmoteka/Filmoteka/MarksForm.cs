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
    public partial class MarksForm : Form
    {
        string mark;
        int x;
        string Z = GlobalClass.Variant1;
        public MarksForm()
        {
            InitializeComponent();
            namefilmLabel.Text = GlobalClass.Variant1;
            year.Text = GlobalClass.Variant2;
            genre.Text = GlobalClass.Variant3;
            director.Text = GlobalClass.Variant4;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.dataSet1.Films);

        }
    }
}
