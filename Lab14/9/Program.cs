using System;
using System.Globalization;
namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = {' ', '.', ',', '?', '!', ';'};
            string[] words = Console.ReadLine().Split(chars,StringSplitOptions.RemoveEmptyEntries); 

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;//инфо на основе американской культуры .-.
            for(int i=0;i<words.Length;i++)
                Console.WriteLine($"{textInfo.ToTitleCase(words[i])} ");
            Console.ReadKey();
        }
    }
}
