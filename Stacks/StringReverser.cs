using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class StringReverser
    {   
        public static string Reverse(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            StringBuilder reversed = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            foreach (var s in str)
            {
                stack.Push(s);
            }
            while (stack.Count != 0)
                reversed.Append(stack.Pop());

            return reversed.ToString();
        }
    }
}
