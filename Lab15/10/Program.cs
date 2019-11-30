using System;
using System.Collections.Generic;
using System.Linq;
namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                    break;
                else                   
                    people.Add(new Person(tokens[0]+tokens[1], int.Parse(tokens[2])));                
            }


            var selectedPeople = from t in people
                                 orderby t.Group
                                 group t by t.Group;
                                 
                                 
            foreach(var g in selectedPeople)//var - IGrouping<int, Person>
            {
                Console.Write($"{g.Key} - ");
                foreach(var p in g)
                {
                    Console.Write(p);
                    if (p != g.Last())
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
