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
    public partial class Halls : Form
    {
        public Halls()
        {
            InitializeComponent();
            ComboBox11.Items.Add("Id зала"); // Замените на фактические имена столбцов
            ComboBox11.Items.Add("Наименование зала");
        }

        private void Halls_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.кинотеатрDataSet.Залы);

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


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                NameBox.Focus();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentCell.RowIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            залыBindingSource.AddNew();
            DataRowView newRowView = (DataRowView)залыBindingSource.Current;
            // Заполните значениями из TextBox'ов или других источников данных
            newRowView["Наименование зала"] = NameBox.Text;
            // Завершите добавление новой записи
            залыBindingSource.EndEdit();
            залыTableAdapter.Update(кинотеатрDataSet.Залы);//сохранение в базу данных
            this.залыTableAdapter.Fill(this.кинотеатрDataSet.Залы);
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (залыBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    залыBindingSource.RemoveCurrent();
                    залыTableAdapter.Update(кинотеатрDataSet.Залы);//сохранение в базу данных
                }
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            
            // Проверка наличия выбранной строки
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex=dataGridView1.CurrentRow.Index;
                // Получение данных из TextBox'ов
                string newCinemaHallName = NameBox.Text;
                // Изменение данных в DataTable
                кинотеатрDataSet.Tables["Залы"].Rows[rowIndex]["Наименование зала"] = newCinemaHallName;
                // Обновление данных в базе данных
                залыTableAdapter.Update(кинотеатрDataSet.Залы);//сохранение в базу данных

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
                string columnName = "наименованиеЗалаDataGridViewTextBoxColumn";
                // Проверяем, есть ли такой столбец в таблице
                // Получаем значение из выбранной строки и столбца
                string cellValue = selectedRow.Cells[columnName].Value.ToString();
                // Устанавливаем значение в TextBox
                NameBox.Text = cellValue;
            }
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
                if (selectedColumn == "Id зала")
                {
                    filterExpression = $"CONVERT([{selectedColumn}], 'System.String') = '{searchText}'";
                }
                else
                {
                    // Формирование строки фильтрации
                    filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                }
                // Применение фильтра
                залыBindingSource.Filter = filterExpression;
            }
            else
            {
                //Если столбец не выбран, сброс фильтрации
                залыBindingSource.RemoveFilter();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            залыBindingSource.Filter = null;
        }
    }
}
