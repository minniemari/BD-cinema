namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back2button = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBox11 = new System.Windows.Forms.ToolStripComboBox();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.EditTablebutton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idСеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idФильмаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмыСеансыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрDataSet = new WindowsFormsApp1.кинотеатрDataSet();
            this.exitToMAinbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаПроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмыTableAdapter = new WindowsFormsApp1.кинотеатрDataSetTableAdapters.ФильмыTableAdapter();
            this.сеансыTableAdapter = new WindowsFormsApp1.кинотеатрDataSetTableAdapters.СеансыTableAdapter();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыСеансыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Back2button);
            this.panel2.Controls.Add(this.Delbutton);
            this.panel2.Location = new System.Drawing.Point(539, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 98);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // Back2button
            // 
            this.Back2button.BackColor = System.Drawing.Color.Sienna;
            this.Back2button.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back2button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back2button.Location = new System.Drawing.Point(26, 48);
            this.Back2button.Name = "Back2button";
            this.Back2button.Size = new System.Drawing.Size(220, 28);
            this.Back2button.TabIndex = 17;
            this.Back2button.Text = "Вернуться назад";
            this.Back2button.UseVisualStyleBackColor = false;
            this.Back2button.Click += new System.EventHandler(this.Back2button_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.BackColor = System.Drawing.Color.Sienna;
            this.Delbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delbutton.Location = new System.Drawing.Point(26, 14);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(220, 28);
            this.Delbutton.TabIndex = 9;
            this.Delbutton.Text = "Удалить выбранную строчку";
            this.Delbutton.UseVisualStyleBackColor = false;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Sienna;
            this.Backbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Backbutton.Location = new System.Drawing.Point(565, 385);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(220, 28);
            this.Backbutton.TabIndex = 24;
            this.Backbutton.Text = "Вернуться ко всем таблицам ";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Sienna;
            this.Editbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.Color.Snow;
            this.Editbutton.Location = new System.Drawing.Point(125, 216);
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
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите страну производства фильма";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Sienna;
            this.AddButton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Snow;
            this.AddButton.Location = new System.Drawing.Point(6, 216);
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
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите год выпуска фильма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите жанр фильма";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComboBox11,
            this.SearchBox,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 29;
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
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
//            this.SearchBox.Click += new System.EventHandler(this.buttonSearch_Click_1);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
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
            this.toolStripButton2.Size = new System.Drawing.Size(233, 22);
            this.toolStripButton2.Text = "Редактировать таблицу сеансов";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // EditTablebutton
            // 
            this.EditTablebutton.BackColor = System.Drawing.Color.Sienna;
            this.EditTablebutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTablebutton.ForeColor = System.Drawing.Color.Snow;
            this.EditTablebutton.Location = new System.Drawing.Point(565, 352);
            this.EditTablebutton.Name = "EditTablebutton";
            this.EditTablebutton.Size = new System.Drawing.Size(220, 27);
            this.EditTablebutton.TabIndex = 25;
            this.EditTablebutton.Text = "Внести изменения в таблицу";
            this.EditTablebutton.UseVisualStyleBackColor = false;
            this.EditTablebutton.Click += new System.EventHandler(this.EditTablebutton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСеансаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.залDataGridViewTextBoxColumn,
            this.idФильмаDataGridViewTextBoxColumn1,
            this.ценаБилетаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.фильмыСеансыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 203);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 140);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // idФильмаDataGridViewTextBoxColumn1
            // 
            this.idФильмаDataGridViewTextBoxColumn1.DataPropertyName = "Id фильма";
            this.idФильмаDataGridViewTextBoxColumn1.HeaderText = "Id фильма";
            this.idФильмаDataGridViewTextBoxColumn1.Name = "idФильмаDataGridViewTextBoxColumn1";
            // 
            // ценаБилетаDataGridViewTextBoxColumn
            // 
            this.ценаБилетаDataGridViewTextBoxColumn.DataPropertyName = "цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.HeaderText = "цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.Name = "ценаБилетаDataGridViewTextBoxColumn";
            // 
            // фильмыСеансыBindingSource
            // 
            this.фильмыСеансыBindingSource.DataMember = "ФильмыСеансы";
            this.фильмыСеансыBindingSource.DataSource = this.фильмыBindingSource;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.bindingSource1;
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
            // exitToMAinbutton
            // 
            this.exitToMAinbutton.BackColor = System.Drawing.Color.Sienna;
            this.exitToMAinbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToMAinbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToMAinbutton.Location = new System.Drawing.Point(565, 418);
            this.exitToMAinbutton.Name = "exitToMAinbutton";
            this.exitToMAinbutton.Size = new System.Drawing.Size(220, 28);
            this.exitToMAinbutton.TabIndex = 26;
            this.exitToMAinbutton.Text = "Вернуться в главное меню";
            this.exitToMAinbutton.UseVisualStyleBackColor = false;
            this.exitToMAinbutton.Click += new System.EventHandler(this.exitToMAinbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите длительность фильма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите название фильма";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Editbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.DurationBox);
            this.panel1.Controls.Add(this.CountryBox);
            this.panel1.Controls.Add(this.GenreBox);
            this.panel1.Controls.Add(this.YearBox);
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 247);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(168, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(6, 64);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(168, 20);
            this.DurationBox.TabIndex = 2;
            this.DurationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationBox_KeyPress);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(6, 190);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(168, 20);
            this.CountryBox.TabIndex = 5;
            this.CountryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryBox_KeyPress);
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(6, 101);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(168, 20);
            this.GenreBox.TabIndex = 3;
            this.GenreBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenreBox_KeyPress);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(6, 143);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(168, 20);
            this.YearBox.TabIndex = 4;
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idФильмаDataGridViewTextBoxColumn,
            this.названиеФильмаDataGridViewTextBoxColumn,
            this.длительностьDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.странаПроизводстваDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фильмыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 174);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idФильмаDataGridViewTextBoxColumn
            // 
            this.idФильмаDataGridViewTextBoxColumn.DataPropertyName = "Id фильма";
            this.idФильмаDataGridViewTextBoxColumn.HeaderText = "Id фильма";
            this.idФильмаDataGridViewTextBoxColumn.Name = "idФильмаDataGridViewTextBoxColumn";
            // 
            // названиеФильмаDataGridViewTextBoxColumn
            // 
            this.названиеФильмаDataGridViewTextBoxColumn.DataPropertyName = "Название фильма";
            this.названиеФильмаDataGridViewTextBoxColumn.HeaderText = "Название фильма";
            this.названиеФильмаDataGridViewTextBoxColumn.Name = "названиеФильмаDataGridViewTextBoxColumn";
            // 
            // длительностьDataGridViewTextBoxColumn
            // 
            this.длительностьDataGridViewTextBoxColumn.DataPropertyName = "Длительность";
            this.длительностьDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.длительностьDataGridViewTextBoxColumn.Name = "длительностьDataGridViewTextBoxColumn";
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            // 
            // странаПроизводстваDataGridViewTextBoxColumn
            // 
            this.странаПроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Страна производства";
            this.странаПроизводстваDataGridViewTextBoxColumn.HeaderText = "Страна производства";
            this.странаПроизводстваDataGridViewTextBoxColumn.Name = "странаПроизводстваDataGridViewTextBoxColumn";
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // сеансыTableAdapter
            // 
            this.сеансыTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EditTablebutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.exitToMAinbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыСеансыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back2button;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComboBox11;
        private System.Windows.Forms.ToolStripTextBox SearchBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button EditTablebutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button exitToMAinbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private кинотеатрDataSet кинотеатрDataSet;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private кинотеатрDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаПроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource фильмыСеансыBindingSource;
        private кинотеатрDataSetTableAdapters.СеансыTableAdapter сеансыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn залDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idФильмаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаБилетаDataGridViewTextBoxColumn;
    }
}

