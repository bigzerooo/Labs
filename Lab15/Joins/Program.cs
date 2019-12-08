using System;
using System.Linq;
using System.Collections.Generic;
namespace Joins
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(1, "a"));
            people.Add(new Person(2, "b"));
            people.Add(new Person(3, "c"));
            people.Add(new Person(4, "d"));
            people.Add(new Person(5, "e"));
            people.Add(new Person(6, "f"));

            List<Buy> buys = new List<Buy>();
            buys.Add(new Buy(1, "z"));
            buys.Add(new Buy(2, "x"));
            buys.Add(new Buy(3, "y"));
            buys.Add(new Buy(4, "q"));
            buys.Add(new Buy(7, "r"));
            var innerJoin = from person in people
                            join buy in buys on person.ID equals buy.ID
                            select new
                            {
                                person.ID,
                                person.Name,
                                buy.tName
                            };

            var leftJoin = from person in people
                           join buy in buys on person.ID equals buy.ID into gj
                           from subbuy in gj.DefaultIfEmpty()
                           select new
                           {
                               person.ID,
                               person.Name,
                               tName = subbuy?.tName ?? String.Empty
                           };

            var rightJoin = from buy in buys
                            join person in people on buy.ID equals person.ID into gj
                            from subperson in gj.DefaultIfEmpty()
                            select new
                            {
                                buy.ID,
                                Name = subperson?.Name ?? String.Empty,
                                buy.tName

                            };

            var outerJoin = leftJoin.Union(rightJoin);

            Console.WriteLine("Inner Join:");
            foreach (var i in innerJoin)
                Console.WriteLine($"{i.ID}\t{i.Name}\t{i.tName}");

            Console.WriteLine("\nLeft Join:");
            foreach (var i in leftJoin)
                Console.WriteLine($"{i.ID}\t{i.Name}\t{i.tName}");

            Console.WriteLine("\nRight Join:");
            foreach (var i in rightJoin)
                Console.WriteLine($"{i.ID}\t{i.Name}\t{i.tName}");

            Console.WriteLine("\nOuter Join:");
            foreach (var i in outerJoin)
                Console.WriteLine($"{i.ID}\t{i.Name}\t{i.tName}");
            //foreach (var i in result)
            //Console.WriteLine($"{i.ID} {i.Name} {i.tName}");
            Console.ReadKey();
        }
    }
}
