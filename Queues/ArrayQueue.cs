using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class ArrayQueue
    {
        private int[] queue;
        private int front;
        private int rear;
        private int count;
        public ArrayQueue(int capacity)
        {
            queue = new int[capacity];
        }
        public void Enqueue(int item)
        {
            if (count == queue.Length)
                throw new Exception("FULL");

            queue[rear] = item;
            rear = (rear + 1) % queue.Length;
            count++;
        }
        public int Dequeue()
        {
            var item = queue[front];
            count--;
            queue[front] = 0;
            front = (front + 1) % queue.Length;

            return item;
        }
        public int Peek()
        {
            return queue[front];
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            return count == queue.Length;
        }
    }
}
