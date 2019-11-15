using System;
using System.Collections.Generic;
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> people= new List<Person>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1 && tokens[0].ToLower() == "end")
                    break;
                if (tokens.Length == 3)
                {
                    string name = tokens[0];                    
                    int age =int.Parse(tokens[1]);
                    string town = tokens[2];
                    Person t = new Person(name, age, town);
                    people.Add(t);
                }
            }
            int n = int.Parse(Console.ReadLine());
            n -= 1;
            Person person = people[n];
            int equal=1, not_equal=0, total=people.Count;
            foreach(Person item in people)
                if (person != item)
                    if (person.CompareTo(item) == 0)
                        equal++;
                    else
                        not_equal++;
            if (equal == 1)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{equal} {not_equal} {total}");
            
        }
    }
}
