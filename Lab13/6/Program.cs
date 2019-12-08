using System;
using System.Text.RegularExpressions;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {            
            Regex keyRegex = new Regex($@"\b{Console.ReadLine()}\b");
            Regex sentanceRegex = new Regex(@"\b[^.?!]*[!.?]");            
            foreach (var i in sentanceRegex.Matches(Console.ReadLine()))
                if(keyRegex.IsMatch(i.ToString()))
                    Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
