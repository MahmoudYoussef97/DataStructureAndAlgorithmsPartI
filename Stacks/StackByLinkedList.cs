using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class StackByLinkedList
    {
        private int count = 0;
        private Node head;
        private Node tail;
        protected class Node
        {
            public readonly int value;
            public Node next;
            public Node(int item)
            {
                value = item;
            }
        }

        public void Push(int item)
        {
            var node = new Node(item);
            if (count == 0)
            {
                head = tail = node;
                count++;
                return;
            }
            tail.next = node;
            tail = node;
            count++;
        }
        public int Pop()
        {
            if (count == 0)
                throw new Exception("StackIsEmpty()");

            int top = tail.value;
            var current = head;
            while (current.next != null)
            {
                if (current.next == tail)
                {
                    tail = current;
                    count--;
                }
                current = current.next;
            }

            return top;
        }
        public int Peek()
        {
            return count > 0 ? tail.value : throw new Exception("StackIsEmpty()");
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public int Length()
        {
            return count;
        }
        public void Print()
        {
            int index = count;
            int top;
            while(index != 0)
            {
                top = Pop();
                Console.WriteLine(top);
                index--;
            }
        }
    }
}
