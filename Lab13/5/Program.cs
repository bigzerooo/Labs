using System;
using System.Text.RegularExpressions;
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex a = new Regex(@"\b[a-z0-9][a-z0-9\-\._]*[a-z0-9]@[a-z][a-z\-]*[a-z]\.[a-z][a-z\-\.]*[a-z]\b");
            //Regex a = new Regex(@"(^| )[a-z0-9][a-z0-9\-\._]*[a-z0-9]@[a-z][a-z\-]*[a-z]\.[a-z][a-z\-\.]*[a-z]\b");
            string s = Console.ReadLine();
            foreach(var i in a.Matches(s))            
                Console.WriteLine(i);           
            Console.ReadKey();
        }
    }
}
