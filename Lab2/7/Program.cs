using System;

namespace _7
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

            int k=1;
            int iStart=0;
            int iGood = 0;
            int max=0;
            bool found = false;
            for(int i=0;i<n-1;i++)
            {
                if (a[i] < a[i + 1])
                {
                    k++;
                    if (!found)
                    {
                        iStart = i;
                        found = true;
                    }
                }
                if(a[i]>=a[i+1]||i==n-2)
                {
                    if (max < k)
                    { 
                        max = k;
                        iGood = iStart;
                        found = false;
                    }
                    k = 1;
                }
            }

            for (int i = 0; i < max; i++)
                Console.Write($"{a[iGood+i]} ");

            
        }
    }
}
