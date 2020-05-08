using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Stack
    {
        private int count = 0;
        private int[] stack = new int[5];
        public void Push(int item)
        {
            if (count == stack.Length)
                throw new Exception("StackOverFlowError()");

            stack[count++] = item;
        }
        public int Pop()
        {   
            return stack.Length > 0 ? stack[--count] : throw new Exception("AccessingEmptyStack()");
        }
        public int Peek()
        {
            return stack.Length > 0 ? stack[count - 1] : throw new Exception("AccessingEmptyStack()");
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
