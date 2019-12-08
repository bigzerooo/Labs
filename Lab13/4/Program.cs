using System;
using System.Text.RegularExpressions;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex a = new Regex(@"<a href=[^>]+>[^<]+<\/a>");//в виде: <a href= (всё кроме >) > (всё кроме <) </a>
            
            foreach(var i in a.Matches(s))
            {
                string b = i.ToString();
                b=b.Replace("<a", "[URL");
                b=b.Replace("</a>","[/URL]");                
                s=s.Replace(i.ToString(), b);
            }
            Console.WriteLine(s);
            
        }
    }
}
