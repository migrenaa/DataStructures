using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    //Oriented without costs
    public class Node<T>
    {
        public List<Node<T>> Neighbors { get; set; }
        public T Value { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Neighbors = new List<Node<T>>();
        }

        public Node(T value, List<Node<T>> neighbors)
        {
            this.Value = value;
            this.Neighbors = neighbors;
        }


        public void AddEdge(Node<T> vertex)
        {
            this.Neighbors.Add(vertex);
        }

        public void AddEdges(List<Node<T>> newNeighbors)
        {
            this.Neighbors.AddRange(newNeighbors);
        }

        public void RemoveEdge(Node<T> vertex)
        {
            this.Neighbors.Remove(vertex);
        }

        public override string ToString()
        {
            var neighbors = ToStringMany(this.Neighbors);
            var node = string.Format("current node value: {0},{1} current node neighbors: {2}", this.Value, Environment.NewLine, neighbors == string.Empty ? "no neighbors" : neighbors);
            return node;
        }

        private string ToStringMany(List<Node<T>> nodes)
        {
            var stringBuilder = new StringBuilder();
            foreach (var node in nodes)
            {
                stringBuilder.Append(string.Format("current node value: {0}{1}", node.Value, Environment.NewLine));
            }
            return stringBuilder.ToString();
        }
    }
}
