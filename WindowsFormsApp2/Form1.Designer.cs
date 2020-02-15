namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.простейшиеДействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычитаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умножениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияСЧисламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модульКвадратКореньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простейшиеДействияToolStripMenuItem,
            this.действияСЧисламиToolStripMenuItem,
            this.матрицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // простейшиеДействияToolStripMenuItem
            // 
            this.простейшиеДействияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сложениеToolStripMenuItem,
            this.вычитаниеToolStripMenuItem,
            this.умножениеToolStripMenuItem,
            this.делениеToolStripMenuItem});
            this.простейшиеДействияToolStripMenuItem.Name = "простейшиеДействияToolStripMenuItem";
            this.простейшиеДействияToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.простейшиеДействияToolStripMenuItem.Text = "Простейшие действия";
            // 
            // сложениеToolStripMenuItem
            // 
            this.сложениеToolStripMenuItem.Name = "сложениеToolStripMenuItem";
            this.сложениеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.сложениеToolStripMenuItem.Text = "Сложение";
            this.сложениеToolStripMenuItem.Click += new System.EventHandler(this.сложениеToolStripMenuItem_Click);
            // 
            // вычитаниеToolStripMenuItem
            // 
            this.вычитаниеToolStripMenuItem.Name = "вычитаниеToolStripMenuItem";
            this.вычитаниеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вычитаниеToolStripMenuItem.Text = "Вычитание";
            this.вычитаниеToolStripMenuItem.Click += new System.EventHandler(this.вычитаниеToolStripMenuItem_Click);
            // 
            // умножениеToolStripMenuItem
            // 
            this.умножениеToolStripMenuItem.Name = "умножениеToolStripMenuItem";
            this.умножениеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.умножениеToolStripMenuItem.Text = "Умножение";
            this.умножениеToolStripMenuItem.Click += new System.EventHandler(this.умножениеToolStripMenuItem_Click);
            // 
            // делениеToolStripMenuItem
            // 
            this.делениеToolStripMenuItem.Name = "делениеToolStripMenuItem";
            this.делениеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.делениеToolStripMenuItem.Text = "Деление";
            this.делениеToolStripMenuItem.Click += new System.EventHandler(this.делениеToolStripMenuItem_Click);
            // 
            // действияСЧисламиToolStripMenuItem
            // 
            this.действияСЧисламиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.модульКвадратКореньToolStripMenuItem});
            this.действияСЧисламиToolStripMenuItem.Name = "действияСЧисламиToolStripMenuItem";
            this.действияСЧисламиToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.действияСЧисламиToolStripMenuItem.Text = "Действия с числами";
            // 
            // модульКвадратКореньToolStripMenuItem
            // 
            this.модульКвадратКореньToolStripMenuItem.Name = "модульКвадратКореньToolStripMenuItem";
            this.модульКвадратКореньToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.модульКвадратКореньToolStripMenuItem.Text = "Модуль/Квадрат/Корень";
            this.модульКвадратКореньToolStripMenuItem.Click += new System.EventHandler(this.модульКвадратКореньToolStripMenuItem_Click);
            // 
            // матрицыToolStripMenuItem
            // 
            this.матрицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem});
            this.матрицыToolStripMenuItem.Name = "матрицыToolStripMenuItem";
            this.матрицыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.матрицыToolStripMenuItem.Text = "Матрицы";
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x2ToolStripMenuItem.Text = "2x2";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x3ToolStripMenuItem.Text = "3x3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(59, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 285);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Калькулируйте";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem простейшиеДействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычитаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem умножениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияСЧисламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицыToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem модульКвадратКореньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
    }
}

