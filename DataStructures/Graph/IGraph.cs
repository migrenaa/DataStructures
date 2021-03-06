﻿
namespace DataStructures.Graph
{
    using System.Collections.Generic;

    public interface IGraph<T>
    {
        Node<T> AddNode(T value, List<Node<T>> neighbours = null);
        Node<T> AddNode(Node<T> node);
        void RemoveNode(Node<T> node);
        void BFS(Node<T> root);
        void DFS(Node<T> root);

    }
}
