using System.Diagnostics;
using System.Runtime.InteropServices;
using Utils;

namespace GUI_7._0
{
    public partial class Form1 : Form
    {
        private static Addons Library;

        public Form1()
        {
            InitializeComponent();
            Library = new Addons(textBox4.Text);
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

            List<Utils.RandomPersonData> data;

            GC.Collect();
            Stopwatch sw = Stopwatch.StartNew();

            

            if (checkBox1.Checked)
            {
                data = Utils.SearchEngine.SearchInIndexesFile(textBox1.Text);
            }
            else
            {
                data = Utils.SearchEngine.SearchInFlatFile(textBox1.Text);
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

            richTextBox1.Text = data[0].ExportData();

            Console.WriteLine(data.Count());

            textBox1.Text = "";
        }

        private bool CheckFile()
        {
            Console.WriteLine("CheckFile");

            if (!File.Exists(textBox4.Text))
            {
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
            Library.GenerateData(1000000);
        }

        private void очиститьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ClearData");
            Library.ClearData();
        }
    }
}