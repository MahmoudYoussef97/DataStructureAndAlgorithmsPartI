using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class ReverseQueue
    {
        public static Queue<int> Reverse(Queue<int> queue)
        {
            Queue<int> reversed = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                reversed.Enqueue(stack.Pop());
            }

            return reversed;
        }
    }
}
