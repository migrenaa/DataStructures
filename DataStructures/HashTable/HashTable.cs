
namespace DataStructures.HashTable
{
    using System;
    using System.Collections.Generic;


    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }

    public class HashTable<K, V>
    {
        private readonly int size;
        private readonly List<KeyValue<K, V>>[] items;

        public HashTable(int size)
        {
            this.size = size;
            items = new List<KeyValue<K, V>>[size];
        }

        private int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Find(K key)
        {
            int position = GetArrayPosition(key);
            List<KeyValue<K, V>> list = GetList(position);

            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            List<KeyValue<K, V>> list = GetList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            list.Add(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            List<KeyValue<K, V>> list = GetList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

            if (itemFound)
            {
                list.Remove(foundItem);
            }
        }

        protected List<KeyValue<K, V>> GetList(int position)
        {
            List<KeyValue<K, V>> list = items[position];
            if (list == null)
            {
                list = new List<KeyValue<K, V>>();
                items[position] = list;
            }
            return list;
        }
    }
}
