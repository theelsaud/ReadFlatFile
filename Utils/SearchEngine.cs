using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class SearchEngine
    {
        private static string FILE_DATA = "typed_file.txt";
        private static string FILE_INDEXES = "indexes_file.txt";

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
            List<PersonData> returnData = new List<PersonData>();

            if (!File.Exists(FILE_DATA))
            {
                Console.WriteLine("File not found " + FILE_DATA);
                return null;
            }

            using (var reader = new StreamReader(FILE_DATA))
            {
                int x = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    PersonData data = new PersonData();

                    bool bState = data.ParseData(line);
                    if (!bState)
                    {
                        Console.WriteLine($"Failed to parse data (Line: {x})");
                    }
                    else
                    {
                        if (data.GetFullName().Contains(fio))
                        {
                            Console.WriteLine($"Find on line {x}:\n" + line);
                            returnData.Add(data);
                        }
                    }

                    x++;
                }
            }



            return returnData;
        }

        public List<PersonData> SearchInIndexesFile(string fio)
        {
            List<PersonData> returnData = new List<PersonData>();

            if (!File.Exists(FILE_INDEXES))
            {
                Console.WriteLine("File not found " + FILE_INDEXES);
                return null;
            }

            

            using (var reader = new StreamReader(FILE_INDEXES))
            {
                string line;
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
                }
            }

            return returnData;
        }

        public void UpdateFilePath(string filePath)
        {
            FILE_DATA = filePath;
        }
    }
}
