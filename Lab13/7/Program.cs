using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { ' ', '/', '\\', '(', ')' };
            string a = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries).ToArray().Aggregate((x, y) => x + " " + y);
            Regex regex = new Regex(@"\b[a-zA-Z][\w_]{2,24}\b");
            MatchCollection matches = regex.Matches(a);
            //int[] sums = new int[matches.Count - 1];
            List<int> sums = new List<int>();
            for (int i = 0; i < matches.Count - 1; i++)
                sums.Add(matches[i].Length + matches[i + 1].Length);
            int index = sums.IndexOf(sums.First(x => x == sums.Max()));
            Console.WriteLine($"{matches[index]}\n{matches[index + 1]}");
            Console.ReadKey();
        }
    }
}
