namespace GUI.Views
{
    partial class SearchAttributes
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
            radioButton1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            radioButton2 = new RadioButton();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(72, 59);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "AND (&&)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 1;
            label1.Text = "Поиск по файлу";
            // 
            // button1
            // 
            button1.Location = new Point(757, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 2;
            button1.Text = "Выполнить поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(160, 59);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "OR (||)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Метод:";
            // 
            // button2
            // 
            button2.Location = new Point(675, 56);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(225, 31);
            button2.TabIndex = 5;
            button2.Text = "Сгенерировать файл индексов";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(863, 95);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(38, 31);
            button3.TabIndex = 7;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(818, 95);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(38, 31);
            button4.TabIndex = 8;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(797, 100);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 9;
            label3.Text = "1";
            // 
            // SearchAttributes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchAttributes";
            Text = "Поиск по файлу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private Label label1;
        private Button button1;
        private RadioButton radioButton2;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}