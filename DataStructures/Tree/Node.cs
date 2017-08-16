
namespace DataStructures.Tree
{
    using System;

    public class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;

        public Node(T data, Node<T> left = null, Node<T> right = null)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public bool IsLeaf(Node<T> node)
        {
            return (node.right == null && node.left == null);

        }

        public void InsertData(Node<T> parent, T data)
        {
            if (parent == null)
            {
                parent = new Node<T>(data);
                return;
            }
            if (parent.left == null)
            {
                parent.left = new Node<T>(data);
                return;
            }
            if (parent.right == null)
            {
                parent.right = new Node<T>(data);
                return;
            }
            return;

        }
        
        public void Display(Node<T> node)
        {
            if (node == null)
                return;

            Display(node.left);
            Console.Write(" " + node.data);
            Display(node.right);
        }
    }
}
