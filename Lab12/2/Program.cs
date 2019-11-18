using System;
using System.Collections.Generic;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();//класс с обработчиками

            King king = new King(Console.ReadLine());

            king.KingAttacked += handler.KingsReaction;//обработчик

            List<RoyalGuard> royalGuards = new List<RoyalGuard>();
            string[] royalTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < royalTokens.Length; i++)
            {
                RoyalGuard t = new RoyalGuard(royalTokens[i]);
                t.KingAttacked += handler.RoyalGuardsReaction;//обработчик
                royalGuards.Add(t);
            }



            List<Footman> footmen=new List<Footman>();
            string[] footmenTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < footmenTokens.Length; i++)
            {
                Footman t = new Footman(footmenTokens[i]);
                t.KingAttacked += handler.FootmansReaction;//обработчик
                footmen.Add(t);
            }
                


            for(int i=0;i<100;i++)
            {
                string[] commandTokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (commandTokens[0] == "End")
                    break;
                if (commandTokens[0] == "Kill")
                {
                    footmen.RemoveAll(x => x.Name == commandTokens[1]);
                    royalGuards.RemoveAll(x => x.Name == commandTokens[1]);
                }
                if(commandTokens[0]=="Attack"&& commandTokens[1] == "King")
                {
                    king.OnKingAttacked(new KingAttackedEventArgs( royalGuards, footmen));//вызов события
                }
            }

            Console.ReadKey();
        }
    }
}
