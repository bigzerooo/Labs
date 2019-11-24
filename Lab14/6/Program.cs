using System;
using System.Linq;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] chars = {'.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            string[] words = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            
            string[] seperators = text.Split(words, StringSplitOptions.RemoveEmptyEntries);
            int n = words.Length;
            words=words.Reverse().ToArray();
            for(int i=0;i<n;i++)
            {
                Console.Write(words[i] + seperators[i]);
            }
            Console.ReadKey();
        }
    }
}
