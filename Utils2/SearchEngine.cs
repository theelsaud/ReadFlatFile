using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils2
{
    public class SearchEngine
    {
        public const string FILE_DATA = "typed_file.txt";
        public const string FILE_INDEXES = "typed_file.txt";

        public static List<RandomPersonData> SearchInFlatFile(string fio)
        {
            List<RandomPersonData> returnData = new List<RandomPersonData>();

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
                    RandomPersonData data = new RandomPersonData();

                    bool bState = data.ParseData(line);
                    if (!bState)
                    {
                        Console.WriteLine($"Failed to parse data (Line: {x})");
                    }
                    else
                    {
                        if (data.GetFullName().Equals(fio))
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

        public static List<RandomPersonData> SearchInIndexesFile(string fio)
        {
            List<RandomPersonData> returnData = new List<RandomPersonData>();

            if (!File.Exists(FILE_INDEXES))
            {
                Console.WriteLine("File not found " + FILE_INDEXES);
                return null;
            }

            return returnData;
        }
    }
}
