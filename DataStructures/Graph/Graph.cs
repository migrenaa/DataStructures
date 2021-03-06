﻿namespace DataStructures.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Graph<T> : IGraph<T>
    {
        private List<Node<T>> nodes;

        public Graph()
        {
            nodes = new List<Node<T>>();
        }

        public Node<T> AddNode(T value, List<Node<T>> neighbours = null)
        {
            var newNode = new Node<T>(value, neighbours);
            foreach (var neighbour in neighbours)
            {
                neighbour.AddEdge(newNode);
            }
            this.nodes.Add(newNode);
            return newNode;
        }

        public Node<T> AddNode(Node<T> node)
        {
            this.nodes.Add(node);
            return node;
        }

        public void RemoveNode(Node<T> node)
        {
            var neighbours = this.nodes.Where(x => x.Neighbors.Contains(node));
            foreach (var neighbour in neighbours)
            {
                neighbour.RemoveEdge(node);
            }
            this.nodes.Remove(node);
        }

        public void BFS(Node<T> root)
        {
            DataStructures.Queue.Queue<Node<T>> queue = new DataStructures.Queue.Queue<Node<T>>();
            queue.Enqueue(root);
            while (!queue.IsEmpty())
            {
                Node<T> current = queue.Dequeue();
                if (current == null)
                    continue;

                foreach (var neighbor in current.Neighbors)
                {
                    queue.Enqueue(neighbor);
                }
                //DO SOMETHING WITH THE CURRENT NODE
                Console.WriteLine($"{current.Value} => ");
            }
        }

        public void DFS(Node<T> start)
        {
            var visited = new List<Node<T>>();
            var stack = new DataStructures.Stack.Stack<Node<T>>();
            stack.Push(start);

            while (!stack.IsEmpty())
            {
                var current = stack.Pop();

                if (visited.Contains(current))
                    continue;

                visited.Add(current);

                var neighbours = current.Neighbors
                                        .Where(n => !visited.Contains(n));

                foreach (var neighbour in neighbours)
                    stack.Push(neighbour);

                //DO SOMETHING 
                Console.WriteLine($"{current.Value} => ");
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var node in nodes)
            {
                stringBuilder.Append(node.ToString());
            }
            return stringBuilder.ToString();
        }

    }
}
