using System;
using System.Collections.Generic;
using System.Linq;
namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();
            for(int i=0; i<words.Length;i++)
                if (words[i] == new string(words[i].ToCharArray().Reverse().ToArray()))
                    palindromes.Add(words[i]);
            foreach(string word in palindromes)
            {
                Console.Write($"{word}");
                if (word != palindromes.Last())
                    Console.Write(", ");
            }
            Console.ReadKey();
                
        }
    }
}
