namespace GUI_7._0
{
    partial class Form1
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
            label1.Location = new Point(670, 2);
            label1.Name = "label1";
            label1.Size = new Size(114, 40);
            label1.TabIndex = 1;
            label1.Text = "Flat File";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 23);
            textBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(486, 282);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(512, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(570, 177);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 10;
            label4.Text = "Добавление записи";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 39);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 11;
            label5.Text = "Поиск записи";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 208);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 12;
            label6.Text = "ФИО";
            // 
            // button2
            // 
            button2.Location = new Point(512, 337);
            button2.Name = "button2";
            button2.Size = new Size(269, 47);
            button2.TabIndex = 2;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 400);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "0 ms";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 400);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 5;
            label2.Text = "Время выполнения:";
            // 
            // button1
            // 
            button1.Location = new Point(512, 70);
            button1.Name = "button1";
            button1.Size = new Size(269, 27);
            button1.TabIndex = 0;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(373, 399);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Индексный метод";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститьДанныеToolStripMenuItem, сгенирировать1000СтрокToolStripMenuItem, сгенирировать1МСтрокToolStripMenuItem, создатьПустойФайлToolStripMenuItem, открытьПапкуСФайламиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // очиститьДанныеToolStripMenuItem
            // 
            очиститьДанныеToolStripMenuItem.Name = "очиститьДанныеToolStripMenuItem";
            очиститьДанныеToolStripMenuItem.Size = new Size(219, 22);
            очиститьДанныеToolStripMenuItem.Text = "Очистить данные";
            очиститьДанныеToolStripMenuItem.Click += очиститьДанныеToolStripMenuItem_Click;
            // 
            // сгенирировать1000СтрокToolStripMenuItem
            // 
            сгенирировать1000СтрокToolStripMenuItem.Name = "сгенирировать1000СтрокToolStripMenuItem";
            сгенирировать1000СтрокToolStripMenuItem.Size = new Size(219, 22);
            сгенирировать1000СтрокToolStripMenuItem.Text = "Сгенерировать 1000 строк";
            сгенирировать1000СтрокToolStripMenuItem.Click += сгенирировать1000СтрокToolStripMenuItem_Click;
            // 
            // сгенирировать1МСтрокToolStripMenuItem
            // 
            сгенирировать1МСтрокToolStripMenuItem.Name = "сгенирировать1МСтрокToolStripMenuItem";
            сгенирировать1МСтрокToolStripMenuItem.Size = new Size(219, 22);
            сгенирировать1МСтрокToolStripMenuItem.Text = "Сгенерировать 1М строк";
            сгенирировать1МСтрокToolStripMenuItem.Click += сгенирировать1МСтрокToolStripMenuItem_Click;
            // 
            // создатьПустойФайлToolStripMenuItem
            // 
            создатьПустойФайлToolStripMenuItem.Name = "создатьПустойФайлToolStripMenuItem";
            создатьПустойФайлToolStripMenuItem.Size = new Size(219, 22);
            создатьПустойФайлToolStripMenuItem.Text = "Создать пустой файл";
            создатьПустойФайлToolStripMenuItem.Click += создатьПустойФайлToolStripMenuItem_Click;
            // 
            // открытьПапкуСФайламиToolStripMenuItem
            // 
            открытьПапкуСФайламиToolStripMenuItem.Name = "открытьПапкуСФайламиToolStripMenuItem";
            открытьПапкуСФайламиToolStripMenuItem.Size = new Size(219, 22);
            открытьПапкуСФайламиToolStripMenuItem.Text = "Открыть папку с файлами";
            открытьПапкуСФайламиToolStripMenuItem.Click += открытьПапкуСФайламиToolStripMenuItem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(757, 39);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 14;
            label7.Text = "v0.1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 262);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 16;
            label8.Text = "Группа";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox1.Location = new Point(715, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(66, 23);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(715, 262);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 18;
            label9.Text = "Курс";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(512, 309);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Жен.";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(570, 309);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Муж.";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(512, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(269, 23);
            textBox4.TabIndex = 21;
            textBox4.Text = "typed_file.txt";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(512, 105);
            label10.Name = "label10";
            label10.Size = new Size(153, 15);
            label10.TabIndex = 22;
            label10.Text = "Путь до файла с данными:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(512, 399);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(233, 19);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Показывать только первый результат";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 361);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(486, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
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
            MaximizeBox = false;
            MaximumSize = new Size(816, 470);
            MinimumSize = new Size(816, 470);
            Name = "Form1";
            Text = "Flat File v0.1";
            Load += Form1_Load;
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
    }
}