

namespace DataStructures.Stack
{
    using System.Collections.Generic;
    using System.Linq;

    public class Stack<T> : IStack<T>
    {
        private List<T> _elements;

        public Stack(List<T> elements = null)
        {
            this._elements = elements == null ? new List<T>() : elements;
        }
        public T Top()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }
            return this._elements.Last();
        }

        public void Push(T element)
        {
            this._elements.Add(element);
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }
            var toRemove = this.Top();
            this._elements.RemoveAt(this._elements.Count - 1);
            return toRemove;
        }
        public void Clear()
        {
            while (!this.IsEmpty())
            {
                this.Pop();
            }
        }

        public bool IsEmpty()
        {
            return this._elements.Count == 0;
        }
    }
}
