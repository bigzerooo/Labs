using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // \+359(?<grp1>[- ])[0-9]\k<grp1>[0-9]{3}\k<grp1>[0-9]{4}\b
            List<string> list = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                    break;
                else
                    list.Add(command);
            }
            string a = list.Aggregate((x, y) => x + " , " + y);
            Regex regex = new Regex(@"\+359(?<grp1>[- ])[0-9]\k<grp1>[0-9]{3}\k<grp1>[0-9]{4}\b");
            //Console.WriteLine(a);
            foreach (var item in regex.Matches(a))
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
