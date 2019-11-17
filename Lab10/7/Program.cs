using System;
using System.Collections;
using System.Collections.Generic;
namespace _7
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
                SortedSet<Person> set1 = new SortedSet<Person>();
                HashSet<Person> set2 = new HashSet<Person>();
                for(int i=0;i<n;i++)
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    int age =int.Parse(tokens[1]);
                    Person t = new Person(name, age);
                    //Console.WriteLine(t.GetHashCode());
                    set1.Add(t);
                    set2.Add(t);
                }
                Console.WriteLine(set1.Count);
                Console.WriteLine(set2.Count);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.WriteLine();

        }
    }
}
