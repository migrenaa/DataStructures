

namespace DataStructures.Tree
{
    using System;
    using System.Collections.Generic;

    public class Tree<T> : ITree<T>
    {
        private Tree.Node<T> root;

        public Tree(T _root, Tree.Node<T> left, Tree.Node<T> right)
        {
            this.root = new Tree.Node<T>(_root, left, right);
        }

        public T Root()
        {
            return this.root.data;
        }
        
        public Node<T> Insert(Node<T> root, T value)
        {
            if (root == null)
            {
                Node<T> node = new Node<T>(value);
                root = node;
                return root;
            }
            var comparerRes = Comparer<T>.Default.Compare(root.data, value);
            if (comparerRes > 0)
                root.left = Insert(root.left, value);
            else if (comparerRes < 0)
                root.right = Insert(root.right, value);
            return root;
        }
        
        public Node<T> GetRootNode()
        {
            return this.root;
        }
       

        public void Print()
        {
            print(this.root, "", true);
        }

        private void print(Node<T> node, String prefix, bool isTail)
        {
            if (node == null) return;
            Console.WriteLine(prefix + (isTail ? "└── " : "├── ") + node.data);
            print(node.left, prefix + (isTail ? "    " : "│   "), false);
            print(node.right, prefix + (isTail ? "    " : "│   "), false);
        }
    }
}
