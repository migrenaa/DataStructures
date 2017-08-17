

namespace DataStructures.Tree
{
    using System;
    using System.Collections.Generic;

    public class BinarySearchTree<T> : IBinarySearchTree<T>
    {
        private Tree.Node<T> root;

        public BinarySearchTree(T _root, Tree.Node<T> left, Tree.Node<T> right)
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

        public Node<T> FindMin(Node<T> node)
        {
            var current = node;

            //loop down to find the leftmost leaf 
            while (current.left != null)
            {
                current = current.left;
            }
            return (current);
        }

        public Node<T> Search(Node<T> _root, T value)
        {
            if (_root == null)
                return null;

            var comparerRes = Comparer<T>.Default.Compare(_root.data, value);
            if (comparerRes == 0)
                return _root;
            else if (comparerRes > 0)
                return Search(_root.left, value);
            else
                return Search(_root.right, value);
        }

        public Node<T> GetRootNode()
        {
            return this.root;
        }


        private Node<T> DeleteN(Node<T> root, Node<T> deleteNode)
        {
            if (root == null)
            {
                return root;
            }
            var comparerRes = Comparer<T>.Default.Compare(deleteNode.data, root.data);
            if (comparerRes < 0)
            {
                root.left = DeleteN(root.left, deleteNode);
            }
            else if (comparerRes > 0)
            {
                root.right = DeleteN(root.right, deleteNode);
            }
            else
            {
                //No child nodes
                if (root.left == null && root.right == null)
                {
                    root = null;
                    return root;
                }
                //No left child
                else if (root.left == null)
                {
                    Node<T> temp = root;
                    root = root.right;
                    temp = null;
                }
                //No right child
                else if (root.right == null)
                {
                    Node<T> temp = root;
                    root = root.left;
                    temp = null;
                }
                //Has both child nodes
                else
                {
                    Node<T> min = FindMin(root.right);
                    root.data = min.data;
                    root.right = DeleteN(root.right, min);
                }
            }
            return root;
        }

        //Public method with arg: int value of node to be deleted
        public void DeleteNode(T x)
        {
            Node<T> deleteNode = new Node<T>(x);
            DeleteN(root, deleteNode);
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
