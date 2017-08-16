

namespace DataStructures.Tree
{
    public interface IBinarySearchTree<T>
    {
        T Root();
        Node<T> Insert(Node<T> root, T value);
        Node<T> GetRootNode();
        void Print();
        Node<T> Search(Node<T> _root, T value);
    }
}
