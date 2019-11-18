using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    public delegate void RoyalGuardKingAttackedEventHandler(object sender);
    class RoyalGuard
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
                for (int i = 0; i < value.Length; i++)
                    if (char.IsLetterOrDigit(value[i]) == false)
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
        public event RoyalGuardKingAttackedEventHandler KingAttacked;
        public void OnKingAttacked()
        {
            KingAttacked(this);
        }
        public RoyalGuard(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
