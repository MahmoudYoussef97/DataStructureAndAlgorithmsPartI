using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class FirstNonRepeatingChar
    {
        public static char Find(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (dict.ContainsKey(ch))
                {
                    var count = dict[ch];
                    count++;
                    dict[ch] = count;
                }
                else
                    dict.Add(ch, 1);
            }
            foreach (var ch in str)
            {
                if (dict[ch] == 1)
                    return ch;
            }

            return char.MinValue;
        }
    }
}
