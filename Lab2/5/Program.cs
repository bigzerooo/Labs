using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n =Int32.Parse( Console.ReadLine());
            Console.WriteLine("Введите строки: ");
            string start;
            string []a;
            string[] mas=new string[n];
            for (int i = 0; i < n; i++)
            { 
                start = Console.ReadLine();
                a = start.Split(" ");
                for (int j = 0; j < a.Length; j++)
                    mas[i] += a[j];
            }
            
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                {
                    int n1 = mas[i].Length;
                    int n2 = mas[j].Length;
                    int min = n1;
                    if (n2 < min)
                        min = n2;
                    for(int z=0;z<min;z++)
                    {
                        if(mas[i][z]>mas[j][z])
                        {
                            string t = mas[j];
                            mas[j] = mas[i];
                            mas[i] = t;
                            break;
                        }
                        if (z == min - 1&&mas[i][z]==mas[j][z])
                            if(n1>n2)
                            {
                                string t = mas[j];
                                mas[j] = mas[i];
                                mas[i] = t;
                            }

                    }
                }
            Console.WriteLine("Отсортированые слова");
            for (int i = 0; i < n; i++)
                Console.WriteLine(mas[i]);
        }
    }
}
