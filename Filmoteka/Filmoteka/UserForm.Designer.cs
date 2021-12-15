
namespace Filmoteka
{
    partial class UserForm
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
            System.Windows.Forms.Label id_filmLabel2;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label posterLabel;
            System.Windows.Forms.Label yearLabel2;
            System.Windows.Forms.Label urlLabel2;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label ganreLabel;
            this.dataSet1 = new Filmoteka.DataSet1();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Filmoteka.DataSet1TableAdapters.FilmsTableAdapter();
            this.tableAdapterManager = new Filmoteka.DataSet1TableAdapters.TableAdapterManager();
            this.filmsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_filmLabel3 = new System.Windows.Forms.Label();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.urlLabel3 = new System.Windows.Forms.Label();
            this.ganreLabel1 = new System.Windows.Forms.Label();
            this.directorLabel1 = new System.Windows.Forms.Label();
            this.yearLabel3 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            id_filmLabel2 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            posterLabel = new System.Windows.Forms.Label();
            yearLabel2 = new System.Windows.Forms.Label();
            urlLabel2 = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            ganreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // filmsBindingSource1
            // 
            this.filmsBindingSource1.DataMember = "Films";
            this.filmsBindingSource1.DataSource = this.dataSet1;
            // 
            // filmsDataGridView
            // 
            this.filmsDataGridView.AutoGenerateColumns = false;
            this.filmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.filmsDataGridView.DataSource = this.filmsBindingSource;
            this.filmsDataGridView.Location = new System.Drawing.Point(12, 23);
            this.filmsDataGridView.Name = "filmsDataGridView";
            this.filmsDataGridView.Size = new System.Drawing.Size(1055, 295);
            this.filmsDataGridView.TabIndex = 3;
            this.filmsDataGridView.DoubleClick += new System.EventHandler(this.filmsDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_film";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "id_film";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dataGridViewImageColumn1.DataPropertyName = "poster";
            this.dataGridViewImageColumn1.HeaderText = "poster";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 21;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn3.HeaderText = "year";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "url";
            this.dataGridViewTextBoxColumn4.HeaderText = "url";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "director";
            this.dataGridViewTextBoxColumn5.HeaderText = "director";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ganre";
            this.dataGridViewTextBoxColumn6.HeaderText = "ganre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // id_filmLabel2
            // 
            id_filmLabel2.AutoSize = true;
            id_filmLabel2.Location = new System.Drawing.Point(396, 336);
            id_filmLabel2.Name = "id_filmLabel2";
            id_filmLabel2.Size = new System.Drawing.Size(36, 13);
            id_filmLabel2.TabIndex = 9;
            id_filmLabel2.Text = "id film:";
            // 
            // id_filmLabel3
            // 
            this.id_filmLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "id_film", true));
            this.id_filmLabel3.Location = new System.Drawing.Point(447, 336);
            this.id_filmLabel3.Name = "id_filmLabel3";
            this.id_filmLabel3.Size = new System.Drawing.Size(100, 23);
            this.id_filmLabel3.TabIndex = 10;
            this.id_filmLabel3.Text = "label1";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(396, 359);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(36, 13);
            nameLabel2.TabIndex = 11;
            nameLabel2.Text = "name:";
            // 
            // posterLabel
            // 
            posterLabel.AutoSize = true;
            posterLabel.Location = new System.Drawing.Point(396, 385);
            posterLabel.Name = "posterLabel";
            posterLabel.Size = new System.Drawing.Size(39, 13);
            posterLabel.TabIndex = 13;
            posterLabel.Text = "poster:";
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.filmsBindingSource, "poster", true));
            this.posterPictureBox.Location = new System.Drawing.Point(447, 385);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(100, 50);
            this.posterPictureBox.TabIndex = 14;
            this.posterPictureBox.TabStop = false;
            this.posterPictureBox.Click += new System.EventHandler(this.posterPictureBox_Click);
            // 
            // yearLabel2
            // 
            yearLabel2.AutoSize = true;
            yearLabel2.Location = new System.Drawing.Point(396, 438);
            yearLabel2.Name = "yearLabel2";
            yearLabel2.Size = new System.Drawing.Size(30, 13);
            yearLabel2.TabIndex = 15;
            yearLabel2.Text = "year:";
            // 
            // urlLabel2
            // 
            urlLabel2.AutoSize = true;
            urlLabel2.Location = new System.Drawing.Point(396, 461);
            urlLabel2.Name = "urlLabel2";
            urlLabel2.Size = new System.Drawing.Size(21, 13);
            urlLabel2.TabIndex = 17;
            urlLabel2.Text = "url:";
            // 
            // urlLabel3
            // 
            this.urlLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "url", true));
            this.urlLabel3.Location = new System.Drawing.Point(447, 461);
            this.urlLabel3.Name = "urlLabel3";
            this.urlLabel3.Size = new System.Drawing.Size(100, 23);
            this.urlLabel3.TabIndex = 18;
            this.urlLabel3.Text = "label1";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(396, 484);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(45, 13);
            directorLabel.TabIndex = 19;
            directorLabel.Text = "director:";
            // 
            // ganreLabel
            // 
            ganreLabel.AutoSize = true;
            ganreLabel.Location = new System.Drawing.Point(396, 507);
            ganreLabel.Name = "ganreLabel";
            ganreLabel.Size = new System.Drawing.Size(37, 13);
            ganreLabel.TabIndex = 21;
            ganreLabel.Text = "ganre:";
            // 
            // ganreLabel1
            // 
            this.ganreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "ganre", true));
            this.ganreLabel1.Location = new System.Drawing.Point(447, 507);
            this.ganreLabel1.Name = "ganreLabel1";
            this.ganreLabel1.Size = new System.Drawing.Size(100, 23);
            this.ganreLabel1.TabIndex = 22;
            this.ganreLabel1.Text = "label1";
            // 
            // directorLabel1
            // 
            this.directorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "director", true));
            this.directorLabel1.Location = new System.Drawing.Point(447, 484);
            this.directorLabel1.Name = "directorLabel1";
            this.directorLabel1.Size = new System.Drawing.Size(100, 23);
            this.directorLabel1.TabIndex = 20;
            this.directorLabel1.Text = "label1";
            // 
            // yearLabel3
            // 
            this.yearLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "year", true));
            this.yearLabel3.Location = new System.Drawing.Point(447, 438);
            this.yearLabel3.Name = "yearLabel3";
            this.yearLabel3.Size = new System.Drawing.Size(100, 23);
            this.yearLabel3.TabIndex = 16;
            this.yearLabel3.Text = "label1";
            // 
            // nameLabel3
            // 
            this.nameLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "name", true));
            this.nameLabel3.Location = new System.Drawing.Point(447, 359);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(100, 23);
            this.nameLabel3.TabIndex = 12;
            this.nameLabel3.Text = "label1";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 611);
            this.Controls.Add(id_filmLabel2);
            this.Controls.Add(this.id_filmLabel3);
            this.Controls.Add(nameLabel2);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(posterLabel);
            this.Controls.Add(this.posterPictureBox);
            this.Controls.Add(yearLabel2);
            this.Controls.Add(this.yearLabel3);
            this.Controls.Add(urlLabel2);
            this.Controls.Add(this.urlLabel3);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorLabel1);
            this.Controls.Add(ganreLabel);
            this.Controls.Add(this.ganreLabel1);
            this.Controls.Add(this.filmsDataGridView);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private DataSet1TableAdapters.FilmsTableAdapter filmsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource filmsBindingSource1;
        private System.Windows.Forms.DataGridView filmsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label id_filmLabel3;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Label urlLabel3;
        private System.Windows.Forms.Label ganreLabel1;
        private System.Windows.Forms.Label directorLabel1;
        private System.Windows.Forms.Label yearLabel3;
        private System.Windows.Forms.Label nameLabel3;
    }
}