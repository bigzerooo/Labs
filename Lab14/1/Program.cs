using System;
using System.Text;
using System.Linq;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();            
            string b =new string(a.ToCharArray().Reverse().ToArray());
            Console.Write($"Variant I: {b}\n");
            Console.Write("Variant II: ");
            for(int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]}");
            }
        }
    }
}
