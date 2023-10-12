namespace GUI_7._0
{
    partial class AboutView
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
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 49);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 16;
            label7.Text = "v0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 40);
            label1.TabIndex = 15;
            label1.Text = "Flat File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 108);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 17;
            label2.Text = "2023";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 18;
            label3.Text = "Authors";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 58);
            label4.Name = "label4";
            label4.Size = new Size(197, 15);
            label4.TabIndex = 19;
            label4.Text = "Mikhailovsky Mikhail Alexandrovich";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 84);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 20;
            label5.Text = "El Said Omar Said Adam";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 108);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 21;
            label6.Text = "Cherneshev Vladimir Vitalievich";
            // 
            // AboutView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 137);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}