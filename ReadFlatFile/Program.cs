using System;
using System.Text;
using System.Reflection.PortableExecutable;
using System.Diagnostics;
using System.Collections.Generic;

namespace ReadFlatFile // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        public const string FILE_DATA = "typed_file.txt";
        public const string FILE_INDEXES = "index_file.txt";
        public const string FILE_LOG = "file_log.txt";
        
        public const int COUNTLINES = 1000;

        static void Main(string[] args)
        {
            Utils.Init();
            Init();
            //ReadFlatFile();

            StartSearchEngine(args);
        }

        static void StartSearchEngine(string[] args)
        {
            string version = "V1";

            if (args.Length > 0)
            {
                version = args[0].Substring(1).ToUpperInvariant();
                Console.WriteLine(version, args);
            }

            Thread.Sleep(500);

            while (true)
            {
                Console.Write($"[{version}] Вставьте данные для поиска: ");
                var fio = Console.ReadLine();

                GC.Collect();
                Stopwatch sw = Stopwatch.StartNew();

                if (version == "V1")
                {
                    SearchInFlatFileV1(fio);
                }
                else
                {
                    SearchInFlatFileV2(fio);
                }

                sw.Stop();
                Console.WriteLine("Bench: " + (sw.ElapsedMilliseconds).ToString() + " ms");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }

        static void SearchInFlatFileV1(string fio)
        {
            using (var reader = new StreamReader(FILE_DATA))
            {
                int x = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    RandomPersonData data = new RandomPersonData();

                    bool bState = data.ParseData(line);
                    if (!bState) {
                        Console.WriteLine($"Failed to parse data (Line: {x})");
                    } else {
                        if(data.GetFullName() == fio)
                        {
                            Console.WriteLine($"Find on line {x}:\n" + line);
                        }
                    }

                    x++;
                }
            }
        }

        // Indexes 
        static void SearchInFlatFileV2(string fio)
        {
            using (var reader = new StreamReader(FILE_INDEXES))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(",");

                    if (data[0] == fio)
                    {
                        FileStream hFile = new FileStream(FILE_DATA, FileMode.Open, FileAccess.Read);

                        long iOffset = long.Parse(data[1]);

                        // Переходим к нужному байту...
                        hFile.Seek(iOffset, SeekOrigin.Begin);

                        MemoryStream memoryStream = new MemoryStream();
                        int currentByte;

                        while ((currentByte = hFile.ReadByte()) != -1)
                        {
                            // Проверяем, является ли текущий байт символом '\n'
                            if (currentByte == '\n')
                            {
                                break; // Если найден символ '\n', завершаем чтение
                            }

                            // Записываем текущий байт в память
                            memoryStream.WriteByte((byte)currentByte);
                        }

                        byte[] resultBytes = memoryStream.ToArray();
                        

                        RandomPersonData person = new RandomPersonData();

                        bool bState = person.ParseData(Encoding.UTF8.GetString(resultBytes));

                        if (!bState)
                        {
                            Console.WriteLine($"Failed to parse data (Byte: {iOffset})");
                        }
                        else
                        {
                            Console.WriteLine($"Find on byte {iOffset}:\n" + person.GetFullName());
                        }

                        memoryStream.Close();
                        hFile.Close();
                    }
                }
            }
        }

        static void ReadFlatFile()
        {
            using (var reader = new StreamReader(FILE_DATA))
            {
                FileStream hFile = new FileStream(FILE_LOG, FileMode.Open, FileAccess.Read);

                int lastlinesize = 0;
                int count = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // line.Length
                    //if (lastlinesize != line.Length)
                    //{
                        byte[] tmp = Encoding.UTF8.GetBytes(line);
                        string v = $"New size > Line: {count} - Length: {line.Length} | Size: {tmp.Length}\n";
                        //byte[] tmp = Encoding.ASCII.GetBytes(v);

                        Console.WriteLine(v);

                        hFile.Write(tmp);
                    //}
                    //Console.WriteLine($"{line} - {line.Length}");

                    count++;
                    lastlinesize = line.Length;
                }

                hFile.Close();
                reader.Close();
            }
        }

        static void Init()
        {
            Console.WriteLine("> Init...");
            if (!File.Exists(FILE_DATA))
            {
                GenerateData(10000000);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void GenerateData(int Lines = COUNTLINES)
        {
            Console.WriteLine($"> Running now");

            GC.Collect();
            Stopwatch sw = Stopwatch.StartNew();

            List<RandomPersonData> data = new List<RandomPersonData>();
            
            int x = 0;
            while (x < Lines)
            {
                bool sex = x % 2 == 0;
                data.Add(new RandomPersonData(Utils.GetRandomFullName(sex), sex, x));
                x++;
            }

            // Write Data and Indexes
            FileStream hFile = File.Open(FILE_DATA, FileMode.CreateNew);
            FileStream hFileIndexes = File.Open(FILE_INDEXES, FileMode.CreateNew);
            x = 0;
            int countbytes = 0;
            while (x < Lines)
            {
                byte[] d = data[x].GetBytes();
                hFile.Write(d);

                string str = $"{data[x].GetFullName()},{countbytes}\n";
                hFileIndexes.Write(Encoding.UTF8.GetBytes(str));

                x++;
                countbytes += d.Length;
            }

            sw.Stop();
            Console.WriteLine("> Complete after " + (sw.ElapsedMilliseconds).ToString() + " ms");

            hFileIndexes.Close();
            hFile.Close();
        }
    }
}