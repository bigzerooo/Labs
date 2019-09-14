using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            costil:
                Console.WriteLine("Введите числа: ");
                string start = Console.ReadLine();
                string[] starto = (start.Split(char.Parse(" ")));
                int n = starto.Length;
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = Convert.ToInt32(starto[i]);
                if (n%4 != 0)
            { 
                    Console.WriteLine("Количество цифр не кратное 4!");
                goto costil;
            }
            int[] row1 = new int[n / 2];
            int[] row2 = new int[n / 2];
            int k = 0;
            for(int i=(n/4)-1;i>=0;i--)
            {
                row1[k] = a[i];
                    k++;
            }
            for(int i=n-1;i>=n/4*3;i--)
            {
                row1[k] = a[i];
                k++;
            }
            k = 0;
            for(int i=n/4;i<n/4*3;i++)
            {
                row2[k] = a[i];
                k++;
            }
            for (int i = 0; i < n / 2; i++)
                Console.Write($"{row1[i]} ");
            Console.WriteLine();
            for (int i = 0; i < n / 2; i++)
                Console.Write($"{row2[i]} ");
            Console.WriteLine("\n");
            for (int i = 0; i < n / 2; i++)
                Console.Write($"{row1[i] + row2[i]} ");
        }
    }
}
