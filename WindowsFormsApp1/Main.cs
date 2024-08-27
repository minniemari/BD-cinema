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
    public partial class Main : Form
    {
        public Main()
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
        private void OpenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new AllTables(); dlg.ShowDialog();
            // Отображаем новую форму

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SellTicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dlg = new SellTicket();
            dlg.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            //this.билетыTableAdapter.Fill(this.кинотеатрDataSet.Билеты);

        }
    }
}
