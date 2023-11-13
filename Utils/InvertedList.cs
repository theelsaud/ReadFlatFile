using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class InvertedList
    {
        public Dictionary<PersonData.Position, Dictionary<string, List<int>>> InvList;
        public static List<PersonData> personDatas = new();

        public InvertedList()
        {
            InvList = new Dictionary<PersonData.Position, Dictionary<string, List<int>>>();
        }

        public void InitIndexes(List<PersonData> pd)
        {
            personDatas = pd;

            for (int i = 0; i < personDatas.Count; i++)
            {
                for(PersonData.Position pos = 0; pos < PersonData.Position.COUNT; pos++)
                {
                    AddAttribute(pos, i, personDatas[i].GetStringByPos(pos));
                }
            }
        }

        public bool AddAttribute(PersonData.Position pos, int index, string value)
        {
            if (!InvList.ContainsKey(pos))
            {
                InvList[pos] = new Dictionary<string, List<int>>();
            }

            if (!InvList[pos].ContainsKey(value))
            {
                InvList[pos][value] = new List<int>();
            }

            InvList[pos][value].Add(index);

            return true;
        }

        public List<int> Search(PersonData.Position pos, string value)
        {
            if (InvList.ContainsKey(pos) && InvList[pos].ContainsKey(value))
            {
                return InvList[pos][value];
            }
            else
            {
                Console.WriteLine("Значение не найдено в индексе.");
                return new List<int>();
            }
        }

        public List<int> SearchWithPredicate(PersonData.Position pos, Func<string, bool> predicate)
        {
            if (InvList.ContainsKey(pos))
            {
                var matchingValues = InvList[pos].Where(kv => predicate(kv.Key)).SelectMany(kv => kv.Value);
                return matchingValues.ToList();
            }
            else
            {
                Console.WriteLine("Атрибут не найден в индексе.");
                return new List<int>();
            }
        }

        public static List<PersonData> GeneratePersonDataListFromIds(List<int> ids)
        {
            List<PersonData> result = new List<PersonData>();

            foreach (int id in ids)
            {
                result.Add(personDatas[id]);
            }

            return result;
        }
    }
}
