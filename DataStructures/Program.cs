namespace DataStructures
{
    using DataStructures.Graph;
    using DataStructures.Queue;
    using DataStructures.SortingAlgorithms;
    using DataStructures.Stack;
    using DataStructures.Tree;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            TestArrayAlgorithms();
        }

        static void TestHashTable()
        {
            HashTable.HashTable<string, string> hash = new HashTable.HashTable<string, string>(17);

            hash.Add("1", "item 1");
            hash.Add("2", "item 2");
            hash.Add("hola", "amigo");

            string one = hash.Find("1");
            Console.WriteLine("should be item 1: {0}", one);
            string two = hash.Find("2");
            Console.WriteLine("should be item 2: {0}", two);
            string amigo = hash.Find("hola");
            Console.WriteLine("should be amigo: {0}", amigo);
            hash.Remove("1");
            var k = hash.Find("1");
        }
        static void TestTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5, null, null);
            tree.Insert(tree.GetRootNode(), -8);
            tree.Insert(tree.GetRootNode(), 10);
            tree.Insert(tree.GetRootNode(), 3);
            tree.Insert(tree.GetRootNode(), 8);
            tree.Insert(tree.GetRootNode(), 9);
            tree.Insert(tree.GetRootNode(), 0);
            Console.WriteLine(tree.FindMin(tree.GetRootNode()).data);
            tree.Print();
            tree.DeleteNode(10);
            tree.Print();
            //Console.WriteLine(tree.Search(tree.GetRootNode(), 9).data);
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
            Console.WriteLine();
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
            Console.WriteLine(linkedList.Size());
            linkedList.Prepend(0);
            linkedList.PrettyPrint();
            linkedList.Remove(4);
            linkedList.PrettyPrint();
            linkedList.RemoveAt(2);
            linkedList.PrettyPrint();
        }

        static void TestGraph()
        {
            Graph<int> graph = new Graph<int>();
            var node0 = new Graph.Node<int>(0);
            var node2 = new Graph.Node<int>(2);
            var node3 = new Graph.Node<int>(3);
            var node4 = new Graph.Node<int>(4);
            var node5 = new Graph.Node<int>(5);
            node0.AddEdge(node2);
            var neighbors = new List<Graph.Node<int>> { node0, node2, node3 };
            var newNode = graph.AddNode(1, neighbors);
            var secondNode = graph.AddNode(2, new List<DataStructures.Graph.Node<int>> { node5 });
            //Console.WriteLine("-------BFS-------");
            //graph.BFS(newNode);
            //Console.WriteLine("-----------------");
            Console.WriteLine("Before remove:");
            Console.WriteLine(graph.ToString());
            graph.RemoveNode(newNode);
            Console.WriteLine("-----------------");
            Console.WriteLine("After remove:");
            var graphToString = graph.ToString();
            Console.WriteLine(graphToString == "" ? "The Graph is empty" : graphToString);
        }

        static void TestArrayAlgorithms()
        {
            int[] array = new int[]
              {
                    3,4,1,2,8,9,10,11,12,111,5,6,7
              };

            //var sorted = SortingAlgorithms.Sort.BubbleSort(array);
            //var sorted = Sort.InsertionSort(array);
            //var sorted = SortingAlgorithms.Sort.SelectSort(array);
            //var sorted = SortingAlgorithms.Sort.MergeSort(array);
            var sorted = SortingAlgorithms.Sort.QuickSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
            }

            Console.WriteLine();
            var resultIt = Search.IterativeBinarySearch(sorted, 12);
            var resultRe = Search.RecursiveBinarySearch(sorted, 12);
            Console.WriteLine("should be 11: {0}", resultIt);
            Console.WriteLine("should be 11: {0}", resultRe);
            Console.Read();
        }

    }
}