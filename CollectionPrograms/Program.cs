using System;
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
            doDictionaryDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List <string> list = new List<string>();
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
    }
}