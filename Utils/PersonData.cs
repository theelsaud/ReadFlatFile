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
            course = Addons.GetRandomInt(1, 4).ToString();
            group = Addons.GetRandomInt(100, 104).ToString();
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

            for(int i = 0; i < InputString.Length; i++)
            {
                InputString[i] = InputString[i].Trim();
            }

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
                + SPLITSYMBOL + course.PadRight(4)
                + SPLITSYMBOL + group.PadRight(4)
                + SPLITSYMBOL + (sex ? "М" : "Ж").PadRight(4)
                + SPLITSYMBOL + fio.PadRight(50) + SPLITSYMBOL;
        }

        public bool SearchValided(List<List<ValidateData>> hValidList, bool bAND)
        {
            if (hValidList == null) return true;

            List<bool> bState = new();
            int iCount = SumOfListCounts(hValidList);

            foreach (List<ValidateData> v in hValidList)
            {
                foreach (ValidateData h in v)
                {
                    string data = GetStringByPos(h.Pos);

                    if (h.SearchString.Trim() == data) bState.Add(true);

                    Console.WriteLine($"{h.SearchString.Trim() == data} | {data} - {h.SearchString.Trim()}");
                }
            }

            if(bAND) {
                return iCount == bState.Count();
            } else {
                return bState.Count() > 0;
            }
        }

        public static int SumOfListCounts<T>(List<List<T>> listOfLists)
        {
            int sum = 0;
            foreach (var list in listOfLists)
            {
                sum += list.Count;
            }
            return sum;
        }

        public string GetStringByPos(Position pos)
        {
            Console.WriteLine($"{pos} - {InputString[(int)pos].Trim()}");
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
