using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int m =int.Parse(Console.ReadLine());
            int n = tokens.Length;

            AddCollection a = new AddCollection();
            for (int i = 0; i < n; i++)
                Console.Write($"{a.Add(tokens[i])} ");
            Console.WriteLine();



            AddRemoveCollection b = new AddRemoveCollection();
            for(int i=0;i<n;i++)
                Console.Write(b.Add(tokens[i])+" ");
            Console.WriteLine();



            MyList c = new MyList();
            for (int i = 0; i < n; i++)
                Console.Write(c.Add(tokens[i]) + " ");
            Console.WriteLine();



            for (int i = 0; i < m; i++)
                Console.Write(b.Remove() + " ");
            Console.WriteLine();

            for(int i=0;i<m;i++)
                Console.Write(c.Remove() + " ");
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
