using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Utils.PersonData;

namespace GUI_7._0.Views
{
    public partial class SearchAttributes : Form
    {
        MainView hView;
        SearchEngine SE = new SearchEngine();
        List<TextBox> textBoxes = new List<TextBox>();

        public SearchAttributes(MainView mainView)
        {
            hView = mainView;
            SE = mainView.GetSearchEngine();
            InitializeComponent();

            LoadFields();
        }

        private void LoadFields()
        {
            //SuspendLayout();

            // Перебираем элементы перечисления и создаем для каждого Label и TextBox
            for (PersonData.Position pos = 0; pos < PersonData.Position.COUNT; pos++)
            {
                Label label = new Label();
                label.Text = PersonData.PositionNames[(int)pos] + ": "; // Устанавливаем текст Label из массива PositionNames
                label.Location = new System.Drawing.Point(20, 100 + 30 * (int)pos); // Расположение Label на форме
                this.Controls.Add(label); // Добавляем Label на форму

                TextBox textBox = new()
                {
                    Location = new Point(200, 100 + 30 * (int)pos), // Расположение TextBox на форме
                    Size = new Size(100, 23), // Размер TextBox                    
                };

                this.Controls.Add(textBox); // Добавляем TextBox на форму

                textBox.Focus();

                textBoxes.Add(textBox);
            }

            //ResumeLayout(false);
            //PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buf = "";

            int i = 0;
            List<PersonData.ValidateData> hList = new();

            foreach (TextBox textBox in textBoxes)
            {
                string value = textBox.Text;

                if(value != "")
                {
                    PersonData.ValidateData SObj = new();
                    SObj.Pos = (PersonData.Position)i;
                    SObj.SearchString = value;

                    hList.Add(SObj);
                }

                buf += value + "\n";
                i++;
            }

            List<PersonData> hFiltered = SE.SearchFiltered(hList, radioButton1.Checked);

            string buffer = $"По запросу {textBox1.Text} найдено {hFiltered.Count()} записей:\n\n\n";

            hView.GetRichTextBox().Text = buffer;
        }
    }
}
