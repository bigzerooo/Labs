using System;
using System.Collections.Generic;
namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                    break;
                if(tokens[0]=="A")
                {
                    if (phoneBook.ContainsKey(tokens[1]))
                        phoneBook[tokens[1]] = tokens[2];
                    else
                        phoneBook.Add(tokens[1], tokens[2]);
                }
                if(tokens[0]=="S")
                {
                    if (phoneBook.ContainsKey(tokens[1]))
                        Console.WriteLine($"{tokens[1]} -> {phoneBook[tokens[1]]}");
                    else
                        Console.WriteLine($"Contact {tokens[1]} does not exist.");
                }
            }
            Console.ReadKey();
        }
    }
}
