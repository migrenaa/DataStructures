

namespace DataStructures.Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class QueueLL<T> : IQueue<T>
    {
        public DataStructures.LinkedList.LinkedList<T> linkedList;

        public QueueLL()
        {
            this.linkedList = new DataStructures.LinkedList.LinkedList<T>();
        }
        public void Clear()
        {
            while (!this.IsEmpty())
            {
                this.Dequeue();
            }
        }

        public T Dequeue()
        {
            var head = this.linkedList.Head();
            this.linkedList.RemoveAt(0);
            return head;
        }

        public void Enqueue(T element)
        {
            this.linkedList.Append(element);
        }

        public bool IsEmpty()
        {
            return linkedList.IsEmpty();
        }

        public T Peek()
        {
            return linkedList.Head();
        }
    }
}
