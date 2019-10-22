using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int>[] a = new Box<int>[n];
            for (int i = 0; i < n; i++)
                a[i] = new Box<int>(int.Parse(Console.ReadLine()));
            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i].ToString());
            Console.ReadKey();
        }
    }
}
