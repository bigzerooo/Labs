using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    delegate void KingAttackedEventHandler(object sender, KingAttackedEventArgs args);
    class King
    {
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool good = true;
                for(int i=0;i<value.Length;i++)
                    if(char.IsLetterOrDigit(value[i])==false)
                    {
                        good = false;
                        break;
                    }

                if (good)
                    _name = value;

                else
                    throw new Exception("Invalid Name!");
            }
        }
        public event KingAttackedEventHandler KingAttacked;
        public void OnKingAttacked(KingAttackedEventArgs args)
        {
            KingAttacked(this,args);
        }
        public King(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class KingAttackedEventArgs//аргументы для события короля
    {
        public List<Footman> Footmen { get; set; }
        public List<RoyalGuard> RoyalGuards { get; set; }
        public KingAttackedEventArgs(List<RoyalGuard> royalGuards,List<Footman>footmen)
        {
            Footmen = footmen;
            RoyalGuards = royalGuards;
        }

    }
}
