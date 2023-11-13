using GUI.Views;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class MainView : Form
    {
        public static Addons Library = new();
        public static SearchEngine SE = new();

        //[DllImport("kernel32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        private void �������ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

            NativeMethods.AllocConsole();

            string FilePath = textBox4.Text;

            Library = new Addons(FilePath);
            SE = new SearchEngine(FilePath);

            SE.ProgressStatusCB += UpdateProgressCB;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label3.Text = "�����������...";

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

                UpdateRunTime(sw.ElapsedMilliseconds.ToString());

                if (data == null)
                {
                    richTextBox1.Text = "������ ��������� ������...";
                    button1.Enabled = true;
                    return;
                }

                if (data.Count() == 0)
                {
                    richTextBox1.Text = "Data not found for key - " + textBox1.Text;
                    button1.Enabled = true;
                    return;
                }

                string buffer = $"�� ������� {textBox1.Text} ������� {data.Count()} �������:\n\n\n";

                if (checkBox2.Checked)
                {
                    if (data.Count() > 1)
                    {
                        data.RemoveRange(1, data.Count - 1);
                    }
                }

                ShowResult(buffer, data);

                //richTextBox1.Text = ShowResult(buffer, data);

                //textBox1.Text = "";
                button1.Enabled = true;
            });
        }

        public void UpdateRunTime(string time)
        {
            label3.Text = time + " ms";
        }

        public string ShowResult(string buffer, List<PersonData> data)
        {
            string buf = buffer;
            //data.ForEach(x =>
            //{
            //    buffer += $"ID: {x.id}\n";
            //    buffer += $"���: {x.fio}\n";
            //    buffer += $"������: {x.group} (����: {x.course})\n";
            //    buffer += $"���: {(x.sex ? '�' : '�')}\n";
            //    buffer += $"==================================\n\n\n";
            //});

            if (data == null || data.Count() == 0)
            {
                richTextBox1.Text = "Data 0 list";
                return buf;
            }

            data.ForEach(x =>
            {
                for (int i = 0; i < (int)PersonData.Position.COUNT; i++)
                {
                    buf += $"{PersonData.PositionNames[i]}: {x.GetStringByPos((PersonData.Position)i)}\n";
                }

                buf += $"==================================\n\n\n";
            });

            Console.WriteLine(buf);

            richTextBox1.Text = buf;

            return buf;
        }

        private bool CheckFile()
        {
            if (!File.Exists(textBox4.Text))
            {
                Console.WriteLine("CheckFile");

                richTextBox1.Text = "���� [ " + textBox4.Text + " ] �� ������.";
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

        private void �������������1000�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearData();
            Library.GenerateData(1000);
        }

        private void �������������1������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearData();
            Library.GenerateData(1000000);
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                richTextBox1.Text = "������ ��� ���������� ������...";
                return;
            }

            richTextBox1.Text = "������ ������� ��������� - " + textBox2.Text + " (" + textBox3.Text + " - " + comboBox1.Text + ") � " + textBox4.Text;

            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.TabIndex = 0;
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream hFile = File.Create(textBox4.Text);
            hFile.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Library.UpdateFilePath(textBox4.Text);
            SE.UpdateFilePath(textBox4.Text);
        }

        private void ��������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory);
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutView().Show();
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new SearchAttributes(this).Show();
        }

        public RichTextBox GetRichTextBox()
        {
            return richTextBox1;
        }

        public SearchEngine GetSearchEngine()
        {
            return SE;
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchAttributes(this).Show();
        }

        private void �������������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Views.InvertedList(this).Show();
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