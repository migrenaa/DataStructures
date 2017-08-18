
namespace DataStructures.Queue
{
    using System.Collections.Generic;
    using System.Linq;


    /// <summary>
    /// Representation of queue using List
    /// </summary>
    public class Queue<T> : IQueue<T>
    {
        private List<T> _elements;
        
        public Queue(List<T> elements = null)
        {
            this._elements = elements == null ? new List<T>() : elements;
        }

        public T Peek()
        {
            return this._elements.FirstOrDefault();
        }

        public void Enqueue(T element)
        {
            this._elements.Add(element);
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }
            var element = this.Peek();
            this._elements.RemoveAt(0);
            return element;
        }

        public void Clear()
        {
            while (!this.IsEmpty())
            {
                this.Dequeue();
            }
        }

        public bool IsEmpty()
        {
            return this._elements.Count == 0;
        }

    }
}
