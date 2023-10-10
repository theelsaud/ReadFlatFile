using System.Diagnostics;
using System.Runtime.InteropServices;
using Utils;

namespace GUI_7._0
{
    public partial class Form1 : Form
    {
        private static Addons Library = new();
        private static SearchEngine SEwww = new();

        public Form1()
        {
            InitializeComponent();

            string FilePath = textBox4.Text;

            Library = new Addons(FilePath);
            SEwww = new SearchEngine(FilePath);

            AllocConsole();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFile()) return;

            List<PersonData> data;

            GC.Collect();
            Stopwatch sw = Stopwatch.StartNew();



            if (checkBox1.Checked)
            {
                data = SEwww.SearchInIndexesFile(textBox1.Text.Trim());
            }
            else
            {
                data = SEwww.SearchInFlatFile(textBox1.Text.Trim());
            }

            sw.Stop();

            label3.Text = sw.ElapsedMilliseconds.ToString() + " ms";

            if (data == null)
            {
                richTextBox1.Text = "Ошибка получения данных...";
                return;
            }

            if (data.Count() == 0)
            {
                richTextBox1.Text = "Data not found for key - " + textBox1.Text;
                return;
            }

            string buffer = "";

            if(checkBox2.Checked) {
                var x = data[0];
                buffer += $"ID: {x.id}\n";
                buffer += $"ФИО: {x.fio}\n";
                buffer += $"Группа: {x.group} (Курс: {x.course})\n";
                buffer += $"Пол: {(x.sex ? 'Ж' : 'М')}\n";
                buffer += $"==================================\n\n\n";
            } else {
                data.ForEach(x =>
                {
                    buffer += $"ID: {x.id}\n";
                    buffer += $"ФИО: {x.fio}\n";
                    buffer += $"Группа: {x.group} (Курс: {x.course})\n";
                    buffer += $"Пол: {(x.sex ? 'Ж' : 'М')}\n";
                    buffer += $"==================================\n\n\n";
                });
            }

            richTextBox1.Text = buffer;

            textBox1.Text = "";
        }

        private bool CheckFile()
        {
            if (!File.Exists(textBox4.Text))
            {
                Console.WriteLine("CheckFile");

                richTextBox1.Text = "Файл [ " + textBox4.Text + " ] не найден.";
                return false;
            }

            return true;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void сгенирировать1000СтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearData();
            Library.GenerateData(1000);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        public void консольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void сгенирировать1МСтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearData();
            Library.GenerateData(1000000);
        }

        private void очиститьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ClearData");
            Library.ClearData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckFile())
                return;
            //textBox2.Text;

            bool bState = Library.AddLine(textBox2.Text, textBox3.Text, comboBox1.Text, radioButton1.Checked);

            if(!bState)
            {
                richTextBox1.Text = "Ошибка при добавлении данных...";
                return;
            }

            richTextBox1.Text = "Данные успешно добавлены - " + textBox2.Text + " (" + textBox3.Text + " - " + comboBox1.Text + ") в " + textBox4.Text;

            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.TabIndex = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void создатьПустойФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream hFile = File.Create(textBox4.Text);
            hFile.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Library.UpdateFilePath(textBox4.Text);
            SEwww.UpdateFilePath(textBox4.Text);
        }

        private void открытьПапкуСФайламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory);
        }
    }
}