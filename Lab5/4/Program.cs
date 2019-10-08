using System;
using System.Collections;
using System.Collections.Generic;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            List<Person> People = new List<Person>();
            List<Product> Products = new List<Product>();
            for (int i = 0; i < tokens.Length; i++)
            { 
                string []values = tokens[i].Split('=');
                Person t = new Person(values[0], Int32.Parse(values[1]));
                People.Add(t);
            }
            string[] tokens2 = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            for(int i=0;i<tokens2.Length;i++)
            {
                string[] values = tokens2[i].Split('=');
                Product t = new Product(values[0], Int32.Parse(values[1]));
                Products.Add(t);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;
                else
                {
                    string[] commandTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if(commandTokens.Length==2)
                    {
                        Person tPerson = People.Find(x => x.Name == commandTokens[0]);
                        Product tProduct = Products.Find(x => x.Name == commandTokens[1]);
                        tPerson.Buy(tProduct);
                    }
                }
            }
            for (int i = 0; i < People.Count; i++)
                People[i].DisplayBag();
            Console.ReadKey();
        }
    }
}
