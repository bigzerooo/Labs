using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_units").ToArray();
            SortedSet<string> sortedTypes=new SortedSet<string>();
            foreach (Type t in types)
                sortedTypes.Add(t.Name);//Отсортированний список имен в виде строк

            Factory factory = new Factory();//фабрика солдат
            List<object> army = new List<object>();//список обьектов армии(солдат)

            while(true)
            {
                try
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[0] == "fight")
                        break;
                    if (tokens[0] == "add")
                    {
                        army.Add(factory.Produce(tokens[1]));
                        Console.WriteLine($"{tokens[1]} added!");
                    }
                    if (tokens[0] == "report")
                    {
                        foreach (string sType in sortedTypes)
                        {
                            int k = army.Count(t => t.GetType().Name == sType);
                            if (k != 0)
                                Console.WriteLine($"{sType} -> {k}");
                        }
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
