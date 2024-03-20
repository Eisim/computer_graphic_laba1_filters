namespace laba_1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повышениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияСОпорнымЦветомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальныеВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальныеВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеПоГауссуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осьOyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обеОсиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повышениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрЩарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осьOxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осьOyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обеОбсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеВДвиженииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСГистограммойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матморфологииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.работаСГистограммойToolStripMenuItem,
            this.матморфологииToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleFilterToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.повышениеЯркостиToolStripMenuItem,
            this.коррекцияСОпорнымЦветомToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem,
            this.эффектВолныToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // grayScaleFilterToolStripMenuItem
            // 
            this.grayScaleFilterToolStripMenuItem.Name = "grayScaleFilterToolStripMenuItem";
            this.grayScaleFilterToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.grayScaleFilterToolStripMenuItem.Text = "Черно-белый фильтр";
            this.grayScaleFilterToolStripMenuItem.Click += new System.EventHandler(this.grayScaleFilterToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // повышениеЯркостиToolStripMenuItem
            // 
            this.повышениеЯркостиToolStripMenuItem.Name = "повышениеЯркостиToolStripMenuItem";
            this.повышениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.повышениеЯркостиToolStripMenuItem.Text = "Повышение яркости";
            this.повышениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеЯркостиToolStripMenuItem_Click);
            // 
            // коррекцияСОпорнымЦветомToolStripMenuItem
            // 
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Name = "коррекцияСОпорнымЦветомToolStripMenuItem";
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Text = "Коррекция с опорным цветом";
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Click += new System.EventHandler(this.коррекцияСОпорнымЦветомToolStripMenuItem_Click);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // эффектВолныToolStripMenuItem
            // 
            this.эффектВолныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вертикальныеВолныToolStripMenuItem,
            this.горизонтальныеВолныToolStripMenuItem});
            this.эффектВолныToolStripMenuItem.Name = "эффектВолныToolStripMenuItem";
            this.эффектВолныToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.эффектВолныToolStripMenuItem.Text = "Эффект волны";
            // 
            // вертикальныеВолныToolStripMenuItem
            // 
            this.вертикальныеВолныToolStripMenuItem.Name = "вертикальныеВолныToolStripMenuItem";
            this.вертикальныеВолныToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.вертикальныеВолныToolStripMenuItem.Text = "Вертикальные волны";
            this.вертикальныеВолныToolStripMenuItem.Click += new System.EventHandler(this.вертикальныеВолныToolStripMenuItem_Click);
            // 
            // горизонтальныеВолныToolStripMenuItem
            // 
            this.горизонтальныеВолныToolStripMenuItem.Name = "горизонтальныеВолныToolStripMenuItem";
            this.горизонтальныеВолныToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.горизонтальныеВолныToolStripMenuItem.Text = "Горизонтальные волны";
            this.горизонтальныеВолныToolStripMenuItem.Click += new System.EventHandler(this.горизонтальныеВолныToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.размытиеПоГауссуToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.повышениеРезкостиToolStripMenuItem,
            this.фильтрЩарраToolStripMenuItem,
            this.размытиеВДвиженииToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            this.матричныеToolStripMenuItem.Click += new System.EventHandler(this.матричныеToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // размытиеПоГауссуToolStripMenuItem
            // 
            this.размытиеПоГауссуToolStripMenuItem.Name = "размытиеПоГауссуToolStripMenuItem";
            this.размытиеПоГауссуToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.размытиеПоГауссуToolStripMenuItem.Text = "Размытие по Гауссу";
            this.размытиеПоГауссуToolStripMenuItem.Click += new System.EventHandler(this.размытиеПоГауссуToolStripMenuItem_Click);
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            this.фильтрСобеляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oxToolStripMenuItem,
            this.осьOyToolStripMenuItem,
            this.обеОсиToolStripMenuItem});
            this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
            // 
            // oxToolStripMenuItem
            // 
            this.oxToolStripMenuItem.Name = "oxToolStripMenuItem";
            this.oxToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.oxToolStripMenuItem.Text = "Ось Ox";
            this.oxToolStripMenuItem.Click += new System.EventHandler(this.ОО);
            // 
            // осьOyToolStripMenuItem
            // 
            this.осьOyToolStripMenuItem.Name = "осьOyToolStripMenuItem";
            this.осьOyToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.осьOyToolStripMenuItem.Text = "Ось Oy";
            this.осьOyToolStripMenuItem.Click += new System.EventHandler(this.осьOyToolStripMenuItem_Click);
            // 
            // обеОсиToolStripMenuItem
            // 
            this.обеОсиToolStripMenuItem.Name = "обеОсиToolStripMenuItem";
            this.обеОсиToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.обеОсиToolStripMenuItem.Text = "Обе оси";
            this.обеОсиToolStripMenuItem.Click += new System.EventHandler(this.обеОсиToolStripMenuItem_Click);
            // 
            // повышениеРезкостиToolStripMenuItem
            // 
            this.повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
            this.повышениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.повышениеРезкостиToolStripMenuItem.Text = "Повышение резкости";
            this.повышениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеРезкостиToolStripMenuItem_Click);
            // 
            // фильтрЩарраToolStripMenuItem
            // 
            this.фильтрЩарраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.осьOxToolStripMenuItem,
            this.осьOyToolStripMenuItem1,
            this.обеОбсToolStripMenuItem});
            this.фильтрЩарраToolStripMenuItem.Name = "фильтрЩарраToolStripMenuItem";
            this.фильтрЩарраToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.фильтрЩарраToolStripMenuItem.Text = "Фильтр Щарра";
            // 
            // осьOxToolStripMenuItem
            // 
            this.осьOxToolStripMenuItem.Name = "осьOxToolStripMenuItem";
            this.осьOxToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.осьOxToolStripMenuItem.Text = "Ось Ox";
            this.осьOxToolStripMenuItem.Click += new System.EventHandler(this.осьOxToolStripMenuItem_Click);
            // 
            // осьOyToolStripMenuItem1
            // 
            this.осьOyToolStripMenuItem1.Name = "осьOyToolStripMenuItem1";
            this.осьOyToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.осьOyToolStripMenuItem1.Text = "Ось Oy";
            this.осьOyToolStripMenuItem1.Click += new System.EventHandler(this.осьOyToolStripMenuItem1_Click);
            // 
            // обеОбсToolStripMenuItem
            // 
            this.обеОбсToolStripMenuItem.Name = "обеОбсToolStripMenuItem";
            this.обеОбсToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.обеОбсToolStripMenuItem.Text = "Обе оси";
            this.обеОбсToolStripMenuItem.Click += new System.EventHandler(this.обеОбсToolStripMenuItem_Click);
            // 
            // размытиеВДвиженииToolStripMenuItem
            // 
            this.размытиеВДвиженииToolStripMenuItem.Name = "размытиеВДвиженииToolStripMenuItem";
            this.размытиеВДвиженииToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.размытиеВДвиженииToolStripMenuItem.Text = "Размытие в движении";
            this.размытиеВДвиженииToolStripMenuItem.Click += new System.EventHandler(this.размытиеВДвиженииToolStripMenuItem_Click);
            // 
            // работаСГистограммойToolStripMenuItem
            // 
            this.работаСГистограммойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линейноеРастяжениеToolStripMenuItem});
            this.работаСГистограммойToolStripMenuItem.Name = "работаСГистограммойToolStripMenuItem";
            this.работаСГистограммойToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.работаСГистограммойToolStripMenuItem.Text = "Работа с гистограммой";
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
            // 
            // матморфологииToolStripMenuItem
            // 
            this.матморфологииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradToolStripMenuItem});
            this.матморфологииToolStripMenuItem.Name = "матморфологииToolStripMenuItem";
            this.матморфологииToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.матморфологииToolStripMenuItem.Text = "Матморфологии";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dilationToolStripMenuItem.Text = "dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.erosionToolStripMenuItem.Text = "erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openingToolStripMenuItem.Text = "opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closingToolStripMenuItem.Text = "closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gradToolStripMenuItem.Text = "grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(694, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеПоГауссуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повышениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повышениеРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коррекцияСОпорнымЦветомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСГистограммойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальныеВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальныеВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осьOyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрЩарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осьOxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осьOyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обеОбсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обеОсиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеВДвиженииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матморфологииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
    }
}

