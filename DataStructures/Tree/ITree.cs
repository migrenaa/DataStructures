

namespace DataStructures.Tree
{
    public interface ITree<T>
    {
        T Root();
        Node<T> Insert(Node<T> root, T value);
        Node<T> GetRootNode();
        void Print();
    }
}
