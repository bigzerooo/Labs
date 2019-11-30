using System;
using System.Collections.Generic;
namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            SortedSet<string> names=new SortedSet<string>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                    break;
                if (tokens[0] == "A")
                {
                    if (phoneBook.ContainsKey(tokens[1]))
                        phoneBook[tokens[1]] = tokens[2];
                    else
                    { 
                        phoneBook.Add(tokens[1], tokens[2]);
                        names.Add(tokens[1]);
                    }
                }
                if (tokens[0] == "S")
                {
                    if (phoneBook.ContainsKey(tokens[1]))
                        Console.WriteLine($"{tokens[1]} -> {phoneBook[tokens[1]]}");
                    else
                        Console.WriteLine($"Contact {tokens[1]} does not exist.");
                }
                if(tokens[0]=="ListAll")
                {
                    foreach(string name in names)
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
            }
            Console.ReadKey();
        }
    }
}
