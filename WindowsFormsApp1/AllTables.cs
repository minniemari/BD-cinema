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
    public partial class AllTables : Form
    {
        public AllTables()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main1 = new Main();
            main1.ShowDialog();
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void Seansebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Seanses();
            frm.ShowDialog();
        }

        private void Ticketsbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Tickets();
            frm.ShowDialog();
        }

        private void HallButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Halls();
            frm.ShowDialog();
        }

        private void seatsbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Seats();
            frm.ShowDialog();
        }
    }
}
