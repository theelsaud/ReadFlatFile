﻿using System.Text;

namespace Utils
{
    public struct PersonData
    {
        private const string SPLITSYMBOL = "\t|\t"; // 3 bytes

        private enum Position
        {
            ID = 0,
            COURSE,
            GROUP,
            SEX,
            FIO,
            COUNT
        }

        public string id { get; private set; }
        public string fio { get; private set; }
        public bool sex { get; private set; }
        public string group { get; private set; }
        public string course { get; private set; }

        public PersonData()
        {
            id = "";
            fio = "";
            sex = false;
            group = "";
            course = "";
        }
        public PersonData(string person, bool sex, int x)
        {
            this.sex = sex;
            fio = person;

            //id = Utils.GenerateUniqueId(x).ToString();
            id = x.ToString();
            group = Addons.GetRandomInt(100, 104).ToString();
            course = Addons.GetRandomInt(1, 4).ToString();
        }

        public PersonData(int id, string fio, string group, string course, bool sex)
        {
            this.sex = sex;
            this.fio = fio;
            this.group = group;
            this.course = course;
            this.id = id.ToString();
        }

        public readonly int GetCountOfBytes()
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

        public readonly int GetId()
        {
            Console.WriteLine("GetID: " + id);
            return Convert.ToInt32(id);
        }

        public readonly string ExportData()
        {
            return id.PadLeft(8, '0') 
                + SPLITSYMBOL + group.PadRight(4)
                + SPLITSYMBOL + course.PadRight(4)
                + SPLITSYMBOL + (sex ? "M" : "Ж").PadRight(4)
                + SPLITSYMBOL + fio.PadRight(50) + SPLITSYMBOL;
        }

        public readonly string GetFullName()
        {
            return fio;
        }

        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(ExportData() + "\n");
        }
    }
}