using System;
using System.Text.RegularExpressions;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for(int i=0;i<a.Length;i++)
            {
                Regex regex = new Regex($@"{a[i]}+");
                a = regex.Replace(a, $"{a[i]}");                
            }
            Console.WriteLine(a);
        }
    }
}
