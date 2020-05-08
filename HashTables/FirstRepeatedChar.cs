using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class FirstRepeatedChar
    {   
        public static char Find(string str)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (var ch in str)
            {
                if (set.Contains(ch))
                    return ch;
            }
            return char.MinValue;
        }
    }
}
