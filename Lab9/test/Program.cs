using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> a = new Box<int>(2);
            Box<string> b = new Box<string>("kurva");
            Box<int>[] c = new Box<int>[1];
            c[0] = new Box<int>(5);
            Console.WriteLine(a.GetType().Name);
            Console.WriteLine(b.GetType().Name);
            Console.WriteLine(c[0].GetType().Name);
        }
    }
}
