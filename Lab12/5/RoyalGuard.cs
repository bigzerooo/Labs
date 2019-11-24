using System;
using System.Collections.Generic;
using System.Text;
    class RoyalGuard:ISoldier
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
        public int HP { get; set; }
        public event MyKingAttackedEventHandler MyKingAttacked;//Событие
        public event DiedEventHandler Died;
        public void KingAttacked()//вызов события
        {
            MyKingAttacked?.Invoke(this);
        }
        public void TryKill()
        {
            if (HP > 0)
                HP -= 1;
            if(HP<=0)
                Die();
        }
        public void Die()
    {
        Died.Invoke(this);
    }
        public RoyalGuard(string name)
        {
            Name = name;
            MyKingAttacked += Handler.RoyalGuardsReaction;
            HP = 3;
        }
        public override string ToString()
            {
                return Name;
            }
    }

