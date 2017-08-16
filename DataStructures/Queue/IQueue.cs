
namespace DataStructures.Queue
{
    /// <summary>
    /// Represents a first-in, first-out collection of objects.
    /// </summary>
    /// <typeparam name="T">Specifies the type of elements in the queue.</typeparam>
    public interface IQueue<T>
    {
        /// <summary>
        /// Returns the object at the beginning of the Queue<T> without removing it.
        /// </summary>
        T Peek();
        /// <summary>
        /// Removes and returns the object at the beginning of the Queue<T>.
        /// </summary>
        T Dequeue();
        /// <summary>
        /// Adds an object to the end of the Queue<T>.
        /// </summary>
        void Enqueue(T element);
        /// <summary>
        /// Determines if the queue is empty
        /// </summary>
        bool IsEmpty();
        /// <summary>
        /// Removes all objects from the Queue<T>.
        /// </summary>
        void Clear();
    }
}
