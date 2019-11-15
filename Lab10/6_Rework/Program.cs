using System;
using System.Collections.Generic;
namespace _6_Rework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 100)
                    throw new Exception("Invalid N!");
                SortedSet<Person> set1 = new SortedSet<Person>(new FirstComparator());
                SortedSet<Person> set2 = new SortedSet<Person>(new SecondComparator());
                //List<Person> list1 = new List<Person>();
                //List<Person> list2 = new List<Person>();
                for (int i = 0; i < n; i++)
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Person t = new Person(tokens[0], int.Parse(tokens[1]));
                    set1.Add(t);
                    set2.Add(t);
                    //list1.Add(t);
                    //list2.Add(t);
                }
                Console.WriteLine();
                //list1.Sort(new FirstComparator());
                //list2.Sort(new SecondComparator());
                foreach (var item in set1)
                    Console.WriteLine($"{item.Name} {item.Age}");
                Console.WriteLine();
                foreach (var item in set2)
                    Console.WriteLine($"{item.Name} {item.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
