

namespace DataStructures.Stack
{    /// <summary>
     /// Representation of stach using our LinkedList class
     /// </summary>
    public class StackLL<T> : IStack<T>
    {
        public DataStructures.LinkedList.LinkedList<T> _linkedList;


        public StackLL()
        {
            this._linkedList = new DataStructures.LinkedList.LinkedList<T>();
        }

        public T Top()
        {
            return this._linkedList.Head();
        }

        public void Push(T element)
        {
            this._linkedList.Prepend(element);
        }

        public T Pop()
        {
            var head = this._linkedList.Head();
            this._linkedList.RemoveAt(0);
            return head;
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
            return this._linkedList.IsEmpty();
        }
    }
}
