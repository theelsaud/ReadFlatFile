using System.Diagnostics;
using System.Text;

namespace Utils
{
    public class Addons
    {
        private static List<string> Male_Name = new();
        private static List<string> Male_Lastname = new();
        private static List<string> Male_FatherName = new();

        private static List<string> Female_Name = new();
        private static List<string> Female_Lastname = new();
        private static List<string> Female_FatherName = new();

        private static string FileData = "typed_file.txt";
        private static string FileIndexes = "indexes_file.txt";

        public Addons()
        {
            Init();
        }

        public Addons(string DataFile)
        {
            Init();
            FileData = DataFile;
        }
        
        public Addons(string DataFile, string DataIndexes)
        {
            Init();
            FileData = DataFile;
            FileIndexes = DataIndexes;
        }
        
        public static async void Init()
        {
            Male_Name = new List<string>();
            Male_Lastname = new List<string>();
            Male_FatherName = new List<string>();

            Female_Name = new List<string>();
            Female_Lastname = new List<string>();
            Female_FatherName = new List<string>();

            Task task1 = LoadFromFileAsync("generator/Male_Name.txt", Male_Name);
            Task task2 = LoadFromFileAsync("generator/Male_Lastname.txt", Male_Lastname);
            Task task3 = LoadFromFileAsync("generator/Male_FatherName.txt", Male_FatherName);


            Task task4 = LoadFromFileAsync("generator/Female_Name.txt", Female_Name);
            Task task5 = LoadFromFileAsync("generator/Female_Lastname.txt", Female_Lastname);
            Task task6 = LoadFromFileAsync("generator/Female_FatherName.txt", Female_FatherName);

            await Task.WhenAll(task1, task2, task3, task4, task5, task6);

            Console.WriteLine("> Utils Inited!");
        }

        //static void Shuffle<T>(List<T> list)
        //{
        //    Random rng = new Random();
        //    int n = list.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        //}

        //public static string GenerateUniqueId()
        //{
        //    Guid guid = Guid.NewGuid();
        //    return guid.ToString();
        //}


        public static async Task LoadFromFileAsync(string datafile, List<string> data)
        {
            if (!File.Exists(datafile))
            {
                Console.WriteLine("Failed to find: " + datafile);
                return;
            }

            await Task.Run(() =>
            {
                using (var reader = new StreamReader(datafile, Encoding.UTF8))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        data.Add(line);
                    }
                    reader.Close();
                }
            });
        }

        public static int GetRandomInt(int min = 0, int max = 100)
        {
            Random number = new ();
            return number.Next(min, max);
        }

        public static string GetRandomFullName(bool sex)
        {
            if (sex)
            {
                return GetRandomName(Male_Lastname) + " " + GetRandomName(Male_Name) + " " + GetRandomName(Male_FatherName);
            }
            else
            {
                return GetRandomName(Female_Lastname) + " " + GetRandomName(Female_Name) + " " + GetRandomName(Female_FatherName);
            }

        }

        private static string GetRandomName(List<string> data)
        {
            return data[GetRandomInt(0, data.Count - 1)];
        }

        public void GenerateData(int Lines = 1000)
        {
            Console.WriteLine($"> Running Generating data: {Lines} lines");

            GC.Collect();
            Stopwatch sw = Stopwatch.StartNew();

            List<PersonData> data = new();

            int x = 0;
            while (x < Lines)
            {
                bool sex = x % 2 == 0;
                data.Add(new PersonData(GetRandomFullName(sex), sex, x));
                x++;
            }

            // Write Data and Indexes
            FileStream hFile = File.Open(FileData, FileMode.CreateNew);
            FileStream hFileIndexes = File.Open(FileIndexes, FileMode.CreateNew);
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

        public bool AddLine(string fio, string group, string course, bool sex)
        {
            // Проверяем существование файла.
            if (!File.Exists(FileData)) return false;

            string[] lines = File.ReadAllLines(FileData);

            PersonData data = new();

            int id = 0;

            if (lines.Length > 0)
            {
                // Получаем последний присвоенный ID
                bool bState = data.ParseData(lines[lines.Length - 1]);
                if (!bState) return false;
                id = data.GetId() + 1;
            }

            Console.WriteLine(id);

            data = new PersonData(id, fio, group, course, sex);

            string e = data.ExportData();

            File.AppendAllText(FileData, e + "\n");

            int bytes = Encoding.UTF8.GetBytes(e).Count();
            

            Console.WriteLine(bytes.ToString());

            if (!File.Exists(FileIndexes)) {
                FileStream fs = File.Create(FileIndexes);
                fs.Close();
            }

            string[] linesIndexes = File.ReadAllLines(FileIndexes);

            int allBytes = 0;

            if (lines.Length != 0) 
            {
                int lastbytes = Encoding.UTF8.GetBytes(lines[lines.Length - 1]).Count();

                string lastByte = (linesIndexes[linesIndexes.Count() - 1]).Split(",")[1];

                allBytes = lastbytes + Convert.ToInt32(lastByte) + 1;
            }

            //Console.WriteLine(allBytes);
            
            File.AppendAllText(FileIndexes, fio + "," + allBytes.ToString() + "\n");

            Console.WriteLine("Success add data - " + data.GetId().ToString());

            return true;
        }

        public void UpdateFilePath(string filePath)
        {
            FileData = filePath;
        }

        public void ClearData()
        {
            File.Delete(FileData);
            File.Delete(FileIndexes);
        }
    }
}
