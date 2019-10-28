using System;
using System.Collections.Generic;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> people = new List<IBirthable>();
            List<Robot> robots = new List<Robot>();
            while(true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1 && tokens[0] == "End")
                    break;
                if (tokens.Length == 5 && tokens[0] == "Citizen")
                {
                    IBirthable t = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    people.Add(t);
                }
                if (tokens.Length == 3)
                {
                    if (tokens[0] == "Robot")
                    {
                        Robot t = new Robot(tokens[1],tokens[2]);
                        robots.Add(t);
                    }
                    if (tokens[0] == "Pet")
                    {
                        IBirthable t = new Pet(tokens[1], tokens[2]);
                        people.Add(t);
                    }
                }                                
            }
            string year = Console.ReadLine();
            for(int i=0;i<people.Count;i++)
            {
                string[] dateTokens = people[i].Birthdate.Split("/");
                if (dateTokens[2] == year)
                    Console.WriteLine(people[i].Birthdate);
            }

            Console.ReadKey();
        }
    }
}
