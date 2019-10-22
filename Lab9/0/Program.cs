using System;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < t.Length; i++)
                if (char.IsNumber(t[i]))
                    k++;
            if (k == t.Length)
            {
                Box<int> a = new Box<int>(int.Parse(t));
                Console.WriteLine(a.ToString());
            }
            else
            {
                Box<string> a = new Box<string>(t);
                Console.WriteLine(a.ToString());
            }                                           
            Console.ReadKey();
        }
    }
}
