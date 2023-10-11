using System;
using System.Text;

namespace Utils
{
    public class SearchEngine
    {
        public Action<int>? ProgressStatusCB;

        private static string FILE_DATA = "typed_file.txt";
        private static string FILE_INDEXES = "indexes_file.txt";

        static readonly int DELAY = 0;
        

        public SearchEngine()
        {
        }

        public SearchEngine(string FilePath)
        {
            FILE_DATA = FilePath;
        }

        public SearchEngine(string FilePath, string FileIndexes)
        {
            FILE_DATA = FilePath;
            FILE_INDEXES = FileIndexes;
        }

        public List<PersonData> SearchInFlatFile(string fio)
        {
            List<PersonData> returnData = new();

            if (!File.Exists(FILE_DATA))
            {
                Console.WriteLine("File not found " + FILE_DATA);
                return returnData;
            }

            int CountOfLines = GetCountLineOnFile(FILE_DATA), 
                x = 0;

            using (var reader = new StreamReader(FILE_DATA))
            {
                
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    PersonData data = new();

                    bool bState = data.ParseData(line);
                    if (!bState)
                    {
                        Console.WriteLine($"Failed to parse data (Line: {x+1})");
                    }
                    else
                    {
                        if (data.GetFullName().Contains(fio))
                        {
                            Console.WriteLine($"Find on line {x+1}:\n" + line);
                            returnData.Add(data);
                        }
                    }

                    x++;

                    if(ProgressStatusCB != null) ProgressStatusCB(GetPercentage(x, CountOfLines));

                    if(DELAY > 0) Thread.Sleep(DELAY);
                }
            }

            return returnData;
        }

        public int GetPercentage(int part, int whole)
        {
            if (whole == 0)
            {
                // Предотвратить деление на ноль, если "whole" равно нулю.
                return 0;
            }

            double result = (double)part / whole * 100;
            return (int)Math.Round(result);
        }

        public List<PersonData> SearchInIndexesFile(string fio)
        {
            List<PersonData> returnData = new List<PersonData>();

            if (!File.Exists(FILE_INDEXES))
            {
                Console.WriteLine("File not found " + FILE_INDEXES);
                return returnData;
            }

            using (var reader = new StreamReader(FILE_INDEXES))
            {
                string? line;
                int CountOfLines = GetCountLineOnFile(FILE_INDEXES), x = 0;



                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(",");
                    //Console.Write(data[0] + "\n");

                    if (data[0].Contains(fio))
                    {
                        FileStream hFile = new FileStream(FILE_DATA, FileMode.Open, FileAccess.Read);

                        Console.Write("test\n");

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


                        PersonData person = new PersonData();

                        bool bState = person.ParseData(Encoding.UTF8.GetString(resultBytes));

                        if (!bState)
                        {
                            Console.WriteLine($"Failed to parse data (Byte: {iOffset})");
                        }
                        else
                        {
                            Console.WriteLine($"Find on byte {iOffset}:\n" + person.GetFullName());
                            returnData.Add(person);
                        }

                        

                        memoryStream.Close();
                        hFile.Close();
                    }

                    x++;

                    if (ProgressStatusCB != null) ProgressStatusCB(GetPercentage(x, CountOfLines));

                    if (DELAY > 0) Thread.Sleep(DELAY);
                }
            }

            return returnData;
        }

        public int GetCountLineOnFile(string filePath)
        {
            if(File.Exists(filePath))
            {
                var file = new StreamReader(filePath).ReadToEnd(); // big string
                var lines = file.Split(new char[] { '\n' });           // big array
                if (lines != null)
                {
                    return lines.Length;
                }
            }

            return 0;
        }

        public void UpdateFilePath(string filePath)
        {
            FILE_DATA = filePath;
        }
    }
}
