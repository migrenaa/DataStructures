
namespace DataStructures.Queue
{
    public interface IQueue<T>
    {
        T Top();
        T Dequeue();
        void Enqueue(T element);
        bool IsEmpty();
        void Clear();
    }
}
