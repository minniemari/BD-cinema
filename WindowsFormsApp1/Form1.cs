using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Заполнение ComboBox именами столбцов
            ComboBox11.Items.Add("Id фильма");
            ComboBox11.Items.Add("Название фильма");
            ComboBox11.Items.Add("Длительность");
            ComboBox11.Items.Add("Жанр");
            ComboBox11.Items.Add("Год выпуска");
            ComboBox11.Items.Add("Страна производства");
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
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.кинотеатрDataSet.Фильмы);

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            фильмыTableAdapter.Update(кинотеатрDataSet.Фильмы);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                DurationBox.Focus();
        }

        private void DurationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                GenreBox.Focus();
        }

        private void GenreBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                YearBox.Focus();
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
                CountryBox.Focus();
        }

        private void CountryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                NameBox.Focus();
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentCell.RowIndex;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentCell.RowIndex;
            // Проверяем, что индекс столбца соответствует столбцу, который вы хотите изменить
            if (e.ColumnIndex == row)
            {
                // Получаем данные из измененной ячейки
                var newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Получаем значение ключевого столбца (если есть) для определения строки
                var keyColumnValue = dataGridView1.Rows[e.RowIndex].Cells[row].Value.ToString();

                // Обновляем данные в базе данных
                UpdateDatabase(keyColumnValue, newValue);
            }
        }

        private void UpdateDatabase(string keyColumnValue, string newValue)
        {
            // Ваш код для обновления данных в базе данных
            // Используйте SQL-запрос или ORM (Object-Relational Mapping) для выполнения обновления
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.AddNew();
            DataRowView newRowView = (DataRowView)фильмыBindingSource.Current;
            // Заполните значениями из TextBox'ов или других источников данных
            newRowView["Название фильма"] = NameBox.Text;
            newRowView["Длительность"] = DurationBox.Text;
            newRowView["Жанр"] = GenreBox.Text;
            newRowView["Год выпуска"] = YearBox.Text;
            newRowView["Страна производства"] = CountryBox.Text;
            // Завершите добавление новой записи
            фильмыBindingSource.EndEdit();
            фильмыTableAdapter.Update(this.кинотеатрDataSet.Фильмы);//сохранение в базу данных
            this.фильмыTableAdapter.Fill(this.кинотеатрDataSet.Фильмы);

        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (фильмыBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    фильмыBindingSource.RemoveCurrent();
                    фильмыTableAdapter.Update(кинотеатрDataSet.Фильмы);//сохранение в базу данных
                }
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранной строки
            if (dataGridView1.CurrentRow != null)
            {
                // Получение индекса текущей строки
                int rowIndex = dataGridView1.CurrentRow.Index;

                // Получение данных из TextBox'ов
                string newCinemaName = NameBox.Text;
                string newDuration = DurationBox.Text;
                string newGenre = GenreBox.Text;
                string newYear = YearBox.Text;
                string newCountry = CountryBox.Text;
                // Изменение данных в DataTable
                кинотеатрDataSet.Tables["Фильмы"].Rows[rowIndex]["Название фильма"] = newCinemaName;
                кинотеатрDataSet.Tables["Фильмы"].Rows[rowIndex]["Длительность"] = newDuration;
                кинотеатрDataSet.Tables["Фильмы"].Rows[rowIndex]["Жанр"] = newGenre;
                кинотеатрDataSet.Tables["Фильмы"].Rows[rowIndex]["Год выпуска"] = newYear;
                кинотеатрDataSet.Tables["Фильмы"].Rows[rowIndex]["Страна производства"] = newCountry;

                // Обновление данных в базе данных
                фильмыTableAdapter.Update(кинотеатрDataSet.Фильмы);//сохранение в базу данных

                MessageBox.Show("Строка обновлена успешно.");
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new AllTables();
            dlg.ShowDialog();
        }

        private void exitToMAinbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main1 = new Main();
            main1.ShowDialog();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Замените "Название фильма" на фактическое имя столбца
                string columnName = "названиеФильмаDataGridViewTextBoxColumn";
                string columnName1 = "длительностьDataGridViewTextBoxColumn";
                string columnName2 = "жанрDataGridViewTextBoxColumn";
                string columnName3 = "годВыпускаDataGridViewTextBoxColumn";
                string columnName5 = "странаПроизводстваDataGridViewTextBoxColumn";
                // Проверяем, есть ли такой столбец в таблице
                // Получаем значение из выбранной строки и столбца
                string cellValue = selectedRow.Cells[columnName].Value.ToString();
                string cellValue1 = selectedRow.Cells[columnName1].Value.ToString();
                string cellValue2 = selectedRow.Cells[columnName2].Value.ToString();
                string cellValue3 = selectedRow.Cells[columnName3].Value.ToString();
                string cellValue5 = selectedRow.Cells[columnName5].Value.ToString();
                // Устанавливаем значение в TextBox
                NameBox.Text = cellValue;
                DurationBox.Text = cellValue1;
                GenreBox.Text = cellValue2;
                YearBox.Text = cellValue3;
                CountryBox.Text = cellValue5;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Проверяем, есть ли выбранная строка
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Получаем значение ключевого столбца (замените "ID" на имя вашего ключевого столбца)
                int keyValue = Convert.ToInt32(selectedRow.Cells["idФильмаDataGridViewTextBoxColumn"].Value);
            }
        }

        private void EditTablebutton_Click(object sender, EventArgs e)
        {

            dataGridView2.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            EditTablebutton.Visible = false;
            Backbutton.Visible = false;
            exitToMAinbutton.Visible = false;
        }

        private void Back2button_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            EditTablebutton.Visible = true;
            Backbutton.Visible = true;
            exitToMAinbutton.Visible = true;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            фильмыBindingSource.Filter = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new Seanses();
            dlg.ShowDialog();
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                NameBox.Focus();
            {
                // Проверка, выбран ли столбец в ComboBox
                if (ComboBox11.SelectedItem != null)
                {
                    // Получение имени столбца из ComboBox
                    string selectedColumn = ComboBox11.SelectedItem.ToString();
                    string filterExpression = "";
                    // Получение значения из TextBox
                    string searchText = SearchBox.Text;
                    if (selectedColumn == "Год выпуска" | selectedColumn == "Id фильма")
                    {
                        filterExpression = $"CONVERT([{selectedColumn}], 'System.String') = '{searchText}'";
                        фильмыBindingSource.Filter = filterExpression;
                    }
                    else
                    {
                        // Формирование строки фильтрации
                        filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                        фильмыBindingSource.Filter = filterExpression;
                    }
                }
                else
                {
                    //Если столбец не выбран, сброс фильтрации
                    фильмыBindingSource.RemoveFilter();
                }
            }
        }
    }
}
