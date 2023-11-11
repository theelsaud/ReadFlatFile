using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class InvertedList
    {
        private Dictionary<PersonData.Position, Dictionary<string, List<int>>> index;
        public List<PersonData> personDatas;

        public InvertedList()
        {
            index = new Dictionary<PersonData.Position, Dictionary<string, List<int>>>();
        }

        
    }
}
