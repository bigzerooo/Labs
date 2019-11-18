using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Handler//класс с обработчиками событий
    {
        public void KingsReaction(object sender,KingAttackedEventArgs args)//обработчик для короля
        {
            Console.WriteLine($"King {sender} is under attack!");
            for (int i = 0; i < args.RoyalGuards.Count; i++)
                args.RoyalGuards[i].OnKingAttacked();
            for (int i = 0; i < args.Footmen.Count; i++)
                args.Footmen[i].OnKingAttacked();
            
        }
        public void FootmansReaction(object sender)//обработчик для солдата
        {
            Console.WriteLine($"Footman {sender} is panicking!");
        }
        public void RoyalGuardsReaction(object sender)//обработчик для королевского солдата
        {
            Console.WriteLine($"Royal Guard {sender} is defending!");
        }
    }
}
