namespace GUI
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            очиститьДанныеToolStripMenuItem = new ToolStripMenuItem();
            сгенирировать1000СтрокToolStripMenuItem = new ToolStripMenuItem();
            сгенирировать1МСтрокToolStripMenuItem = new ToolStripMenuItem();
            создатьПустойФайлToolStripMenuItem = new ToolStripMenuItem();
            открытьПапкуСФайламиToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            консольToolStripMenuItem = new ToolStripMenuItem();
            поискПоАтрибутамToolStripMenuItem = new ToolStripMenuItem();
            поискПоФайлуToolStripMenuItem = new ToolStripMenuItem();
            поискЧерезИнвертированныйСписокToolStripMenuItem = new ToolStripMenuItem();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox4 = new TextBox();
            label10 = new Label();
            checkBox2 = new CheckBox();
            progressBar1 = new ProgressBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(770, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 50);
            label1.TabIndex = 1;
            label1.Text = "Flat File";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 93);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(555, 27);
            textBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 136);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(555, 375);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(585, 301);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(585, 373);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 27);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(651, 236);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 10;
            label4.Text = "Добавление записи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 52);
            label5.Name = "label5";
            label5.Size = new Size(148, 28);
            label5.TabIndex = 11;
            label5.Text = "Поиск записи";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 277);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 12;
            label6.Text = "ФИО";
            // 
            // button2
            // 
            button2.Location = new Point(585, 449);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(307, 63);
            button2.TabIndex = 2;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 533);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 6;
            label3.Text = "0 ms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 533);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 5;
            label2.Text = "Время выполнения:";
            // 
            // button1
            // 
            button1.Location = new Point(585, 93);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(307, 36);
            button1.TabIndex = 0;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(426, 532);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Индексный метод";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, оПрограммеToolStripMenuItem, консольToolStripMenuItem, поискПоАтрибутамToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(912, 30);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститьДанныеToolStripMenuItem, сгенирировать1000СтрокToolStripMenuItem, сгенирировать1МСтрокToolStripMenuItem, создатьПустойФайлToolStripMenuItem, открытьПапкуСФайламиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьДанныеToolStripMenuItem
            // 
            очиститьДанныеToolStripMenuItem.Name = "очиститьДанныеToolStripMenuItem";
            очиститьДанныеToolStripMenuItem.Size = new Size(276, 26);
            очиститьДанныеToolStripMenuItem.Text = "Очистить данные";
            очиститьДанныеToolStripMenuItem.Click += очиститьДанныеToolStripMenuItem_Click;
            // 
            // сгенирировать1000СтрокToolStripMenuItem
            // 
            сгенирировать1000СтрокToolStripMenuItem.Name = "сгенирировать1000СтрокToolStripMenuItem";
            сгенирировать1000СтрокToolStripMenuItem.Size = new Size(276, 26);
            сгенирировать1000СтрокToolStripMenuItem.Text = "Сгенерировать 1000 строк";
            сгенирировать1000СтрокToolStripMenuItem.Click += сгенирировать1000СтрокToolStripMenuItem_Click;
            // 
            // сгенирировать1МСтрокToolStripMenuItem
            // 
            сгенирировать1МСтрокToolStripMenuItem.Name = "сгенирировать1МСтрокToolStripMenuItem";
            сгенирировать1МСтрокToolStripMenuItem.Size = new Size(276, 26);
            сгенирировать1МСтрокToolStripMenuItem.Text = "Сгенерировать 1М строк";
            сгенирировать1МСтрокToolStripMenuItem.Click += сгенирировать1МСтрокToolStripMenuItem_Click;
            // 
            // создатьПустойФайлToolStripMenuItem
            // 
            создатьПустойФайлToolStripMenuItem.Name = "создатьПустойФайлToolStripMenuItem";
            создатьПустойФайлToolStripMenuItem.Size = new Size(276, 26);
            создатьПустойФайлToolStripMenuItem.Text = "Создать пустой файл";
            создатьПустойФайлToolStripMenuItem.Click += создатьПустойФайлToolStripMenuItem_Click;
            // 
            // открытьПапкуСФайламиToolStripMenuItem
            // 
            открытьПапкуСФайламиToolStripMenuItem.Name = "открытьПапкуСФайламиToolStripMenuItem";
            открытьПапкуСФайламиToolStripMenuItem.Size = new Size(276, 26);
            открытьПапкуСФайламиToolStripMenuItem.Text = "Открыть папку с файлами";
            открытьПапкуСФайламиToolStripMenuItem.Click += открытьПапкуСФайламиToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // консольToolStripMenuItem
            // 
            консольToolStripMenuItem.Name = "консольToolStripMenuItem";
            консольToolStripMenuItem.Size = new Size(82, 24);
            консольToolStripMenuItem.Text = "Консоль";
            консольToolStripMenuItem.Visible = false;
            консольToolStripMenuItem.Click += консольToolStripMenuItem_Click_1;
            // 
            // поискПоАтрибутамToolStripMenuItem
            // 
            поискПоАтрибутамToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поискПоФайлуToolStripMenuItem, поискЧерезИнвертированныйСписокToolStripMenuItem });
            поискПоАтрибутамToolStripMenuItem.Name = "поискПоАтрибутамToolStripMenuItem";
            поискПоАтрибутамToolStripMenuItem.Size = new Size(66, 24);
            поискПоАтрибутамToolStripMenuItem.Text = "Поиск";
            поискПоАтрибутамToolStripMenuItem.Click += поискПоАтрибутамToolStripMenuItem_Click;
            // 
            // поискПоФайлуToolStripMenuItem
            // 
            поискПоФайлуToolStripMenuItem.Name = "поискПоФайлуToolStripMenuItem";
            поискПоФайлуToolStripMenuItem.Size = new Size(365, 26);
            поискПоФайлуToolStripMenuItem.Text = "Поиск по файлу";
            поискПоФайлуToolStripMenuItem.Click += поискПоФайлуToolStripMenuItem_Click;
            // 
            // поискЧерезИнвертированныйСписокToolStripMenuItem
            // 
            поискЧерезИнвертированныйСписокToolStripMenuItem.Name = "поискЧерезИнвертированныйСписокToolStripMenuItem";
            поискЧерезИнвертированныйСписокToolStripMenuItem.Size = new Size(365, 26);
            поискЧерезИнвертированныйСписокToolStripMenuItem.Text = "Поиск через инвертированный список";
            поискЧерезИнвертированныйСписокToolStripMenuItem.Click += поискЧерезИнвертированныйСписокToolStripMenuItem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(861, 52);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 14;
            label7.Text = "v0.2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(585, 349);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 16;
            label8.Text = "Группа";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox1.Location = new Point(817, 373);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 28);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(817, 349);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 18;
            label9.Text = "Курс";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(585, 412);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Жен.";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(651, 412);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 24);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Муж.";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(585, 164);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 27);
            textBox4.TabIndex = 21;
            textBox4.Text = "typed_file.txt";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(585, 140);
            label10.Name = "label10";
            label10.Size = new Size(192, 20);
            label10.TabIndex = 22;
            label10.Text = "Путь до файла с данными:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(585, 532);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(294, 24);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Показывать только первый результат";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 481);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(555, 31);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 24;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 564);
            Controls.Add(progressBar1);
            Controls.Add(checkBox2);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(930, 611);
            MinimumSize = new Size(930, 611);
            Name = "MainView";
            Text = "Flat File v0.1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label3;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private ToolStripMenuItem очиститьДанныеToolStripMenuItem;
        private ToolStripMenuItem сгенирировать1000СтрокToolStripMenuItem;
        private ToolStripMenuItem сгенирировать1МСтрокToolStripMenuItem;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox4;
        private Label label10;
        private ToolStripMenuItem создатьПустойФайлToolStripMenuItem;
        private ToolStripMenuItem открытьПапкуСФайламиToolStripMenuItem;
        private CheckBox checkBox2;
        private ProgressBar progressBar1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem консольToolStripMenuItem;
        private ToolStripMenuItem поискПоАтрибутамToolStripMenuItem;
        private ToolStripMenuItem поискПоФайлуToolStripMenuItem;
        private ToolStripMenuItem поискЧерезИнвертированныйСписокToolStripMenuItem;
    }
}