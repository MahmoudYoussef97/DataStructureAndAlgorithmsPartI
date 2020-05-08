using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class PriorityQueue
    {
        private int[] queue;
        private int count;
        private int front;
        public PriorityQueue(int capacity)
        {
            queue = new int[capacity];
        }
        public void Add(int item)
        {
            if (IsFull())
                throw new Exception("ArrayIsFull()");

            int i = ShiftItemsToInsert(item);
            queue[i] = item;
            count++;
        }

        private int ShiftItemsToInsert(int item)
        {
            int i;
            for (i = count - 1; i >= front; i--)
            {
                if (queue[i] > item)
                    queue[i + 1] = queue[i];
                else
                    break;
            }
            return i + 1;
        }

        private bool IsFull()
        {
            return count == queue.Length;
        }
        public int Remove()
        {
            if (IsEmpty())
                throw new Exception("ArrayIsFull()");

            return queue[front++];
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
