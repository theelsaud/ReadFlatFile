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

namespace GUI.Views
{
    public partial class InvertedList : Form
    {
        private MainView hView;
        private List<Fields> hFields = new();
        private List<PersonData> personDatas = new();
        private Utils.InvertedList hInvertedList = new();

        private class Fields
        {
            private const int iOffsetX = 30;
            private const int iOffsetY = 10;

            private const int iStartPosX = 20;
            private const int iStartPosY = 50;

            private const int iLabelSizeWidth = 70;
            private const int iLabelSizeHeight = 25;

            private const int iTextBoxSizeWidth = 350;
            private const int iTextBoxSizeHeight = 25;


            public Label hLabel = new();
            public TextBox textBox = new();

            public Fields(string LabelText, int iPos, Control.ControlCollection hControll)
            {
                hLabel = new Label();
                hLabel.Text = LabelText;
                hLabel.Location = new Point(iStartPosX, iStartPosY + (iLabelSizeHeight + iOffsetY) * iPos);
                hLabel.Size = new Size(iLabelSizeWidth, iLabelSizeHeight);

                hControll.Add(hLabel);

                textBox = new TextBox()
                {
                    Name = "textBox_" + iPos.ToString(),
                    Location = new Point(hLabel.Location.X + iLabelSizeWidth + iOffsetX, hLabel.Location.Y), // Расположение TextBox на форме
                    Size = new Size(iTextBoxSizeWidth, iTextBoxSizeHeight), // Размер TextBox
                };


                hControll.Add(textBox);
            }

            public void Dispose()
            {
                textBox.Parent.Controls.Remove(textBox);
                textBox.Dispose();

                // Remove Label
                hLabel.Parent.Controls.Remove(hLabel);
                hLabel.Dispose();
            }
        }

        public InvertedList(MainView mainView)
        {
            hView = mainView;
            InitializeComponent();

            InitDB();

            LoadFields();
        }

        private void InitDB()
        {
            personDatas = hView.GetSearchEngine().LoadFromFile();
            hInvertedList.InitIndexes(personDatas);
            Console.WriteLine("InitDB");
        }

        private void LoadFields()
        {
            foreach (var hField in hFields)
            {
                hField.Dispose();
            }

            hFields.Clear();


            // Перебираем элементы перечисления и создаем для каждого Label и TextBox
            for (PersonData.Position pos = 0; pos < PersonData.Position.COUNT; pos++)
            {
                Fields hField = new(PersonData.PositionNames[(int)pos] + ": ", (int)pos, this.Controls);

                hFields.Add(hField);
            }

            //ResumeLayout(false);
            //PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<PersonData.ValidateData> tList = new();

            for (int i = 0; i < hFields.Count(); i++)
            {
                List<PersonData.ValidateData> hList = new();

                string value = hFields[i].textBox.Text;

                if (value != "")
                {
                    PersonData.ValidateData SObj = new();
                    SObj.Pos = (PersonData.Position)i;
                    SObj.SearchString = value;

                    tList.Add(SObj);
                }
            }

            Console.WriteLine(tList.Count.ToString());

            var hPersons = hInvertedList.Search(tList, radioButton1.Checked);

            string buffer = $"Поиск по инвертированному списку: найдено {hPersons.Count()} записей:\n\n\n";

            hView.ShowResult(buffer, hPersons);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
