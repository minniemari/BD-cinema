namespace WindowsFormsApp1
{
    partial class Seanses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seanses));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idМестаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проданDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.сеансыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеансыБилетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сеансыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрDataSet = new WindowsFormsApp1.кинотеатрDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBox11 = new System.Windows.Forms.ToolStripComboBox();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.EditTablebutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.exitToMAinbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back2button = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Editbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.HallBox = new System.Windows.Forms.TextBox();
            this.MovieBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idСеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеансыTableAdapter = new WindowsFormsApp1.кинотеатрDataSetTableAdapters.СеансыTableAdapter();
            this.билетыTableAdapter = new WindowsFormsApp1.кинотеатрDataSetTableAdapters.БилетыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансыБилетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.датаDataGridViewTextBoxColumn1,
            this.времяDataGridViewTextBoxColumn1,
            this.залDataGridViewTextBoxColumn1,
            this.idМестаDataGridViewTextBoxColumn,
            this.проданDataGridViewCheckBoxColumn,
            this.сеансыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.сеансыБилетыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(800, 150);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idБилетаDataGridViewTextBoxColumn
            // 
            this.idБилетаDataGridViewTextBoxColumn.DataPropertyName = "Id билета";
            this.idБилетаDataGridViewTextBoxColumn.HeaderText = "Id билета";
            this.idБилетаDataGridViewTextBoxColumn.Name = "idБилетаDataGridViewTextBoxColumn";
            this.idБилетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn1
            // 
            this.датаDataGridViewTextBoxColumn1.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn1.Name = "датаDataGridViewTextBoxColumn1";
            this.датаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // времяDataGridViewTextBoxColumn1
            // 
            this.времяDataGridViewTextBoxColumn1.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn1.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn1.Name = "времяDataGridViewTextBoxColumn1";
            this.времяDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // залDataGridViewTextBoxColumn1
            // 
            this.залDataGridViewTextBoxColumn1.DataPropertyName = "Зал";
            this.залDataGridViewTextBoxColumn1.HeaderText = "Зал";
            this.залDataGridViewTextBoxColumn1.Name = "залDataGridViewTextBoxColumn1";
            this.залDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idМестаDataGridViewTextBoxColumn
            // 
            this.idМестаDataGridViewTextBoxColumn.DataPropertyName = "id места";
            this.idМестаDataGridViewTextBoxColumn.HeaderText = "id места";
            this.idМестаDataGridViewTextBoxColumn.Name = "idМестаDataGridViewTextBoxColumn";
            this.idМестаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // сеансыБилетыBindingSource
            // 
            this.сеансыБилетыBindingSource.DataMember = "СеансыБилеты";
            this.сеансыБилетыBindingSource.DataSource = this.сеансыBindingSource;
            // 
            // сеансыBindingSource
            // 
            this.сеансыBindingSource.DataMember = "Сеансы";
            this.сеансыBindingSource.DataSource = this.bindingSource1;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComboBox11,
            this.SearchBox,
            this.buttonSearch,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 26;
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
            this.toolStripButton1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton1.Text = "Показать все";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(180, 22);
            this.toolStripButton2.Text = "Редактировать таблицу билетов";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(172, 22);
            this.toolStripButton3.Text = "Вернуться к таблице фильмов";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // EditTablebutton
            // 
            this.EditTablebutton.BackColor = System.Drawing.Color.Sienna;
            this.EditTablebutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTablebutton.ForeColor = System.Drawing.Color.Snow;
            this.EditTablebutton.Location = new System.Drawing.Point(284, 355);
            this.EditTablebutton.Name = "EditTablebutton";
            this.EditTablebutton.Size = new System.Drawing.Size(255, 27);
            this.EditTablebutton.TabIndex = 24;
            this.EditTablebutton.Text = "Внести изменения в таблицу";
            this.EditTablebutton.UseVisualStyleBackColor = false;
            this.EditTablebutton.Click += new System.EventHandler(this.EditTablebutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Sienna;
            this.Backbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Backbutton.Location = new System.Drawing.Point(284, 388);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(255, 28);
            this.Backbutton.TabIndex = 23;
            this.Backbutton.Text = "Вернуться назад ко всем таблицам";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // exitToMAinbutton
            // 
            this.exitToMAinbutton.BackColor = System.Drawing.Color.Sienna;
            this.exitToMAinbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToMAinbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToMAinbutton.Location = new System.Drawing.Point(284, 422);
            this.exitToMAinbutton.Name = "exitToMAinbutton";
            this.exitToMAinbutton.Size = new System.Drawing.Size(255, 28);
            this.exitToMAinbutton.TabIndex = 25;
            this.exitToMAinbutton.Text = "Вернуться в главное меню";
            this.exitToMAinbutton.UseVisualStyleBackColor = false;
            this.exitToMAinbutton.Click += new System.EventHandler(this.exitToMAinbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Back2button);
            this.panel2.Controls.Add(this.Delbutton);
            this.panel2.Location = new System.Drawing.Point(556, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 264);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // Back2button
            // 
            this.Back2button.BackColor = System.Drawing.Color.Sienna;
            this.Back2button.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back2button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back2button.Location = new System.Drawing.Point(21, 40);
            this.Back2button.Name = "Back2button";
            this.Back2button.Size = new System.Drawing.Size(220, 28);
            this.Back2button.TabIndex = 18;
            this.Back2button.Text = "Вернуться назад";
            this.Back2button.UseVisualStyleBackColor = false;
            this.Back2button.Click += new System.EventHandler(this.Back2button_Click);
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
            this.panel1.Controls.Add(this.TimeBox);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.Editbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PriceBox);
            this.panel1.Controls.Add(this.HallBox);
            this.panel1.Controls.Add(this.MovieBox);
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 264);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(6, 78);
            this.TimeBox.Mask = "00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(168, 20);
            this.TimeBox.TabIndex = 12;
            this.TimeBox.ValidatingType = typeof(System.DateTime);
            this.TimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeBox_KeyPress);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 36);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(168, 20);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Sienna;
            this.Editbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.Color.Snow;
            this.Editbutton.Location = new System.Drawing.Point(125, 230);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(113, 27);
            this.Editbutton.TabIndex = 10;
            this.Editbutton.Text = "Изменить";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите цену билета";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Sienna;
            this.AddButton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Snow;
            this.AddButton.Location = new System.Drawing.Point(6, 230);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 27);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите id фильма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите зал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите время начала сеанса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите дату";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(6, 204);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(168, 20);
            this.PriceBox.TabIndex = 5;
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // HallBox
            // 
            this.HallBox.Location = new System.Drawing.Point(6, 120);
            this.HallBox.Name = "HallBox";
            this.HallBox.Size = new System.Drawing.Size(168, 20);
            this.HallBox.TabIndex = 3;
            this.HallBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HallBox_KeyPress);
            // 
            // MovieBox
            // 
            this.MovieBox.Location = new System.Drawing.Point(6, 162);
            this.MovieBox.Name = "MovieBox";
            this.MovieBox.Size = new System.Drawing.Size(168, 20);
            this.MovieBox.TabIndex = 4;
            this.MovieBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MovieBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСеансаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.залDataGridViewTextBoxColumn,
            this.idФильмаDataGridViewTextBoxColumn,
            this.ценаБилетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сеансыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idСеансаDataGridViewTextBoxColumn
            // 
            this.idСеансаDataGridViewTextBoxColumn.DataPropertyName = "Id сеанса";
            this.idСеансаDataGridViewTextBoxColumn.HeaderText = "Id сеанса";
            this.idСеансаDataGridViewTextBoxColumn.Name = "idСеансаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // залDataGridViewTextBoxColumn
            // 
            this.залDataGridViewTextBoxColumn.DataPropertyName = "Зал";
            this.залDataGridViewTextBoxColumn.HeaderText = "Зал";
            this.залDataGridViewTextBoxColumn.Name = "залDataGridViewTextBoxColumn";
            // 
            // idФильмаDataGridViewTextBoxColumn
            // 
            this.idФильмаDataGridViewTextBoxColumn.DataPropertyName = "Id фильма";
            this.idФильмаDataGridViewTextBoxColumn.HeaderText = "Id фильма";
            this.idФильмаDataGridViewTextBoxColumn.Name = "idФильмаDataGridViewTextBoxColumn";
            // 
            // ценаБилетаDataGridViewTextBoxColumn
            // 
            this.ценаБилетаDataGridViewTextBoxColumn.DataPropertyName = "цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.HeaderText = "цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.Name = "ценаБилетаDataGridViewTextBoxColumn";
            // 
            // сеансыTableAdapter
            // 
            this.сеансыTableAdapter.ClearBeforeFill = true;
            // 
            // билетыTableAdapter
            // 
            this.билетыTableAdapter.ClearBeforeFill = true;
            // 
            // Seanses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EditTablebutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.exitToMAinbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Seanses";
            this.Text = "Seanses";
            this.Load += new System.EventHandler(this.Seanses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансыБилетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComboBox11;
        private System.Windows.Forms.ToolStripTextBox SearchBox;
        private System.Windows.Forms.ToolStripButton buttonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button EditTablebutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button exitToMAinbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back2button;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TimeBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox HallBox;
        private System.Windows.Forms.TextBox MovieBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private кинотеатрDataSet кинотеатрDataSet;
        private System.Windows.Forms.BindingSource сеансыBindingSource;
        private кинотеатрDataSetTableAdapters.СеансыTableAdapter сеансыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn залDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сеансыБилетыBindingSource;
        private кинотеатрDataSetTableAdapters.БилетыTableAdapter билетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn залDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idМестаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn проданDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сеансыDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}