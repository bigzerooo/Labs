using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    public delegate void FootmansKingAttackedEventHandler(object sender);//делегат
    class Footman
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
        public event FootmansKingAttackedEventHandler KingAttacked;//событие
        public void OnKingAttacked()//вызов события
        {
            KingAttacked(this);
        }
        public Footman(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
