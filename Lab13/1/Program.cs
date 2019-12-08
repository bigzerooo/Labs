using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                    break;
                else
                    list.Add(command);
            }
            string a = list.Aggregate((x, y) => x +" , "+ y);
            //Console.WriteLine(a);
            Regex regex = new Regex(@"\b[A-Z][a-z]+[ ][A-Z][a-z]+\b");
            MatchCollection matches = regex.Matches(a);
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}
