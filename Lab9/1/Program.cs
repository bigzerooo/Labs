using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string>[] a= new Box <string>[n];
            for (int i = 0; i < n; i++)
                a[i] = new Box<string>(Console.ReadLine());
            for (int i = 0; i < n; i++) 
                Console.WriteLine(a[i].ToString());
            Console.ReadKey();
        }
    }
}
