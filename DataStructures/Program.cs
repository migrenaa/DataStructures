
namespace DataStructures
{
    using DataStructures.Graph;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            ////TEST QUEUE
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("should be true:{0}", queue.IsEmpty());
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("should be false:{0}", queue.IsEmpty());
            Console.WriteLine("should be 1:{0}", queue.Top());
            Console.WriteLine("should be 1:{0}", queue.Dequeue());
            Console.WriteLine("should be 2:{0}", queue.Top());

            queue.Clear();
            Console.WriteLine("should be true:{0}", queue.IsEmpty());
            queue.Dequeue();


            ////TEST STACK
            DataStructures.Stack.Stack<int> stack = new DataStructures.Stack.Stack<int>();
            Console.WriteLine("should be true:{0}", stack.IsEmpty());

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("should be false:{0}", stack.IsEmpty());

            Console.WriteLine("should be 3:{0}", stack.Top());
            Console.WriteLine("should be 3:{0}", stack.Pop());
            Console.WriteLine("should be 2:{0}", stack.Top());

            stack.Clear();
            Console.WriteLine("should be true:{0}", stack.IsEmpty());

            // TEST GRAPH(oriented, without costs)
            Graph<int> graph = new Graph<int>();
            var node0 = new Node<int>(0);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            node0.AddEdge(node2);
            var neighbors = new List<Node<int>> { node0, node2, node3 };
            var newNode = graph.AddNode(1, neighbors);
            Console.WriteLine("-------BFS-------");
            graph.BFS(newNode);
            Console.WriteLine("-----------------");
            Console.WriteLine(graph.ToString());
            graph.RemoveNode(newNode);
            Console.WriteLine("-----------------");
            var graphToString = graph.ToString();
            Console.WriteLine(graphToString == "" ? "The Graph is empty" : graphToString);

            ////TEST LINKED LIST
            DataStructures.LinkedList.LinkedList<int> linkedList = new DataStructures.LinkedList.LinkedList<int>();
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.PrettyPrint();
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            linkedList.Remove(4);
            linkedList.PrettyPrint();
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
        }
    }
}
