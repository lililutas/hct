namespace fulllab
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаГраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЗаливкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветГраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.прямаяЛинияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.произвольнаяЛинияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.фигураToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Enabled = false;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.толщинаГраницыToolStripMenuItem,
            this.цветЗаливкиToolStripMenuItem,
            this.цветГраницыToolStripMenuItem,
            this.размерToolStripMenuItem,
            this.заливкаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // толщинаГраницыToolStripMenuItem
            // 
            this.толщинаГраницыToolStripMenuItem.Name = "толщинаГраницыToolStripMenuItem";
            this.толщинаГраницыToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.толщинаГраницыToolStripMenuItem.Text = "Толщина границы";
            this.толщинаГраницыToolStripMenuItem.Click += new System.EventHandler(this.толщинаГраницыToolStripMenuItem_Click);
            // 
            // цветЗаливкиToolStripMenuItem
            // 
            this.цветЗаливкиToolStripMenuItem.Name = "цветЗаливкиToolStripMenuItem";
            this.цветЗаливкиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.цветЗаливкиToolStripMenuItem.Text = "Цвет заливки";
            this.цветЗаливкиToolStripMenuItem.Click += new System.EventHandler(this.цветЗаливкиToolStripMenuItem_Click);
            // 
            // цветГраницыToolStripMenuItem
            // 
            this.цветГраницыToolStripMenuItem.Name = "цветГраницыToolStripMenuItem";
            this.цветГраницыToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.цветГраницыToolStripMenuItem.Text = "Цвет границы";
            this.цветГраницыToolStripMenuItem.Click += new System.EventHandler(this.цветГраницыToolStripMenuItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.размерToolStripMenuItem.Text = "Размер";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.заливкаToolStripMenuItem.Text = "Заливка";
            this.заливкаToolStripMenuItem.Click += new System.EventHandler(this.заливкаToolStripMenuItem_Click);
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эллипсToolStripMenuItem,
            this.эллипсToolStripMenuItem1,
            this.прямаяЛинияToolStripMenuItem,
            this.произвольнаяЛинияToolStripMenuItem});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // эллипсToolStripMenuItem
            // 
            this.эллипсToolStripMenuItem.Checked = true;
            this.эллипсToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            this.эллипсToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.эллипсToolStripMenuItem.Text = "Прямоугольник";
            this.эллипсToolStripMenuItem.Click += new System.EventHandler(this.эллипсToolStripMenuItem_Click);
            // 
            // эллипсToolStripMenuItem1
            // 
            this.эллипсToolStripMenuItem1.Name = "эллипсToolStripMenuItem1";
            this.эллипсToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.эллипсToolStripMenuItem1.Text = "Эллипс";
            this.эллипсToolStripMenuItem1.Click += new System.EventHandler(this.эллипсToolStripMenuItem1_Click);
            // 
            // прямаяЛинияToolStripMenuItem
            // 
            this.прямаяЛинияToolStripMenuItem.Name = "прямаяЛинияToolStripMenuItem";
            this.прямаяЛинияToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.прямаяЛинияToolStripMenuItem.Text = "Прямая линия";
            this.прямаяЛинияToolStripMenuItem.Click += new System.EventHandler(this.прямаяЛинияToolStripMenuItem_Click);
            // 
            // произвольнаяЛинияToolStripMenuItem
            // 
            this.произвольнаяЛинияToolStripMenuItem.Name = "произвольнаяЛинияToolStripMenuItem";
            this.произвольнаяЛинияToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.произвольнаяЛинияToolStripMenuItem.Text = "Произвольная линия";
            this.произвольнаяЛинияToolStripMenuItem.Click += new System.EventHandler(this.произвольнаяЛинияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаГраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЗаливкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветГраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem прямаяЛинияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem произвольнаяЛинияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;
    }
}

