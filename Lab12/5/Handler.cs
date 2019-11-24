using System;
using System.Collections.Generic;
using System.Text;


    static class Handler//класс с обработчиками событий
    {
        static public void KingsReaction(object sender,KingAttackedEventArgs args)//обработчик для короля
        {
            Console.WriteLine($"King {sender} is under attack!");        
            for (int i = 0; i < args.Soldiers.Count; i++)
                args.Soldiers[i].KingAttacked();            
        }
        static public void FootmansReaction(object sender)//обработчик для солдата
        {
            Console.WriteLine($"Footman {sender} is panicking!");
        }
        static public void RoyalGuardsReaction(object sender)//обработчик для королевского солдата
        {
            Console.WriteLine($"Royal Guard {sender} is defending!");
        }
    }

