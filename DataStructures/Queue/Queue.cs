using DataStructures.Queue;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DataStructures
{
    public class Queue<T> : IQueue<T>
    {
        private List<T> _elements;


        public Queue(List<T> elements = null)
        {
            this._elements = elements == null ? new List<T>() : elements;
        }
        public bool IsEmpty()
        {
            return this._elements.Count == 0;
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }
            var element = this.Top();
            this._elements.RemoveAt(0);
            return element;
        }

        public void Enqueue(T element)
        {
            this._elements.Add(element);
        }

        public T Top()
        {
            return this._elements.FirstOrDefault();
        }

        public void Clear()
        {
            while (!this.IsEmpty())
            {
                this.Dequeue();
            }
        }
    }
}
