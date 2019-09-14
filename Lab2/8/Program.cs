using System;

namespace _8
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

            int max=0;
            int k = 1;
            int best=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                        k++;

                }
                if(max<k)
                {
                    max = k;
                    best = a[i];
                }
                k = 1;
            }

                Console.Write($"{best} ");
        }
    }
}
