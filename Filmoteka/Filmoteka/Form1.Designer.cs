
namespace Filmoteka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_filmLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label urlLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label ganreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new Filmoteka.DataSet1();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Filmoteka.DataSet1TableAdapters.FilmsTableAdapter();
            this.tableAdapterManager = new Filmoteka.DataSet1TableAdapters.TableAdapterManager();
            this.filmsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filmsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_filmTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.ganreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.filmsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_filmLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            ganreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingNavigator)).BeginInit();
            this.filmsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_filmLabel
            // 
            id_filmLabel.AutoSize = true;
            id_filmLabel.Location = new System.Drawing.Point(16, 234);
            id_filmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_filmLabel.Name = "id_filmLabel";
            id_filmLabel.Size = new System.Drawing.Size(61, 13);
            id_filmLabel.TabIndex = 2;
            id_filmLabel.Text = "id фильма:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(16, 257);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(16, 280);
            yearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(74, 13);
            yearLabel.TabIndex = 6;
            yearLabel.Text = "Год выпуска:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(16, 302);
            urlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(116, 13);
            urlLabel.TabIndex = 8;
            urlLabel.Text = "Ссылка на просмотр:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(16, 325);
            directorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(61, 13);
            directorLabel.TabIndex = 10;
            directorLabel.Text = "Режиссер:";
            // 
            // ganreLabel
            // 
            ganreLabel.AutoSize = true;
            ganreLabel.Location = new System.Drawing.Point(16, 348);
            ganreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ganreLabel.Name = "ganreLabel";
            ganreLabel.Size = new System.Drawing.Size(39, 13);
            ganreLabel.TabIndex = 12;
            ganreLabel.Text = "Жанр:";
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
            // filmsBindingNavigator
            // 
            this.filmsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmsBindingNavigator.BindingSource = this.filmsBindingSource;
            this.filmsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.filmsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filmsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filmsBindingNavigatorSaveItem});
            this.filmsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.filmsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.filmsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.filmsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.filmsBindingNavigator.Name = "filmsBindingNavigator";
            this.filmsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.filmsBindingNavigator.Size = new System.Drawing.Size(730, 27);
            this.filmsBindingNavigator.TabIndex = 0;
            this.filmsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // filmsDataGridView
            // 
            this.filmsDataGridView.AutoGenerateColumns = false;
            this.filmsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.filmsDataGridView.Location = new System.Drawing.Point(9, 33);
            this.filmsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filmsDataGridView.Name = "filmsDataGridView";
            this.filmsDataGridView.RowHeadersWidth = 51;
            this.filmsDataGridView.RowTemplate.Height = 24;
            this.filmsDataGridView.Size = new System.Drawing.Size(703, 179);
            this.filmsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_film";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_film";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "poster";
            this.dataGridViewImageColumn1.HeaderText = "poster";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn3.HeaderText = "year";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "url";
            this.dataGridViewTextBoxColumn4.HeaderText = "url";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "director";
            this.dataGridViewTextBoxColumn5.HeaderText = "director";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ganre";
            this.dataGridViewTextBoxColumn6.HeaderText = "ganre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // id_filmTextBox
            // 
            this.id_filmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "id_film", true));
            this.id_filmTextBox.Location = new System.Drawing.Point(133, 234);
            this.id_filmTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_filmTextBox.Name = "id_filmTextBox";
            this.id_filmTextBox.Size = new System.Drawing.Size(312, 20);
            this.id_filmTextBox.TabIndex = 3;
            this.id_filmTextBox.TextChanged += new System.EventHandler(this.id_filmTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(133, 257);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(312, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(133, 280);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(312, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(133, 302);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(312, 20);
            this.urlTextBox.TabIndex = 9;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(133, 325);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(312, 20);
            this.directorTextBox.TabIndex = 11;
            // 
            // ganreTextBox
            // 
            this.ganreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "ganre", true));
            this.ganreTextBox.Location = new System.Drawing.Point(133, 348);
            this.ganreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ganreTextBox.Name = "ganreTextBox";
            this.ganreTextBox.Size = new System.Drawing.Size(312, 20);
            this.ganreTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 401);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 37);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // filmsBindingNavigatorSaveItem
            // 
            this.filmsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmsBindingNavigatorSaveItem.Image")));
            this.filmsBindingNavigatorSaveItem.Name = "filmsBindingNavigatorSaveItem";
            this.filmsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.filmsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.filmsBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmsBindingNavigatorSaveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 448);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_filmLabel);
            this.Controls.Add(this.id_filmTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(ganreLabel);
            this.Controls.Add(this.ganreTextBox);
            this.Controls.Add(this.filmsDataGridView);
            this.Controls.Add(this.filmsBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingNavigator)).EndInit();
            this.filmsBindingNavigator.ResumeLayout(false);
            this.filmsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private DataSet1TableAdapters.FilmsTableAdapter filmsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton filmsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_filmTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox ganreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

