

namespace DataStructures.Stack
{
    public class StackLL<T> : IStack<T>
    {
        public DataStructures.LinkedList.LinkedList<T> _linkedList;

        public StackLL()
        {
            this._linkedList = new DataStructures.LinkedList.LinkedList<T>();
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

        public T Pop()
        {
            var head = this._linkedList.Head();
            this._linkedList.RemoveAt(0);
            return head;
        }

        public void Push(T element)
        {
            this._linkedList.Prepend(element);
        }

        public T Top()
        {
            return this._linkedList.Head();
        }
    }
}
