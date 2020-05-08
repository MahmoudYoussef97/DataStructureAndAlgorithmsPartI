using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class HashTable
    {
        private LinkedList<KeyValuePair>[] hash = new LinkedList<KeyValuePair>[10];
        private class KeyValuePair
        {
            public int key;
            public string value;
            public KeyValuePair(int k, string v)
            {
                key = k;
                value = v;
            }
        }
        public void Add(int key, string value)
        {   
            var index = GetHash(key);
            if (hash[index] == null)
                hash[index] = new LinkedList<KeyValuePair>();

            var buckets = hash[index];
            foreach (var item in buckets)
            {
                if (item.key == key)
                {
                    item.value = value;
                    return;
                }
            }
            KeyValuePair keyValuePair = new KeyValuePair(key, value);
            buckets.AddLast(keyValuePair);
        }
        public string Get(int key)
        {
            var index = GetHash(key);
            var buckets = hash[index];

            if (buckets != null)
            {
                foreach (var item in buckets)
                {
                    if (item.key == key)
                        return item.value;
                }
            }
            return null;
        }
        public void Remove(int key)
        {
            var index = GetHash(key);
            var buckets = hash[index];
            if(buckets != null)
            {
                foreach (var item in buckets)
                {
                    if (item.key == key)
                    {
                        buckets.Remove(item);
                        return;
                    }
                }
            }
            throw new Exception("IllegalState");
        }
        private int GetHash(int key)
        {
            return key % hash.Length;
        }
    }
}
