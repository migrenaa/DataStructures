

namespace DataStructures.Stack
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Representation of stach using List
    /// </summary>
    public class Stack<T> : IStack<T>
    {
        private List<T> _elements;

        /// <summary>
        /// constructor with default value null for elements
        /// </summary>
        /// <param name="elements"></param>
        public Stack(List<T> elements = null)
        {
            this._elements = elements == null ? new List<T>() : elements;
        }
        
        public T Top()
        {
            //if the stack is empty return default value
            if (this.IsEmpty())
            {
                return default(T);
            }

            //return the last element from the list
            return this._elements.Last();
        }

        public void Push(T element)
        {
            //adds new element at the end of the list
            this._elements.Add(element);
        }

        public T Pop()
        { 
            //if the stack is empty return default value
            if (this.IsEmpty())
            {
                return default(T);
            }
            //get the element before it deletes it 
            var toRemove = this.Top();
            
            //removes the element
            this._elements.RemoveAt(this._elements.Count - 1);
            return toRemove;
        }
        public void Clear()
        {
            //delete element while the queue is not empty
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
