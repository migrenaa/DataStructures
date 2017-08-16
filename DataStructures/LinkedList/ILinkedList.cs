

namespace DataStructures.LinkedList
{
    /// <summary>
    /// Represents a linked list.
    /// </summary>
    /// <typeparam name="T">Specifies the element type of the linked list.</typeparam>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// Adds element in the end of the list
        /// </summary>
        /// <param name="value">the value of the element</param>
        void Append(T value);
        /// <summary>
        /// Adds element in the beginning of the list
        /// </summary>
        /// <param name="value">the value of the element</param>
        void Prepend(T value);
        /// <summary>
        /// Removes element from the list by value
        /// </summary>
        /// <param name="value">the value of the element</param>
        void Remove(T element);
        /// <summary>
        /// Checks if the list is empty
        /// </summary>
        /// <returns>true -> empty, false -> not empty</returns>
        bool IsEmpty();
        /// <summary>
        /// Displays the list
        /// </summary>
        void PrettyPrint();
        /// <summary>
        /// Gets the value of the head of the list
        /// </summary>
        /// <returns>Type T -> the value</returns>
        T Head();
    }
}
