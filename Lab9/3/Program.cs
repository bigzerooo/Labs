using System;
using System.Collections.Generic;
namespace _3
{
    class Program//without boxes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] a = new string[n];
            for (int i = 0; i < n; i++)
                a[i] = Console.ReadLine();

            string[] tokens =Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int []indexes = new int[2];
            indexes[0] = int.Parse(tokens[0]);
            indexes[1] = int.Parse(tokens[1]);   
            
            Swap<string>(ref a[indexes[0]], ref a[indexes[1]]);

            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i].ToString());

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
