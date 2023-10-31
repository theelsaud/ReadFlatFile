using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Utils
{
    public struct PersonData
    {
        private const string SPLITSYMBOL = "\t|\t"; // 3 bytes

        public enum Position
        {
            ID = 0,
            COURSE,
            GROUP,
            SEX,
            FIO,
            COUNT
        }

        public static readonly string[] PositionNames = new string[]
        {
            "ID",
            "Курс",
            "Группа",
            "Пол",
            "ФИО"
        };

        public enum Operator
        {
            Equals = 0,
            GreaterThan = 1,
            LessThan = 2
        }

        public struct ValidateData
        {
            public Position Pos;
            //public Operator Operator = Operator.Equals;
            public string SearchString;

            public ValidateData() { }
        }

        private string[] InputString;

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
            InputString = line.Split(SPLITSYMBOL);

            // Проверяем, что кол-во позиции совпадает
            if (InputString.Length != Enum.GetNames(typeof(Position)).Length)
            {
                Console.WriteLine(InputString.Length);
                return false;
            }

            id = GetStringByPos(Position.ID);
            fio = GetStringByPos(Position.FIO);
            sex = GetStringByPos(Position.SEX) == "М";
            group = GetStringByPos(Position.GROUP);
            course = GetStringByPos(Position.COURSE);

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

        public bool SearchValided(List<ValidateData> hValidList, bool bAND)
        {
            if (hValidList == null) return true;

            List<bool> bState = new();

            foreach (ValidateData v in hValidList)
            {
                string data = GetStringByPos(v.Pos);

                if (data == v.SearchString.Trim()) bState.Add(true);
            }

            if(bAND) {
                return hValidList.Count() == bState.Count();
            } else {
                return bState.Count() > 0;
            }
        }

        public string GetStringByPos(Position pos)
        {
            return InputString[(int)pos].Trim();
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
