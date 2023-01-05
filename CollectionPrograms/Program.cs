using System;
using System.Collections.Generic;

namespace CollectionPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doListDemo();
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
    }
}