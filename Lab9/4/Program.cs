using System;
using System.Collections.Generic;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int>[] boxes = new Box<int>[n];

            for (int i = 0; i < n; i++)
            {
                Box<int> t = new Box<int>(int.Parse(Console.ReadLine()));
                boxes[i] = t;
            }

            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] indexes = new int[2];
            indexes[0] = int.Parse(tokens[0]);
            indexes[1] = int.Parse(tokens[1]);

            int a = boxes[indexes[0]].Value;
            int b = boxes[indexes[1]].Value;
            Swap<int>(ref a, ref b);
            boxes[indexes[0]].Value = a;
            boxes[indexes[1]].Value = b;

            for (int i = 0; i < n; i++)
                Console.WriteLine(boxes[i]);

            Console.ReadKey();
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}
