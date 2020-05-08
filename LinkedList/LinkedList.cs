using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        private class Node
        {
            public int value;
            public Node next;
            public Node(int item)
            {
                value = item;
            }
        }
        private Node head;
        private Node tail;
        private int count = 0;
        public void AddLast(int item)
        {
            Node node = new Node(item);
            if (IsEmpty())
            {
                head = tail = node;
                count++;
            }
            else
            {
                tail.next = node;
                tail = node;
                count++;
            }
        }
        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                head = tail = node;
                count++;
            }
            else
            {
                node.next = head;
                head = node;
                count++;
            }
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new ArgumentException();

            if (head == tail)
            {
                head = tail = null;
                return;
            }

            var node = head.next;
            head.next = null;   // Removing from memory for Garbage Collector
            head = node;
            count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
                throw new ArgumentException();

            if (head == tail)
            {
                head = tail = null;
                return;
            }

            var current = GetPrevious(tail);
            tail = current;
            current.next = null;
            count--;
        }
        public int IndexOf(int item)
        {   
            int index = 0;
            var node = head;
            while(node != null)
            {
                if (node.value == item)
                    return index;
                index++;
                node = node.next;
            }
            return -1;
        }
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }
        public void Print()
        {
            var node = head;
            while(node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
        public int Size()
        {
            return count;
        }
        public int[] ToArray()
        {
            int[] array = new int[count];
            var current = head;
            var index = 0;
            while(current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }
        public void Reverse()
        {
            var current = head.next;
            var previous = head;
            tail = head;
            tail.next = null;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }
        public int GetKthFromTheEnd(int index)
        {
            if (count < index || index < 0 || IsEmpty())
                throw new ArgumentException();

            var current = head;
            var firstPointer = head;
            var secondPointer = head;
            var k = 0;
            // Getting the position of second pointer
            while(current != null)
            {
                if (k == index-1)
                    secondPointer = current;
                k++;
                current = current.next;
            }
            while(secondPointer.next != null)
            {
                secondPointer = secondPointer.next;
                firstPointer = firstPointer.next;
            }
            return firstPointer.value;
        }
        private Node GetPrevious(Node node)
        {
            var current = head;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }
        private bool IsEmpty()
        {
            return head == null;
        }
    }
}
