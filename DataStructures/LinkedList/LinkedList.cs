
namespace DataStructures.LinkedList
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation for ILinkedList interface 
    /// </summary>
    
    public class LinkedList<T> : ILinkedList<T>
    {
        //the head of the linked list
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public void Append(T data)
        {
            //if the linked list is empty we are assigning the value to the head
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }

            Node<T> current = head;

            //iterate to the end of the list 
            while (current.Next != null)
            {
                current = current.Next;
            }
            //current is the last element of the list
            //current.Next is our new element
            current.Next = new Node<T>(data);
        }

        public void Prepend(T data)
        {
            //we are creating new head for the linked list
            Node<T> newHead = new Node<T>(data);
            //assign the previous head to be next of the current one
            newHead.Next = head;
            head = newHead;
        }
        
        public void PrettyPrint()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The List is empty.");
                return;
            }

            var current = head;
            Console.Write(string.Format("{0} -> ", current.Value));

            while (current.Next != null)
            {
                Console.Write(string.Format("{0} -> ", current.Next.Value));
                current = current.Next;
            }
        }


        public void RemoveAt(int position)
        {
            //if the list is empty there is nothing to remove 
            if (head == null)
                return;

            //if the position is 0 we want to delete the head 
            //we are changing the head to be the next one
            if (position == 0)
            {
                //head.Value = default(T);
                head = head.Next;
                return;
            }

            var current = head;
            
            //iterating to the position of the element that we want to remove
            //we are iterating through the 'next' of the current, this is why the loop has last value of position - 1
            for (int currentPosition = 1; currentPosition < position - 1; currentPosition++)
            {
                if (current.Next == null)
                    return;

                current = current.Next;
            }
            //remove the element
            current.Next = current.Next.Next;
        }



        public void Remove(T element)
        {
            //if the list is empty there is nothing to remove 
            if (head == null)
                return;

            //if the head value equals the value of the element that we want to delete change the head
            if (EqualityComparer<T>.Default.Equals(head.Value, element))
            {
                head = head.Next;
                return;
            }

            var current = head;

            //iterating to the element that we want to remove
            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Value, element))
                {
                    //remove the element
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
            //if list is empty return default value 
            if (this.head == null)
                return default(T);

            return this.head.Value;
        }
    }
}
