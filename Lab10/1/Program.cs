using System;
using System.Collections.Generic;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);//Всегда Create [элементы]
            ListyIterator<string> iterator;
            if (startTokens.Length > 1)
            {
                List<string> list = new List<string>();
                for (int i = 1; i < startTokens.Length; i++)                    
                    list.Add(startTokens[i]);
                iterator = new ListyIterator<string>(list);
            }
            else
            {
                iterator = new ListyIterator<string>();
            }
            for(int i=0;i<100;i++)//Сто команд
            {
                try
                {                
                    string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    string command = tokens[0];
                    command = command.ToLower();
                    switch (command)
                    {
                        case "move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "print":
                            iterator.Print();
                            break;
                        case "hasnext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "end":
                            i = 100;//выход
                            break;
                        default:
                            continue;
                    }
                }
                catch(Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
        }
    }
}
