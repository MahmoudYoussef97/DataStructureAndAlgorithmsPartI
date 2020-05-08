using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array
    {
        private int[] items;
        private int count = 0;
        public Array(int length)
        {
            items = new int[length];
        }
        public void Insert(int item)
        {
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];
                
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                items = newItems;
            }

            items[count++] = item;
        }
        public int IndexOf(int item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == item)
                    return i;
            }
            return -1;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentException();

            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
