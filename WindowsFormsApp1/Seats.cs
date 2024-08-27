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
    public partial class Seats : Form
    {
        public Seats()
        {
            InitializeComponent();
            ComboBox11.Items.Add("Id места"); 
            ComboBox11.Items.Add("Зал");
            ComboBox11.Items.Add("Ряд");
            ComboBox11.Items.Add("Место");
        }

        private void Seats_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Места_и_ряды". При необходимости она может быть перемещена или удалена.
            this.места_и_рядыTableAdapter.Fill(this.кинотеатрDataSet.Места_и_ряды);

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
            местаИРядыBindingSource.AddNew();
            DataRowView newRowView = (DataRowView)местаИРядыBindingSource.Current;
            // Заполните значениями из TextBox'ов или других источников данных
            newRowView["Зал"] = NameBox.Text;
            newRowView["Ряд"] = RowBox.Text;
            newRowView["Место"] = SeatBox.Text;
            // Завершите добавление новой записи
            местаИРядыBindingSource.EndEdit();
            места_и_рядыTableAdapter.Update(кинотеатрDataSet.Места_и_ряды);//сохранение в базу данных
            this.места_и_рядыTableAdapter.Fill(this.кинотеатрDataSet.Места_и_ряды);
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
                    string NewName = NameBox.Text;
                    string NewRow = RowBox.Text;
                    string NewSeat = SeatBox.Text;
                    // Изменение данных в таблице
                    кинотеатрDataSet.Tables["Места и ряды"].Rows[rowIndex]["Зал"] = NewName;
                    кинотеатрDataSet.Tables["Места и ряды"].Rows[rowIndex]["Ряд"] = NewRow;
                    кинотеатрDataSet.Tables["Места и ряды"].Rows[rowIndex]["Место"] = NewSeat;

                    // Обновление данных в базе данных
                    места_и_рядыTableAdapter.Update(кинотеатрDataSet.Места_и_ряды);//сохранение в базу данных

                    MessageBox.Show("Строка обновлена успешно.");
                }
            }
        }
        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (местаИРядыBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    местаИРядыBindingSource.RemoveCurrent();
                    места_и_рядыTableAdapter.Update(кинотеатрDataSet.Места_и_ряды);//сохранение в базу данных
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
                string columnName = "залDataGridViewTextBoxColumn";
                string columnName1 = "рядDataGridViewTextBoxColumn";
                string columnName2 = "местоDataGridViewTextBoxColumn";
                // Проверяем, есть ли такой столбец в таблице
                // Получаем значение из выбранной строки и столбца
                string cellValue = selectedRow.Cells[columnName].Value.ToString();
                string cellValue1 = selectedRow.Cells[columnName1].Value.ToString();
                string cellValue2 = selectedRow.Cells[columnName2].Value.ToString();
                // Устанавливаем значение в TextBox
                NameBox.Text = cellValue;
                RowBox.Text = cellValue1;
                SeatBox.Text = cellValue2;
            }
        }

        private void RowBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
                SeatBox.Focus();
        }

        private void NameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                RowBox.Focus();
        }

        private void SeatBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
                NameBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            EditTablebutton.Visible = true;
            Backbutton.Visible = true;
            exitToMAinbutton.Visible = true;
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
                if (selectedColumn == "Id места" | selectedColumn== "Ряд" | selectedColumn=="Место")
                {
                    filterExpression = $"CONVERT([{selectedColumn}], 'System.String') = '{searchText}'";
                }
                else
                {
                    // Формирование строки фильтрации
                    filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                }
                // Применение фильтра
                местаИРядыBindingSource.Filter = filterExpression;
            }
            else
            {
                //Если столбец не выбран, сброс фильтрации
                местаИРядыBindingSource.RemoveFilter();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            местаИРядыBindingSource.Filter = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new Tickets();
            dlg.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
