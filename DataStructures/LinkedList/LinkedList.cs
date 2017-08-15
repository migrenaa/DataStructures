
namespace DataStructures.LinkedList
{
    using System;
    using System.Collections.Generic;

    public class LinkedList<T> : ILinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public void Append(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(data);
        }

        public void Prepend(T data)
        {
            Node<T> newHead = new Node<T>(data);
            newHead.Next = head;
            head = newHead;
        }


        //BUG DELETES THE ELEMENTS WHILE IT IS PRINTING 
        //Pass by value ?
        public void PrettyPrint()
        {
            var current = head;
            if (current == null)
                Console.WriteLine("The List is empty.");

            Console.Write(string.Format("{0} -> ", current.Value));
            while (current.Next != null)
            {
                Console.Write(string.Format("{0} -> ", current.Next.Value));
                current.Next = current.Next.Next;
            }
        }

        public void RemoveAt(int position)
        {
            if (head == null)
                return;

            if (position == 0)
            {
                head = head.Next;
                return;
            }

            var current = head;
            for (int currentPosition = 0; currentPosition < position; currentPosition++)
            {
                if (current.Next == null)
                    return;

                current = current.Next;
            }
            current.Next = current.Next.Next;
        }



        public void Remove(T element)
        {
            if (head == null)
                return;
            if (EqualityComparer<T>.Default.Equals(head.Value, element))
            {
                head = head.Next;
                return;
            }

            var current = head;

            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Value, element))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public T Head()
        {
            if (this.head == null)
                return default(T);
            return this.head.Value;
        }
    }
}
