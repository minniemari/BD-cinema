namespace WindowsFormsApp1
{
    partial class Seats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seats));
            this.EditTablebutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.exitToMAinbutton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idМестаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проданDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.сеансыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местаИРядыБилетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.местаИРядыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрDataSet = new WindowsFormsApp1.кинотеатрDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Editbutton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RowBox = new System.Windows.Forms.TextBox();
            this.SeatBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idМестаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рядDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBox11 = new System.Windows.Forms.ToolStripComboBox();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.места_и_рядыTableAdapter = new WindowsFormsApp1.кинотеатрDataSetTableAdapters.Места_и_рядыTableAdapter();
            this.билетыTableAdapter = new WindowsFormsApp1.кинотеатрDataSetTableAdapters.БилетыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местаИРядыБилетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местаИРядыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditTablebutton
            // 
            this.EditTablebutton.BackColor = System.Drawing.Color.Sienna;
            this.EditTablebutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTablebutton.ForeColor = System.Drawing.Color.Snow;
            this.EditTablebutton.Location = new System.Drawing.Point(293, 343);
            this.EditTablebutton.Name = "EditTablebutton";
            this.EditTablebutton.Size = new System.Drawing.Size(255, 27);
            this.EditTablebutton.TabIndex = 26;
            this.EditTablebutton.Text = "Внести изменения в таблицу";
            this.EditTablebutton.UseVisualStyleBackColor = false;
            this.EditTablebutton.Click += new System.EventHandler(this.EditTablebutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Sienna;
            this.Backbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Backbutton.Location = new System.Drawing.Point(293, 376);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(255, 28);
            this.Backbutton.TabIndex = 22;
            this.Backbutton.Text = "Вернуться назад ко всем таблицам";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // exitToMAinbutton
            // 
            this.exitToMAinbutton.BackColor = System.Drawing.Color.Sienna;
            this.exitToMAinbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToMAinbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToMAinbutton.Location = new System.Drawing.Point(293, 410);
            this.exitToMAinbutton.Name = "exitToMAinbutton";
            this.exitToMAinbutton.Size = new System.Drawing.Size(255, 28);
            this.exitToMAinbutton.TabIndex = 23;
            this.exitToMAinbutton.Text = "Вернуться в главное меню";
            this.exitToMAinbutton.UseVisualStyleBackColor = false;
            this.exitToMAinbutton.Click += new System.EventHandler(this.exitToMAinbutton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idБилетаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.залDataGridViewTextBoxColumn1,
            this.idМестаDataGridViewTextBoxColumn1,
            this.проданDataGridViewCheckBoxColumn,
            this.сеансыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.местаИРядыБилетыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(800, 132);
            this.dataGridView2.TabIndex = 25;
            // 
            // idБилетаDataGridViewTextBoxColumn
            // 
            this.idБилетаDataGridViewTextBoxColumn.DataPropertyName = "Id билета";
            this.idБилетаDataGridViewTextBoxColumn.HeaderText = "Id билета";
            this.idБилетаDataGridViewTextBoxColumn.Name = "idБилетаDataGridViewTextBoxColumn";
            this.idБилетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // залDataGridViewTextBoxColumn1
            // 
            this.залDataGridViewTextBoxColumn1.DataPropertyName = "Зал";
            this.залDataGridViewTextBoxColumn1.HeaderText = "Зал";
            this.залDataGridViewTextBoxColumn1.Name = "залDataGridViewTextBoxColumn1";
            this.залDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idМестаDataGridViewTextBoxColumn1
            // 
            this.idМестаDataGridViewTextBoxColumn1.DataPropertyName = "id места";
            this.idМестаDataGridViewTextBoxColumn1.HeaderText = "id места";
            this.idМестаDataGridViewTextBoxColumn1.Name = "idМестаDataGridViewTextBoxColumn1";
            this.idМестаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // проданDataGridViewCheckBoxColumn
            // 
            this.проданDataGridViewCheckBoxColumn.DataPropertyName = "Продан";
            this.проданDataGridViewCheckBoxColumn.HeaderText = "Продан";
            this.проданDataGridViewCheckBoxColumn.Name = "проданDataGridViewCheckBoxColumn";
            this.проданDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // сеансыDataGridViewTextBoxColumn
            // 
            this.сеансыDataGridViewTextBoxColumn.DataPropertyName = "Сеансы";
            this.сеансыDataGridViewTextBoxColumn.HeaderText = "Сеансы";
            this.сеансыDataGridViewTextBoxColumn.Name = "сеансыDataGridViewTextBoxColumn";
            this.сеансыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // местаИРядыБилетыBindingSource
            // 
            this.местаИРядыБилетыBindingSource.DataMember = "Места и рядыБилеты";
            this.местаИРядыБилетыBindingSource.DataSource = this.местаИРядыBindingSource;
            // 
            // местаИРядыBindingSource
            // 
            this.местаИРядыBindingSource.DataMember = "Места и ряды";
            this.местаИРядыBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.кинотеатрDataSet;
            this.bindingSource1.Position = 0;
            // 
            // кинотеатрDataSet
            // 
            this.кинотеатрDataSet.DataSetName = "кинотеатрDataSet";
            this.кинотеатрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Delbutton);
            this.panel2.Location = new System.Drawing.Point(550, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 261);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(21, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вернуться назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.BackColor = System.Drawing.Color.Sienna;
            this.Delbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delbutton.Location = new System.Drawing.Point(21, 6);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(220, 28);
            this.Delbutton.TabIndex = 14;
            this.Delbutton.Text = "Удалить выбранную строчку";
            this.Delbutton.UseVisualStyleBackColor = false;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Editbutton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.RowBox);
            this.panel1.Controls.Add(this.SeatBox);
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 261);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Sienna;
            this.Editbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.Color.Snow;
            this.Editbutton.Location = new System.Drawing.Point(125, 146);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(113, 27);
            this.Editbutton.TabIndex = 10;
            this.Editbutton.Text = "Изменить";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Sienna;
            this.AddButton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Snow;
            this.AddButton.Location = new System.Drawing.Point(6, 146);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 27);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите номер места";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите номер ряда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите наименование зала";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 36);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(168, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox1_KeyPress);
            // 
            // RowBox
            // 
            this.RowBox.Location = new System.Drawing.Point(6, 78);
            this.RowBox.Name = "RowBox";
            this.RowBox.Size = new System.Drawing.Size(168, 20);
            this.RowBox.TabIndex = 2;
            this.RowBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowBox_KeyPress);
            // 
            // SeatBox
            // 
            this.SeatBox.Location = new System.Drawing.Point(6, 120);
            this.SeatBox.Name = "SeatBox";
            this.SeatBox.Size = new System.Drawing.Size(168, 20);
            this.SeatBox.TabIndex = 3;
            this.SeatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeatBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idМестаDataGridViewTextBoxColumn,
            this.залDataGridViewTextBoxColumn,
            this.рядDataGridViewTextBoxColumn,
            this.местоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.местаИРядыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idМестаDataGridViewTextBoxColumn
            // 
            this.idМестаDataGridViewTextBoxColumn.DataPropertyName = "Id места";
            this.idМестаDataGridViewTextBoxColumn.HeaderText = "Id места";
            this.idМестаDataGridViewTextBoxColumn.Name = "idМестаDataGridViewTextBoxColumn";
            // 
            // залDataGridViewTextBoxColumn
            // 
            this.залDataGridViewTextBoxColumn.DataPropertyName = "Зал";
            this.залDataGridViewTextBoxColumn.HeaderText = "Зал";
            this.залDataGridViewTextBoxColumn.Name = "залDataGridViewTextBoxColumn";
            // 
            // рядDataGridViewTextBoxColumn
            // 
            this.рядDataGridViewTextBoxColumn.DataPropertyName = "Ряд";
            this.рядDataGridViewTextBoxColumn.HeaderText = "Ряд";
            this.рядDataGridViewTextBoxColumn.Name = "рядDataGridViewTextBoxColumn";
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComboBox11,
            this.SearchBox,
            this.buttonSearch,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "Поиск по";
            // 
            // ComboBox11
            // 
            this.ComboBox11.Name = "ComboBox11";
            this.ComboBox11.Size = new System.Drawing.Size(121, 25);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 25);
            // 
            // buttonSearch
            // 
            this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(23, 22);
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripButton1.Text = "Показать все";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(235, 22);
            this.toolStripButton2.Text = "Редактировать таблицу билетов";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // места_и_рядыTableAdapter
            // 
            this.места_и_рядыTableAdapter.ClearBeforeFill = true;
            // 
            // билетыTableAdapter
            // 
            this.билетыTableAdapter.ClearBeforeFill = true;
            // 
            // Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EditTablebutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.exitToMAinbutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Seats";
            this.Text = "Seats";
            this.Load += new System.EventHandler(this.Seats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местаИРядыБилетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местаИРядыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditTablebutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button exitToMAinbutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox RowBox;
        private System.Windows.Forms.TextBox SeatBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComboBox11;
        private System.Windows.Forms.ToolStripTextBox SearchBox;
        private System.Windows.Forms.ToolStripButton buttonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private кинотеатрDataSet кинотеатрDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource местаИРядыBindingSource;
        private кинотеатрDataSetTableAdapters.Места_и_рядыTableAdapter места_и_рядыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idМестаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn залDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рядDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource местаИРядыБилетыBindingSource;
        private кинотеатрDataSetTableAdapters.БилетыTableAdapter билетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn залDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idМестаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn проданDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сеансыDataGridViewTextBoxColumn;
    }
}