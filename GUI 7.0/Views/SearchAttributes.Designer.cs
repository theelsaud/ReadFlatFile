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
            radioButton1.Location = new Point(63, 44);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "AND (&&)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 21);
            label1.TabIndex = 1;
            label1.Text = "Поиск по инвертированным спискам";
            // 
            // button1
            // 
            button1.Location = new Point(662, 12);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 2;
            button1.Text = "Выполнить поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(140, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "OR (||)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Метод:";
            // 
            // button2
            // 
            button2.Location = new Point(591, 42);
            button2.Name = "button2";
            button2.Size = new Size(197, 23);
            button2.TabIndex = 5;
            button2.Text = "Сгенерировать файл индексов";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(755, 71);
            button3.Name = "button3";
            button3.Size = new Size(33, 23);
            button3.TabIndex = 7;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(716, 71);
            button4.Name = "button4";
            button4.Size = new Size(33, 23);
            button4.TabIndex = 8;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 75);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 9;
            label3.Text = "1";
            // 
            // SearchAttributes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton1);
            Name = "SearchAttributes";
            Text = "SearchAttributes";
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