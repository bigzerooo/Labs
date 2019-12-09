using System;
using System.Collections.Generic;
namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weapons = new List<Weapon>();
            while (true)
            {
                try
                {
                    string[] tokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[0] == "END")
                        break;
                    switch (tokens[0])
                    {
                        case "Create":
                            string[] type = tokens[1].Split(" ");
                            weapons.Add(new Weapon(type[1], type[0], tokens[2]));
                            break;
                        case "Add":
                            string[] type1 = tokens[3].Split(" ");
                            weapons.Find(x => x.Name == tokens[1]).AddGem(int.Parse(tokens[2]), new Gem(type1[0], type1[1]));
                            break;
                        case "Remove":
                            weapons.Find(x => x.Name == tokens[1]).RemoveGem(int.Parse(tokens[2]));
                            break;
                        case "Print":
                            Console.WriteLine(weapons.Find(x => x.Name == tokens[1]));
                            break;
                    }                
                }
                catch(Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
