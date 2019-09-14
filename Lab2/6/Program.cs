using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            string start = Console.ReadLine();
            string[] starto = (start.Split(char.Parse(" ")));
            int n = starto.Length;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(starto[i]);

            int k = 1;
            int best = 0;
            int max=0;
            for(int i=1;i<n;i++)
            {
                if (a[i] == a[i - 1])
                    k++;
                if(a[i]!=a[i-1])
                {
                    k = 1;
                }


                if(k>max)
                {
                    max = k;
                    best = a[i];
                }
            }
            for (int i = 0; i < max; i++)
                Console.Write($"{best} ");

        }
    }
}
