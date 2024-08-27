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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
            ComboBox11.Items.Add("Id билета");
            ComboBox11.Items.Add("Дата");
            ComboBox11.Items.Add("Время");
            ComboBox11.Items.Add("Зал");
            ComboBox11.Items.Add("Продан");
            ComboBox11.Items.Add("Сеансы");
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            билетыBindingSource.AddNew();
            DataRowView newRowView = (DataRowView)билетыBindingSource.Current;
            // Заполните значениями из TextBox'ов или других источников данных
            newRowView["Дата"] = maskedTextBox1.Text;
            newRowView["Время"] = TimeBox.Text;
            newRowView["Зал"] = HallBox.Text;
            newRowView["id места"] = IdBox.Text;
            newRowView["Продан"] = SoldOutBox.Checked;
            newRowView["Сеансы"] = SeanseBox.Text;
            // Завершите добавление новой записи
            билетыBindingSource.EndEdit();
            билетыTableAdapter.Update(кинотеатрDataSet.Билеты);//сохранение в базу данных
            this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранной строки
            if (dataGridView1.CurrentRow != null)
            {
                // Получение индекса текущей строки
                int rowIndex = dataGridView1.CurrentRow.Index;
                // При клике на ячейку получаем данные из выбранной строки
                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

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
        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (билетыBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    билетыBindingSource.RemoveCurrent();
                    билетыTableAdapter.Update(кинотеатрDataSet.Билеты);//сохранение в базу данных
                }
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
                string columnName = "датаDataGridViewTextBoxColumn";
                string columnName1 = "времяDataGridViewTextBoxColumn";
                string columnName2 = "залDataGridViewTextBoxColumn";
                string columnName3 = "idМестаDataGridViewTextBoxColumn";
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

        private void SeanseBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
                maskedTextBox1.Focus();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                TimeBox.Focus();
        }

        private void TimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                HallBox.Focus();
        }

        private void HallBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                IdBox.Focus();
        }

        private void IdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SeanseBox.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Проверка, выбран ли столбец в ComboBox
            if (ComboBox11.SelectedItem != null)
            {
                // Получение имени столбца из ComboBox
                string selectedColumn = ComboBox11.SelectedItem.ToString();
                string filterExpression = "";
                // Получение значения из TextBox
                string searchText = SearchBox.Text;
                if (selectedColumn == "Продан")
                {
                    string searchText1 = SearchBox.Text.Trim().ToLower(); // Приведение к нижнему регистру

                    // Проверка, что введено "true" или "false"
                    if (searchText1 == "true" || searchText1 == "false" || searchText1 == "продан" || searchText1 == "не продан")
                    {
                        if (searchText1 == "продан")
                        {
                            string searchtext2 = "true";
                            searchText = searchtext2;
                        }
                        if (searchText1 == "не продан")
                        {
                            string searchtext3 = "false";
                            searchText = searchtext3;
                        }
                        // Преобразование введенного текста в логическое значение
                        bool searchValue = Convert.ToBoolean(searchText);
                        // Формирование строки фильтрации для логического поля
                        filterExpression = $"[{selectedColumn}] = {searchValue}";

                        // Применение фильтра
                        билетыBindingSource.Filter = filterExpression;
                    }
                }
                else if (selectedColumn=="Дата")
                {
                    DateTime searchDate;
                    if (DateTime.TryParse(searchText, out searchDate))
                    {
                        filterExpression = $"CONVERT([{selectedColumn}], 'System.DateTime') = #{searchDate.ToString("MM/dd/yyyy")}#";
                        билетыBindingSource.Filter = filterExpression;
                    }
                    else
                    {
                        // Обработка ошибки ввода даты
                        MessageBox.Show("Некорректный формат даты.");
                    }
                }
                else if (selectedColumn == "Id билета" | selectedColumn == "id места" | selectedColumn == "Сеансы")
                {
                    filterExpression = $"CONVERT([{selectedColumn}], 'System.String') = '{searchText}'";
                    билетыBindingSource.Filter = filterExpression;
                }
                else
                {
                    // Формирование строки фильтрации
                    filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                    билетыBindingSource.Filter = filterExpression;
                }
                // Применение фильтра
                //билетыBindingSource.Filter = filterExpression;
            }
            else
            {
                //Если столбец не выбран, сброс фильтрации
                билетыBindingSource.RemoveFilter();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            билетыBindingSource.Filter = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tabl = new Seanses();
            tabl.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tabls = new Seats();
            tabls.ShowDialog();
        }
    }
}
