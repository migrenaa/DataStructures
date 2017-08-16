
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
        private readonly LinkedList.LinkedList<KeyValue<K, V>>[] items;

        public HashTable(int size)
        {
            this.size = size;
            items = new LinkedList.LinkedList<KeyValue<K, V>>[size];
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Find(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList.LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

            for (int i = 0; i < linkedList.Size(); i++)
            {
                var item = linkedList.GetElement(i);
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
            LinkedList.LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.Append(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList.LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            for (int i = 0; i < linkedList.Size(); i++)
            {
                var item = linkedList.GetElement(i);
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        protected LinkedList.LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList.LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList.LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }
}
