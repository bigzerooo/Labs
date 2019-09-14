using System;

namespace _11
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
            int index = -1;
            for(int i=0;i<n;i++)
            {
                int sum_left = 0;
                int sum_right = 0;
                for (int j = 0; j < i; j++)
                    sum_left += a[j];
                for (int z = i + 1; z < n; z++)
                    sum_right += a[z];
                if (sum_left == sum_right)
                    index = i;                
            }
            if (index < 0)
                Console.WriteLine("no");
            else
                Console.WriteLine(index);
        }
    }
}
