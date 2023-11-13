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

namespace GUI.Views
{
    public partial class SearchAttributes : Form
    {
        private MainView hView;
        private SearchEngine SE;



        private class Fields
        {
            private const int iOffsetX = 30;
            private const int iOffsetY = 10;

            private const int iStartPosX = 20;
            private const int iStartPosY = 100;

            private const int iLabelSizeWidth = 50;
            private const int iLabelSizeHeight = 25;

            private const int iTextBoxSizeWidth = 100;
            private const int iTextBoxSizeHeight = 25;

            private const int iComboBoxSizeWidth = 40;
            private const int iComboBoxSizeHeight = 25;

            public Label hLabel = new();
            public List<TextBox> textBoxes = new();
            public List<ComboBox> comboBoxes = new();

            public Fields(string LabelText, int iPos, int iColumns, Control.ControlCollection hControll)
            {
                hLabel = new Label();
                hLabel.Text = LabelText;
                hLabel.Location = new Point(iStartPosX, iStartPosY + (iLabelSizeHeight + iOffsetY) * iPos);
                hLabel.Size = new Size(iLabelSizeWidth, iLabelSizeHeight);

                hControll.Add(hLabel);

                for (int i = 0; i < iColumns; i++)
                {
                    Point hPoint;
                    if (i == 0)
                    {
                        hPoint = new(hLabel.Location.X + iLabelSizeWidth + iOffsetX, hLabel.Location.Y);
                    }
                    else
                    {
                        hPoint = new(textBoxes[i - 1].Location.X + iTextBoxSizeWidth + iComboBoxSizeWidth + iOffsetX, textBoxes[i - 1].Location.Y);
                    }

                    TextBox textBox = new TextBox()
                    {
                        Name = "textBox_" + iPos.ToString() + "_" + i.ToString(),
                        Location = hPoint, // Расположение TextBox на форме
                        Size = new Size(iTextBoxSizeWidth, iTextBoxSizeHeight), // Размер TextBox
                    };

                    ComboBox comboBox = new ComboBox()
                    {
                        Location = new Point(textBox.Location.X + textBox.Width + 10, textBox.Location.Y), // Расположение ComboBox на форме (next to TextBox)
                        Size = new Size(iComboBoxSizeWidth, iComboBoxSizeHeight), // Размер ComboBox
                    };

                    comboBox.Items.AddRange(new string[] { "=", ">=", "<=" });
                    comboBox.SelectedIndex = 0;

                    textBoxes.Add(textBox);
                    comboBoxes.Add(comboBox);

                    hControll.Add(textBox);
                    hControll.Add(comboBox);
                }
            }

            public void Dispose()
            {
                // Remove ComboBoxes
                foreach (var comboBox in comboBoxes)
                {
                    comboBox.Parent.Controls.Remove(comboBox);
                    comboBox.Dispose();
                }
                comboBoxes.Clear();

                // Remove TextBoxes
                foreach (var textBox in textBoxes)
                {
                    textBox.Parent.Controls.Remove(textBox);
                    textBox.Dispose();
                }
                textBoxes.Clear();

                // Remove Label
                hLabel.Parent.Controls.Remove(hLabel);
                hLabel.Dispose();
            }
        }

        private List<Fields> hFields = new();
        private int Rows = 1;

        public SearchAttributes(MainView mainView)
        {
            hView = mainView;
            SE = mainView.GetSearchEngine();
            InitializeComponent();

            LoadFields();
        }

        private void Limiter(int iValue)
        {
            if (iValue < 1)
            {
                Rows = 1;
                return;
            }

            if (iValue > 9)
            {
                Rows = 10;
                return;
            }

            Rows = iValue;
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
                Fields hField = new(PersonData.PositionNames[(int)pos] + ": ", (int)pos, Rows, this.Controls);

                hFields.Add(hField);
            }

            //ResumeLayout(false);
            //PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buf = "";

            List<List<PersonData.ValidateData>> tList = new();

            for (int i = 0; i < hFields.Count(); i++)
            {
                List<PersonData.ValidateData> hList = new();
                for (int j = 0; j < hFields[i].textBoxes.Count(); j++)
                {
                    string value = hFields[i].textBoxes[j].Text;
                    string op = hFields[i].comboBoxes[j].Text;

                    if (value != "")
                    {
                        PersonData.ValidateData SObj = new();
                        SObj.Pos = (PersonData.Position)i;
                        SObj.SearchString = value;

                        hList.Add(SObj);
                    }



                    buf += value + "\n";
                }

                if (hList.Count() > 0) tList.Add(hList);
            }

            List<PersonData> hFiltered = SE.SearchFiltered(tList, radioButton1.Checked);

            string buffer = $"Поиск по инвертированному списку: найдено {hFiltered.Count()} записей:\n\n\n";

            hView.ShowResult(buffer, hFiltered);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limiter(++Rows);
            label3.Text = Rows.ToString();
            LoadFields();
            Console.WriteLine(Rows.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limiter(--Rows);
            label3.Text = Rows.ToString();
            LoadFields();
            Console.WriteLine(Rows.ToString());
        }
    }
}
