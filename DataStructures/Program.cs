namespace DataStructures
{
    using DataStructures.Graph;
    using DataStructures.Queue;
    using DataStructures.Stack;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            var queuell = new QueueLL<int>();
            Console.WriteLine("Test queue implementation with array");
            TestQueue(queue);
            Console.WriteLine();
            Console.WriteLine("Test queue implementation with linked list");
            TestQueue(queuell);

            Console.WriteLine();
            var stack = new Stack.Stack<int>();
            var stackll = new StackLL<int>();
            Console.WriteLine("Test stack implementation with array");
            TestStack(stack);
            Console.WriteLine();
            Console.WriteLine("Test stack implementation with linked list");
            TestStack(stackll);
        }

        static void TestQueue(IQueue<int> queue)
        {
            Console.WriteLine("should be true:{0}", queue.IsEmpty());
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("should be false:{0}", queue.IsEmpty());
            Console.WriteLine("should be 1:{0}", queue.Peek());
            Console.WriteLine("should be 1:{0}", queue.Dequeue());
            Console.WriteLine("should be 2:{0}", queue.Peek());

            queue.Clear();
            Console.WriteLine("should be true:{0}", queue.IsEmpty());
            queue.Dequeue();

            QueueLL<int> queuell = new QueueLL<int>();
            Console.WriteLine("should be true:{0}", queuell.IsEmpty());
            queuell.Enqueue(1);
            queuell.Enqueue(2);
            queuell.Enqueue(3);

            Console.WriteLine("should be false:{0}", queuell.IsEmpty());
            Console.WriteLine("should be 1:{0}", queuell.Peek());
            Console.WriteLine("should be 1:{0}", queuell.Dequeue());
            Console.WriteLine("should be 2:{0}", queuell.Peek());

            queuell.Clear();
            Console.WriteLine("should be true:{0}", queuell.IsEmpty());
            queuell.Dequeue();

        }

        static void TestStack(IStack<int> stack)
        {
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


            DataStructures.Stack.StackLL<int> stackll = new DataStructures.Stack.StackLL<int>();
            Console.WriteLine("should be true:{0}", stackll.IsEmpty());

            stackll.Push(1);
            stackll.Push(2);
            stackll.Push(3);

            Console.WriteLine("should be false:{0}", stackll.IsEmpty());

            Console.WriteLine("should be 3:{0}", stackll.Top());
            Console.WriteLine("should be 3:{0}", stackll.Pop());
            Console.WriteLine("should be 2:{0}", stackll.Top());

            stackll.Clear();
            Console.WriteLine("should be true:{0}", stackll.IsEmpty());
        }

        static void TestLinkedList()
        {
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
            linkedList.RemoveAt(2);
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            linkedList.PrettyPrint();
        }

        static void TestGraph()
        {
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
        }

    }
}