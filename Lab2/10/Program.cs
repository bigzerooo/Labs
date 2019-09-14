using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string[] starto = start.Split(" ");
            int n = starto.Length;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(starto[i]);
            int b = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                {
                    if (a[i] - a[j] == b)
                        k++;
                    if (a[j] - a[i] == b)
                        k++;
                }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
