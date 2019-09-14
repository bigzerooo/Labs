using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a =new char [26];
            for (int i = 0; i < 26; i++)
                a[i] = (char)(97 + i);
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            foreach (char i in word){
                Console.Write($"{i} -> ");
                for (int j = 0; j < 26; j++)
                    if (i == a[j])
                    {
                        Console.Write(j);
                    }
                Console.WriteLine();
            }
        }
    }
}
