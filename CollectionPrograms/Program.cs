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
            doStackDemo();
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
    }
}