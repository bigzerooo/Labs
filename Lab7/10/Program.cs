using System;
using System.Collections.Generic;
namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1 && tokens[0] == "End")
                { 
                    break;
                }
                if (tokens.Length==3)
                {
                    Citizen t = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                    citizens.Add(t);
                }
            }
            for (int i = 0; i < citizens.Count; i++)
            {

                IPerson t1 = citizens[i];
                Console.WriteLine(t1.GetName());
                IResident t2 = citizens[i];
                Console.WriteLine(t2.GetName());
            }

            Console.ReadKey();
        }
    }
}
