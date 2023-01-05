using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            //doListDemo();
            //doStackDemo();
            //doDictionaryDemo();
            //doSetDemo();
            doQueueDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Arun");
            list.Add("Surya");
            list.Add("Parnika");
            list.Add("Adithya");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ravi");
            stack.Push("Vijay");
            stack.Push("Pavitra");
            stack.Push("Shiva");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popped element: " + pop);
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Ravi");
            dictionary.Add(101, "Vijay");
            dictionary.Add(102, "Pavitra");

            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + "& value =" + element.Value);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Pavitra");
            set.Add("Shiva");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            Queue<string>queue = new Queue<string>();
            queue.Enqueue("Bindhu Shree");
            queue.Enqueue("Sunil Kumar");
            queue.Enqueue("Asha Rani");
            queue.Enqueue("Raju");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements: ");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element: " + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeue one element: ");
            
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}