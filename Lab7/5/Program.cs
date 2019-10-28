using System;
using System.Collections.Generic;
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentificable> people = new List<IIdentificable>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length==1 && tokens[0] == "End")
                    break;
                if(tokens.Length==2)
                {
                    IIdentificable t = (IIdentificable)new Robot(tokens[0], tokens[1]);
                    people.Add(t);                    
                }
                if (tokens.Length == 3)
                {
                    IIdentificable t = (IIdentificable)new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    people.Add(t);
                }
            }
            string lastDigits = Console.ReadLine();
            for (int i = 0; i < people.Count; i++)
                if (people[i].Check(lastDigits) == false)
                    Console.WriteLine(people[i].ID);

            Console.ReadKey();
        }
    }
}
