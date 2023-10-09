using System.Runtime.InteropServices;

namespace GUI_7._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Utils.RandomPersonData> data;


            if (checkBox1.Checked)
            {
                data = Utils.SearchEngine.SearchInIndexesFile(textBox1.Text);
            } else
            {
                data = Utils.SearchEngine.SearchInFlatFile(textBox1.Text);
            }

            if(data == null)
            {
                richTextBox1.Text = "Îøèáêà ïîëó÷åíèÿ äàííûõ...";
                return;
            }

            if(data.Count() == 0)
            {
                richTextBox1.Text = "Failed to search - " + textBox1.Text;
                return;
            }

            

            Console.WriteLine(data.Count());

            textBox1.Text = "";
        }

        private void ôàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ñãåíèğèğîâàòü1000ÑòğîêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void êîíñîëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllocConsole();
        }
    }
}