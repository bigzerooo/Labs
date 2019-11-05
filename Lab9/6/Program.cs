using System;
using System.Collections.Generic;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));

            Box<double> x = new Box<double>(double.Parse(Console.ReadLine()));


            Console.WriteLine(Count<Box<double>>(boxes, x));

            Console.ReadKey();
        }
        static int Count<T>(List<T> list, T t) where T : IComparable
        {
            int k = 0;
            for (int i = 0; i < list.Count; i++)
                if (list[i].CompareTo(t) > 0)
                    k++;
            return k;
        }
    }
}
