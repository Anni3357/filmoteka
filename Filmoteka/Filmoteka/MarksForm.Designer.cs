
namespace Filmoteka
{
    partial class MarksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.valuelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new Filmoteka.DataSet1();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Filmoteka.DataSet1TableAdapters.FilmsTableAdapter();
            this.tableAdapterManager = new Filmoteka.DataSet1TableAdapters.TableAdapterManager();
            this.namefilmLabel = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оцените фильм";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(98, 513);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(463, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Filmoteka.Properties.Resources.icons8_новогодняя_елка_96;
            this.pictureBox6.Location = new System.Drawing.Point(497, 412);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(99, 95);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Filmoteka.Properties.Resources.icons8_новогодняя_елка_96;
            this.pictureBox5.Location = new System.Drawing.Point(392, 412);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(99, 95);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Filmoteka.Properties.Resources.icons8_новогодняя_елка_96;
            this.pictureBox4.Location = new System.Drawing.Point(287, 412);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(99, 95);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Filmoteka.Properties.Resources.icons8_новогодняя_елка_96;
            this.pictureBox3.Location = new System.Drawing.Point(182, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 95);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Filmoteka.Properties.Resources.icons8_новогодняя_елка_96;
            this.pictureBox2.Location = new System.Drawing.Point(77, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 95);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // valuelabel
            // 
            this.valuelabel.AutoSize = true;
            this.valuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valuelabel.Location = new System.Drawing.Point(350, 257);
            this.valuelabel.Name = "valuelabel";
            this.valuelabel.Size = new System.Drawing.Size(24, 25);
            this.valuelabel.TabIndex = 12;
            this.valuelabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Оценка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Оценить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.dataSet1;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DirectorTableAdapter = null;
            this.tableAdapterManager.FilmsTableAdapter = this.filmsTableAdapter;
            this.tableAdapterManager.MarksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Filmoteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // namefilmLabel
            // 
            this.namefilmLabel.AutoSize = true;
            this.namefilmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namefilmLabel.Location = new System.Drawing.Point(246, 107);
            this.namefilmLabel.Name = "namefilmLabel";
            this.namefilmLabel.Size = new System.Drawing.Size(315, 39);
            this.namefilmLabel.TabIndex = 2;
            this.namefilmLabel.Text = "Название фильма";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.Location = new System.Drawing.Point(332, 158);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(63, 25);
            this.genre.TabIndex = 5;
            this.genre.Text = "жанр";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.director.Location = new System.Drawing.Point(247, 203);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(139, 31);
            this.director.TabIndex = 4;
            this.director.Text = "Режиссер";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(248, 158);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(44, 25);
            this.year.TabIndex = 3;
            this.year.Text = "год";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valuelabel);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.director);
            this.Controls.Add(this.year);
            this.Controls.Add(this.namefilmLabel);
            this.Controls.Add(this.label1);
            this.Name = "MarksForm";
            this.Text = "MarksForm";
            this.Load += new System.EventHandler(this.MarksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label valuelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private DataSet1TableAdapters.FilmsTableAdapter filmsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label namefilmLabel;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}