using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SellTicket : Form
    {
        public SellTicket()
        {
            InitializeComponent();
  
        }

        protected override void OnPaint(PaintEventArgs e)//фон
        {
            base.OnPaint(e);

            // Определение начального и конечного цветов градиента
            Color startColor = Color.PaleTurquoise;
            Color endColor = Color.LightCyan;

            // Создание градиентной заливки
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

            // Создание объекта графики для формы
            Graphics graphics = e.Graphics;

            // Настройка качества отрисовки
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Заливка фона формы градиентным цветом
            graphics.FillRectangle(gradientBrush, this.ClientRectangle);

            // Освобождение ресурсов
            gradientBrush.Dispose();
        }

        private void SellTicket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            //this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Места_и_ряды". При необходимости она может быть перемещена или удалена.
            this.места_и_рядыTableAdapter.Fill(this.кинотеатрDataSet.Места_и_ряды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.кинотеатрDataSet.Фильмы);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Места_и_ряды". При необходимости она может быть перемещена или удалена.
            //this.места_и_рядыTableAdapter.Fill(this.кинотеатрDataSet.Места_и_ряды);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Места_и_ряды". При необходимости она может быть перемещена или удалена.
            //this.места_и_рядыTableAdapter.Fill(this.кинотеатрDataSet.Места_и_ряды);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            //this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            //this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            //this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            //this.фильмыTableAdapter.Fill(this.кинотеатрDataSet.Фильмы);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            //this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            //this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            //this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            //this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            //this.фильмыTableAdapter.Fill(this.кинотеатрDataSet.Фильмы);

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранной строки
            if (dataGridView3.CurrentRow != null)
            {
                // Получение индекса текущей строки
                int rowIndex = dataGridView3.CurrentRow.Index;
                // При клике на ячейку получаем данные из выбранной строки
                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView3.Rows[rowIndex];
                    // Получение данных из TextBox'ов
                    string NewDate = maskedTextBox1.Text;
                    string NewTime = TimeBox.Text;
                    string NewHall = HallBox.Text;
                    string NewSeat = IdBox.Text;
                    string NewSeanse = SeanseBox.Text;
                    bool isSold = SoldOutBox.Checked;
                    // Изменение данных в таблице
                    кинотеатрDataSet.Tables["Билеты"].Rows[rowIndex]["Дата"] = NewDate;
                    кинотеатрDataSet.Tables["Билеты"].Rows[rowIndex]["Время"] = NewTime;
                    кинотеатрDataSet.Tables["Билеты"].Rows[rowIndex]["Зал"] = NewHall;
                    кинотеатрDataSet.Tables["Билеты"].Rows[rowIndex]["id места"] = NewSeat;
                    кинотеатрDataSet.Tables["Билеты"].Rows[rowIndex]["Продан"] = isSold;
                    кинотеатрDataSet.Tables["Билеты"].Rows[rowIndex]["Сеансы"] = NewSeanse;

                    // Обновление данных в базе данных
                    билетыTableAdapter.Update(кинотеатрDataSet.Билеты);//сохранение в базу данных

                    MessageBox.Show("Строка обновлена успешно.");
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dataGridView2.CurrentRow.Index;
            if (RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[RowIndex];
                string columnName6 = "ценаБилетаDataGridViewTextBoxColumn";
                string cellValue6 = selectedRow.Cells[columnName6].Value.ToString();
                PriceBox.Text = cellValue6;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];

                // Замените "Название фильма" на фактическое имя столбца
                string columnName = "датаDataGridViewTextBoxColumn1";
                string columnName1 = "времяDataGridViewTextBoxColumn1";
                string columnName2 = "залDataGridViewTextBoxColumn2";
                string columnName3 = "idМестаDataGridViewTextBoxColumn1";
                string columnName4 = "проданDataGridViewCheckBoxColumn";
                string columnName5 = "сеансыDataGridViewTextBoxColumn";
                // Проверяем, есть ли такой столбец в таблице
                // Получаем значение из выбранной строки и столбца
                string cellValue = selectedRow.Cells[columnName].Value.ToString();
                string cellValue1 = selectedRow.Cells[columnName1].Value.ToString();
                string cellValue2 = selectedRow.Cells[columnName2].Value.ToString();
                string cellValue3 = selectedRow.Cells[columnName3].Value.ToString();
                string cellValue4 = selectedRow.Cells[columnName4].Value.ToString();
                string cellValue5 = selectedRow.Cells[columnName5].Value.ToString();
                bool prov;
                bool.TryParse(cellValue4, out prov);
                // Устанавливаем значение в TextBox
                maskedTextBox1.Text = cellValue;
                TimeBox.Text = cellValue1;
                HallBox.Text = cellValue2;
                IdBox.Text = cellValue3;
                SoldOutBox.Checked = prov;
                SeanseBox.Text = cellValue5;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            NameHalltextBox.Clear();
        }

        private void NameHalltextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                RowtextBox.Focus();
            RowtextBox.Clear();
        }

        private void RowtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                NumSeattextBox.Focus();
            NumSeattextBox.Clear();
        }

        private void NumSeattextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                NameHalltextBox.Clear();
        }

        private void LearnID_Click(object sender, EventArgs e)
        {
            // Получаем значения из TextBox'ов
            string NameHall = NameHalltextBox.Text;
            int RowSe = Convert.ToInt32(RowtextBox.Text);
            int NumSeat = Convert.ToInt32(NumSeattextBox.Text);
            // Выполняем поиск с использованием LINQ
            DataRowView foundRow = местаИРядыBindingSource
                .OfType<DataRowView>()
                .FirstOrDefault(row =>
                    row.Row.Field<string>("Зал") == NameHall &&
                    row.Row.Field<int>("Ряд") == RowSe &&
                    row.Row.Field<int>("Место") == NumSeat);

            if (foundRow != null)
            {
                // Нашли совпадение, выводим ID места в Label
                label19.Text =  foundRow.Row.Field<int>("Id места").ToString();
            }
            else
            {
                // Не найдено совпадение
                label19.Text = "Место не найдено.";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            сеансыБилетыBindingSource.Filter = null;
        }

        private void exitToMAinbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main1 = new Main();
            main1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int searchedId;
            if (int.TryParse(textBox1.Text, out searchedId))
            {
                // Ищем строку с указанным id в DataSet
                DataRow[] rows = кинотеатрDataSet.Tables["Места и ряды"].Select($"[Id места] = {searchedId}");

                // Проверяем, найдена ли хотя бы одна строка
                if (rows.Length > 0)
                {
                    // Получаем значения из найденной строки
                    string hall = rows[0]["Зал"].ToString();
                    string row = rows[0]["Ряд"].ToString();
                    string seat = rows[0]["Место"].ToString();

                    // Выводим значения в Label
                    label16.Text = hall;
                    label17.Text = row;
                    label18.Text = seat;
                }
                else
                {
                    MessageBox.Show("Место с указанным ID не найдено.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID места.");
            }
        }

        private void RowtextBox_Click(object sender, EventArgs e)
        {
            RowtextBox.Clear();
        }

        private void NumSeattextBox_Click(object sender, EventArgs e)
        {
            NumSeattextBox.Clear();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
    }

