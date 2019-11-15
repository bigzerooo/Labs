using System;
using System.Collections.Generic;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Replace(',', ' ').Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<int> values = new List<int>();
            for (int i = 0; i < tokens.Length; i++)
                values.Add(int.Parse(tokens[i]));
            Lake lake = new Lake(values);
            foreach(var item in lake)            
                Console.Write($"{item} ");
            Console.ReadKey();
        }
    }
}
