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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class Seanses : Form
    {
        public Seanses()
        {
            InitializeComponent();
            ComboBox11.Items.Add("Id сеанса");
            ComboBox11.Items.Add("Дата");
            ComboBox11.Items.Add("Время");
            ComboBox11.Items.Add("Зал");
            ComboBox11.Items.Add("Id фильма");
            ComboBox11.Items.Add("Цена билета");
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

        private void Seanses_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            сеансыBindingSource.AddNew();
            DataRowView newRowView = (DataRowView)сеансыBindingSource.Current;
            // Заполните значениями из TextBox'ов или других источников данных
            newRowView["Дата"] = maskedTextBox1.Text;
            newRowView["Время"] = TimeBox.Text;
            newRowView["Зал"] = HallBox.Text;
            newRowView["Id фильма"] = MovieBox.Text;
            newRowView["Цена билета"] = PriceBox.Text;
            // Завершите добавление новой записи
            сеансыBindingSource.EndEdit();
            сеансыTableAdapter.Update(кинотеатрDataSet.Сеансы);//сохранение в базу данных
            this.сеансыTableAdapter.Fill(this.кинотеатрDataSet.Сеансы);
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
                    string NewMovie = MovieBox.Text;
                    string NewPrice = PriceBox.Text;
                    // Изменение данных в таблице
                    кинотеатрDataSet.Tables["Сеансы"].Rows[rowIndex]["Дата"] = NewDate;
                    кинотеатрDataSet.Tables["Сеансы"].Rows[rowIndex]["Время"] = NewTime;
                    кинотеатрDataSet.Tables["Сеансы"].Rows[rowIndex]["Зал"] = NewHall;
                    кинотеатрDataSet.Tables["Сеансы"].Rows[rowIndex]["Id фильма"] = NewMovie;
                    кинотеатрDataSet.Tables["Сеансы"].Rows[rowIndex]["Цена билета"] = NewPrice;

                    // Обновление данных в базе данных
                    сеансыTableAdapter.Update(кинотеатрDataSet.Сеансы);//сохранение в базу данных

                    MessageBox.Show("Строка обновлена успешно.");
                }
            }
        }
        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (сеансыBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    сеансыBindingSource.RemoveCurrent();
                    сеансыTableAdapter.Update(кинотеатрDataSet.Сеансы);//сохранение в базу данных
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

                string columnName = "датаDataGridViewTextBoxColumn";
                string columnName1 = "времяDataGridViewTextBoxColumn";
                string columnName2 = "залDataGridViewTextBoxColumn";
                string columnName3 = "idФильмаDataGridViewTextBoxColumn";
                string columnName4 = "ценаБилетаDataGridViewTextBoxColumn";
                // Проверяем, есть ли такой столбец в таблице
                // Получаем значение из выбранной строки и столбца
                string cellValue = selectedRow.Cells[columnName].Value.ToString();
                string cellValue1 = selectedRow.Cells[columnName1].Value.ToString();
                string cellValue2 = selectedRow.Cells[columnName2].Value.ToString();
                string cellValue3 = selectedRow.Cells[columnName3].Value.ToString();
                string cellValue4 = selectedRow.Cells[columnName4].Value.ToString();

                // Устанавливаем значение в TextBox
                maskedTextBox1.Text = cellValue;
                TimeBox.Text = cellValue1;
                HallBox.Text = cellValue2;
                MovieBox.Text = cellValue3;
                PriceBox.Text = cellValue4;
            }
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
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
                MovieBox.Focus();
        }

        private void MovieBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                PriceBox.Focus();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new Tickets();
            dlg.ShowDialog();
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
                if (selectedColumn == "Дата")
                {
                    DateTime searchDate;
                    if (DateTime.TryParse(searchText, out searchDate))
                    {
                        filterExpression = $"CONVERT([{selectedColumn}], 'System.DateTime') = #{searchDate.ToString("MM/dd/yyyy")}#";
                        сеансыBindingSource.Filter = filterExpression;
                    }
                    else
                    {
                        // Обработка ошибки ввода даты
                        MessageBox.Show("Некорректный формат даты.");
                    }
                }
                else if (selectedColumn == "Id сеанса" | selectedColumn == "Id фильма" | selectedColumn == "цена билета")
                {
                    filterExpression = $"CONVERT([{selectedColumn}], 'System.String') = '{searchText}'";
                }
                else
                {
                    // Формирование строки фильтрации
                    filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                }
                // Применение фильтра
                сеансыBindingSource.Filter = filterExpression;
            }
            else
            {
                //Если столбец не выбран, сброс фильтрации
                сеансыBindingSource.RemoveFilter();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            сеансыBindingSource.Filter = null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new Form1();
            dlg.ShowDialog();
        }
    }
}
