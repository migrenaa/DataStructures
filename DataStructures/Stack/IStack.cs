

namespace DataStructures.Stack
{
    /// <summary>
    /// Represents a simple last-in-first-out (LIFO) generic collection of objects.
    /// </summary>
    /// <typeparam name="T">Specifies the type of elements in the queue.</typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Removes and returns the object at the top of the Stack.
        /// </summary>
        T Pop();


        /// <summary>
        /// Inserts an object at the top of the Stack.
        /// </summary>
        void Push(T element);
        
        
        /// <summary>
        /// Determines if the stack is empty
        /// </summary>
        bool IsEmpty();


        /// <summary>
        /// Returns the object at the top of the Stack without removing it.
        /// </summary>
        T Top();
        
        
        /// <summary>
        /// Removes all objects from the Stack.
        /// </summary>
        void Clear();

    }
}
