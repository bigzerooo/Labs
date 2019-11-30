using System;
using System.Linq;
namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            if (a == new string(a.ToCharArray().Reverse().ToArray()))
                Console.WriteLine(-1);
            //Console.WriteLine($"\"{a}\" is already a palindrome.");
            else
                for (int i = 0; i < a.Length; i++)
                {
                    string b = a.Remove(i, 1);
                    if (b == new string(b.ToCharArray().Reverse().ToArray()))
                        Console.WriteLine(i);
                }
            Console.ReadKey();
        }
    }
}
