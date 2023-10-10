using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Utils
{
    public class RandomPersonData
    {
        public const string SPLITSYMBOL = "\t|\t"; // 3 bytes

        private enum Position
        {
            ID = 0,
            COURSE,
            GROUP,
            SEX,
            FIO,
            COUNT
        }

        private string id;
        
        private string fio;
        private bool sex;

        private string group;
        private string course;

        public RandomPersonData()
        {
            id = "";
            fio = "";
            sex = false;
            group = "";
            course = "";
        }
        public RandomPersonData(string person, bool sex, int x)
        {
            this.sex = sex;
            fio = person;

            //id = Utils.GenerateUniqueId(x).ToString();
            id = x.ToString();
            group = Addons.GetRandomInt(100, 104).ToString();
            course = Addons.GetRandomInt(1, 4).ToString();
        }
        public RandomPersonData(int id, string fio, string group, string course, bool sex)
        {
            this.sex = sex;
            this.fio = fio;
            this.group = group;
            this.course = course;
            this.id = id.ToString();
        }

        public int GetCountOfBytes()
        {
            return Encoding.UTF8.GetBytes(ExportData()).Count();
        }

        public bool ParseData(string line)
        {
            string[] subs = line.Split(SPLITSYMBOL);

            // Проверяем, что кол-во позиции совпадает
            if(subs.Length != Enum.GetNames(typeof(Position)).Length)
            {
                Console.WriteLine(subs.Length);
                return false;
            }

            id = subs[(int)Position.ID].Trim();
            fio = subs[(int)Position.FIO].Trim();
            sex = subs[(int)Position.SEX].Trim() == "М";
            group = subs[(int)Position.GROUP].Trim();
            course = subs[(int)Position.COURSE].Trim();

            return true;
        }

        public int GetId()
        {
            Console.WriteLine("GetID: " + id);
            return Convert.ToInt32(id);
        }

        public string ExportData()
        {
            return id.PadLeft(8, '0') 
                + SPLITSYMBOL + group.PadRight(4)
                + SPLITSYMBOL + course.PadRight(4)
                + SPLITSYMBOL + (sex ? "M" : "Ж").PadRight(4)
                + SPLITSYMBOL + fio.PadRight(50) + SPLITSYMBOL;
        }

        public string GetFullName()
        {
            return fio;
        }

        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(ExportData() + "\n");
        }
    }
}
