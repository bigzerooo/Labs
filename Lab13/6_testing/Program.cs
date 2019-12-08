using System;
using System.Text.RegularExpressions;
namespace _6_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex keyRegex = new Regex($@"\b{Console.ReadLine()}\b");            
            foreach (var i in new Regex(@"\b[^.?!]*[!.?]").Matches(Console.ReadLine()))
                if (keyRegex.IsMatch(i.ToString())) Console.WriteLine(i);            

        }
    }
}
