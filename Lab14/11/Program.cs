using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            bool appears = false;
            for(int i=1;i<=a.Length;i++)
            {
                for (int j = 0; j < a.Length - i + 1; j++)//a.Substring(j,i)
                    if (b.Contains(a.Substring(j, i)))
                    {
                        appears = true;
                        break;
                    }

            }
            if (appears)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
