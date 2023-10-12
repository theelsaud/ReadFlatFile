using System.Diagnostics;
using System.Runtime.InteropServices;
using Utils;

namespace GUI_7._0
{
    public partial class MainView : Form
    {
        private static Addons Library = new();
        private static SearchEngine SE = new();

        //[DllImport("kernel32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        private void êîíñîëüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);

            if (NativeMethods.AllocConsole())
            {
                IntPtr s = NativeMethods.GetStdHanle(NativeMethods.sr);
                Console.WriteLine("ASD");
            }
            else
            {
                Console.WriteLine("AC");
            }
        }

        public MainView()
        {
            InitializeComponent();

            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);

            //NativeMethods.AllocConsole();

            string FilePath = textBox4.Text;

            Library = new Addons(FilePath);
            SE = new SearchEngine(FilePath);

            SE.ProgressStatusCB += UpdateProgressCB;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label3.Text = "Âûïîëíÿåòñÿ...";

            await Task.Run(() =>
            {
                if (!CheckFile())
                {
                    button1.Enabled = true;
                    return;
                }

                List<PersonData> data;

                string filePath = textBox1.Text.Trim();

                GC.Collect();
                Stopwatch sw = Stopwatch.StartNew();

                if (checkBox1.Checked)
                {
                    data = SE.SearchInIndexesFile(filePath);
                }
                else
                {
                    data = SE.SearchInFlatFile(filePath);
                }

                sw.Stop();

                label3.Text = sw.ElapsedMilliseconds.ToString() + " ms";

                if (data == null)
                {
                    richTextBox1.Text = "Îøèáêà ïîëó÷åíèÿ äàííûõ...";
                    button1.Enabled = true;
                    return;
                }

                if (data.Count() == 0)
                {
                    richTextBox1.Text = "Data not found for key - " + textBox1.Text;
                    button1.Enabled = true;
                    return;
                }

                string buffer = $"Ïî çàïðîñó {textBox1.Text} íàéäåíî {data.Count()} çàïèñåé:\n\n\n";

                if (checkBox2.Checked)
                {
                    var x = data[0];
                    buffer += $"ID: {x.id}\n";
                    buffer += $"ÔÈÎ: {x.fio}\n";
                    buffer += $"Ãðóïïà: {x.group} (Êóðñ: {x.course})\n";
                    buffer += $"Ïîë: {(x.sex ? 'Æ' : 'Ì')}\n";
                    buffer += $"==================================\n\n\n";
                }
                else
                {
                    data.ForEach(x =>
                    {
                        buffer += $"ID: {x.id}\n";
                        buffer += $"ÔÈÎ: {x.fio}\n";
                        buffer += $"Ãðóïïà: {x.group} (Êóðñ: {x.course})\n";
                        buffer += $"Ïîë: {(x.sex ? 'Æ' : 'Ì')}\n";
                        buffer += $"==================================\n\n\n";
                    });
                }

                richTextBox1.Text = buffer;

                //textBox1.Text = "";
                button1.Enabled = true;
            });
        }

        private bool CheckFile()
        {
            if (!File.Exists(textBox4.Text))
            {
                Console.WriteLine("CheckFile");

                richTextBox1.Text = "Ôàéë [ " + textBox4.Text + " ] íå íàéäåí.";
                return false;
            }

            return true;
        }

        public void UpdateProgressCB(int procentage)
        {
            Console.WriteLine($"UpdateProgressCB {procentage}");

            if (procentage > 99 || procentage < 1)
            {
                //progressBar1.Visible = false;
                progressBar1.Value = procentage;
                return;
            }

            //progressBar1.Visible = true;
            progressBar1.Value = procentage;
        }

        public void RefreshProgressBar(int iValue)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.Value = iValue; }));
            }
            else
            {
                progressBar1.Value = iValue;
            }
        }

        private void ñãåíèðèðîâàòü1000ÑòðîêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearData();
            Library.GenerateData(1000);
        }

        private void ñãåíèðèðîâàòü1ÌÑòðîêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearData();
            Library.GenerateData(1000000);
        }

        private void î÷èñòèòüÄàííûåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ClearData");
            Library.ClearData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckFile())
                return;
            //textBox2.Text;

            bool bState = Library.AddLine(textBox2.Text, textBox3.Text, comboBox1.Text, radioButton1.Checked);

            if (!bState)
            {
                richTextBox1.Text = "Îøèáêà ïðè äîáàâëåíèè äàííûõ...";
                return;
            }

            richTextBox1.Text = "Äàííûå óñïåøíî äîáàâëåíû - " + textBox2.Text + " (" + textBox3.Text + " - " + comboBox1.Text + ") â " + textBox4.Text;

            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.TabIndex = 0;
        }

        private void ñîçäàòüÏóñòîéÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream hFile = File.Create(textBox4.Text);
            hFile.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Library.UpdateFilePath(textBox4.Text);
            SE.UpdateFilePath(textBox4.Text);
        }

        private void îòêðûòüÏàïêóÑÔàéëàìèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory);
        }

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutView().Show();
        }

    }

    public partial class NativeMethods
    {
        public static Int32 sr = -11;

        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle")]
        public static extern IntPtr GetStdHanle(Int32 st);

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
    }
}