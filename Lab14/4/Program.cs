using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            char[] chars = { '.', '!', '?' };
            string[] sentences = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            int n = sentences.Length;
            for (int i = 0; i < n; i++)            
                sentences[i] = sentences[i].Trim();            
            for(int i = 0; i < n; i++)
            {
                string[] words = sentences[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                bool found = false;
                for(int j = 0; j < words.Length; j++)
                {
                    if (words[j] == keyword)
                    {
                        found = true;
                        break;
                    }                        
                }
                if(found)
                    Console.WriteLine(sentences[i]);
            }
                
        }
    }
}
