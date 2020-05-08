using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class StackQueue
    {
        Stack<int> first = new Stack<int>();
        Stack<int> second = new Stack<int>();
        public void Enqueue(int item)
        {
            first.Push(item);
        }
        public int Dequeue()
        {
            if (first.Count == 0 && second.Count == 0)
                throw new Exception("Illegal");

            if(second.Count == 0)
                while (first.Count > 0)
                    second.Push(first.Pop());

            return second.Pop();
        }
        public int Peek()
        {
            if (first.Count == 0 && second.Count == 0)
                throw new Exception("Illegal");

            while (first.Count > 0 && second.Count == 0)
                second.Push(first.Pop());

            return second.Peek();
        }

        public bool IsEmpty()
        {
            return first.Count > 0 && second.Count > 0;
        }
    }
}