namespace WindowsFormsApp1
{
    partial class AllTables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.seatsbutton = new System.Windows.Forms.Button();
            this.HallButton = new System.Windows.Forms.Button();
            this.Seansebutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ticketsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.seatsbutton);
            this.panel1.Controls.Add(this.HallButton);
            this.panel1.Controls.Add(this.Seansebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 279);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(480, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 98);
            this.button1.TabIndex = 17;
            this.button1.Text = "Вернуться в главное меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seatsbutton
            // 
            this.seatsbutton.BackColor = System.Drawing.Color.Transparent;
            this.seatsbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seatsbutton.FlatAppearance.BorderSize = 10;
            this.seatsbutton.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.seatsbutton.Location = new System.Drawing.Point(59, 129);
            this.seatsbutton.Name = "seatsbutton";
            this.seatsbutton.Size = new System.Drawing.Size(247, 98);
            this.seatsbutton.TabIndex = 12;
            this.seatsbutton.Text = "Места и ряды";
            this.seatsbutton.UseVisualStyleBackColor = false;
            this.seatsbutton.Click += new System.EventHandler(this.seatsbutton_Click);
            // 
            // HallButton
            // 
            this.HallButton.BackColor = System.Drawing.Color.Transparent;
            this.HallButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HallButton.FlatAppearance.BorderSize = 10;
            this.HallButton.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HallButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HallButton.Location = new System.Drawing.Point(59, 14);
            this.HallButton.Name = "HallButton";
            this.HallButton.Size = new System.Drawing.Size(247, 98);
            this.HallButton.TabIndex = 10;
            this.HallButton.Text = "Залы";
            this.HallButton.UseVisualStyleBackColor = false;
            this.HallButton.Click += new System.EventHandler(this.HallButton_Click);
            // 
            // Seansebutton
            // 
            this.Seansebutton.BackColor = System.Drawing.Color.Transparent;
            this.Seansebutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Seansebutton.FlatAppearance.BorderSize = 10;
            this.Seansebutton.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seansebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Seansebutton.Location = new System.Drawing.Point(480, 14);
            this.Seansebutton.Name = "Seansebutton";
            this.Seansebutton.Size = new System.Drawing.Size(247, 98);
            this.Seansebutton.TabIndex = 15;
            this.Seansebutton.Text = "Сеансы";
            this.Seansebutton.UseVisualStyleBackColor = false;
            this.Seansebutton.Click += new System.EventHandler(this.Seansebutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Ticketsbutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MoviesButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 168);
            this.panel2.TabIndex = 3;
            // 
            // Ticketsbutton
            // 
            this.Ticketsbutton.BackColor = System.Drawing.Color.Transparent;
            this.Ticketsbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ticketsbutton.FlatAppearance.BorderSize = 10;
            this.Ticketsbutton.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticketsbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ticketsbutton.Location = new System.Drawing.Point(480, 67);
            this.Ticketsbutton.Name = "Ticketsbutton";
            this.Ticketsbutton.Size = new System.Drawing.Size(247, 98);
            this.Ticketsbutton.TabIndex = 16;
            this.Ticketsbutton.Text = "Билеты";
            this.Ticketsbutton.UseVisualStyleBackColor = false;
            this.Ticketsbutton.Click += new System.EventHandler(this.Ticketsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(288, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблицы";
            // 
            // MoviesButton
            // 
            this.MoviesButton.BackColor = System.Drawing.Color.Transparent;
            this.MoviesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MoviesButton.FlatAppearance.BorderSize = 10;
            this.MoviesButton.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MoviesButton.Location = new System.Drawing.Point(59, 67);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(247, 98);
            this.MoviesButton.TabIndex = 14;
            this.MoviesButton.Text = "Фильмы";
            this.MoviesButton.UseVisualStyleBackColor = false;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // AllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AllTables";
            this.Text = "AllTables";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button seatsbutton;
        private System.Windows.Forms.Button HallButton;
        private System.Windows.Forms.Button Seansebutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Ticketsbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoviesButton;
    }
}