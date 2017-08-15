

namespace DataStructures.Stack
{
    public interface IStack<T>
    {
        T Pop();
        void Push(T element);
        bool IsEmpty();
        T Top();
        void Clear();

    }
}
