using System;
using System.Collections.Generic;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                          
                int n =int.Parse(Console.ReadLine());
                if (n < 0 || n > 100)
                    throw new Exception("Invalid N!");
                List<Person> list1 = new List<Person>();
                List<Person> list2 = new List<Person>();
                for (int i=0;i<n;i++)
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Person t = new Person(tokens[0],int.Parse(tokens[1]));
                    list1.Add(t);
                    list2.Add(t);
                }
                Console.WriteLine();
                list1.Sort(new FirstComparator());
                list2.Sort(new SecondComparator());
                foreach (var item in list1)
                    Console.WriteLine($"{item.Name} {item.Age}");
                Console.WriteLine();
                foreach (var item in list2)
                    Console.WriteLine($"{item.Name} {item.Age}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
