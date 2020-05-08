using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "abcd";
            //Console.WriteLine(StringReverser.Reverse(str));
            //string expression = "([<{}>])";
            //BalancedExpression balancedExpression = new BalancedExpression();
            //var result = balancedExpression.IsBalanced(expression);
            //Console.WriteLine(result);
            var stack = new StackByLinkedList();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Print();
            
        }
    }
}
