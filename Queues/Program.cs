using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue priorityQueue = new PriorityQueue(5);
            priorityQueue.Add(5);
            priorityQueue.Add(7);
            priorityQueue.Add(1);
            priorityQueue.Add(3);
            priorityQueue.Add(4);
            while (!priorityQueue.IsEmpty())
            {
                Console.WriteLine(priorityQueue.Remove());
            }
        }
    }
}
