using System;

namespace _2
{
    class Program
    {
        static void rotate(ref int []a,int k)
        {
            int[]sum = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                sum[i] =0;
            for(int j=0;j<k;j++)
            { 
            int t;
            t = a[a.Length - 1];
            for (int i=a.Length-1; i > 0;i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = t;
                for (int i = 0; i < a.Length; i++)
                    sum[i] += a[i];
            }
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{sum[i]} ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            string start=Console.ReadLine();
            string[] starto = (start.Split(char.Parse(" ")));
            int n = starto.Length;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] =Convert.ToInt32(starto[i]);
            
            Console.WriteLine("Введите k: ");
            int k =Convert.ToInt32( Console.ReadLine());
            rotate(ref a, k);

            

        }
    }
}
