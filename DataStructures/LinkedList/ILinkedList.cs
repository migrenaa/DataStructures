

namespace DataStructures.LinkedList
{
    public interface ILinkedList<T>
    {
        void Append(T value);
        void Prepend(T value);
        void Remove(T element);
        bool IsEmpty();
        void PrettyPrint();
        T Head();
    }
}
