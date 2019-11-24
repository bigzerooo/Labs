using System;
using System.Collections.Generic;
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King(Console.ReadLine());
            Army army = new Army();
            //List<ISoldier> soldiers = new List<ISoldier>();

            string[] royalTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < royalTokens.Length; i++)
            {
                RoyalGuard t = new RoyalGuard(royalTokens[i]);
                army.Add(t);                
            }       
            
            string[] footmenTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < footmenTokens.Length; i++)
            {
                Footman t = new Footman(footmenTokens[i]);
                army.Add(t);
            }

            for (int i = 0; i < 100; i++)
            {
                string[] commandTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandTokens[0] == "End")
                    break;
                if (commandTokens[0] == "Kill")
                {
                    ISoldier t=army.soldiers.Find(x => x.Name == commandTokens[1]);
                    t.TryKill();
                    //soldiers.RemoveAll(x => x.Name == commandTokens[1]);                    
                }
                if (commandTokens[0] == "Attack" && commandTokens[1] == "King")
                {
                    king.Attacked(new KingAttackedEventArgs(army.soldiers));//вызов события
                }
            }

            Console.ReadKey();
        }
    }
}
