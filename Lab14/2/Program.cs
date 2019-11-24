using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (a.Length < 20)
                a = a.PadRight(20, '*');
            else
                a = a.Substring(0, 20);
            Console.WriteLine(a);
        }
    }
}
