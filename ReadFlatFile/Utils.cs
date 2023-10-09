using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadFlatFile
{
    internal class Utils
    {
        private static List<string> Male_Name;
        private static List<string> Male_Lastname;
        private static List<string> Male_FatherName;


        private static List<string> Female_Name;
        private static List<string> Female_Lastname;
        private static List<string> Female_FatherName;

        private static List<int> UniqueIDs;

        public static async void Init()
        {
            Male_Name = new List<string>();
            Male_Lastname = new List<string>();
            Male_FatherName = new List<string>();

            Female_Name = new List<string>();
            Female_Lastname = new List<string>();
            Female_FatherName = new List<string>();

            UniqueIDs = new List<int>();
            UniqueIDs = Enumerable.Range(1, 10000000).ToList();
            Shuffle(UniqueIDs);

            Task task1 = LoadFromFileAsync("generator/Male_Name.txt", Male_Name);
            Task task2 = LoadFromFileAsync("generator/Male_Lastname.txt", Male_Lastname);
            Task task3 = LoadFromFileAsync("generator/Male_FatherName.txt", Male_FatherName);


            Task task4 = LoadFromFileAsync("generator/Female_Name.txt", Female_Name);
            Task task5 = LoadFromFileAsync("generator/Female_Lastname.txt", Female_Lastname);
            Task task6 = LoadFromFileAsync("generator/Female_FatherName.txt", Female_FatherName);

            await Task.WhenAll(task1, task2, task3, task4, task5, task6);

            Console.WriteLine("> Utils Inited!");
        }

        static void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //public static string GenerateUniqueId()
        //{
        //    Guid guid = Guid.NewGuid();
        //    return guid.ToString();
        //}

        public static int GenerateUniqueId(int x)
        {
            return UniqueIDs[x];
        }

        public static async Task LoadFromFileAsync(string datafile, List<string> data)
        {
            if(!File.Exists(datafile))
            {
                Console.WriteLine("Failed to find: " + datafile);
                return;
            }

            await Task.Run(() =>
            {
                using (var reader = new StreamReader(datafile, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        //data.Append(line);
                        data.Add(line);
                    }

                    //Console.WriteLine($"{data.Count} - {data}");

                    reader.Close();
                }
            });
        }

        public static int GetRandomInt(int min = 0, int max = 100)               
        {
            Random number = new Random();
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
    }
}
