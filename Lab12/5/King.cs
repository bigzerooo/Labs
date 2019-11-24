using System;
using System.Collections.Generic;
using System.Text;   
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
        public delegate void KingAttackedEventHandler(object sender, KingAttackedEventArgs args);
        public event KingAttackedEventHandler KingAttacked;        
        public void Attacked(KingAttackedEventArgs args)//Вызывает ивент
        {
            KingAttacked?.Invoke(this, args);
        }
        public King(string name)
        {
            Name = name;
            KingAttacked += Handler.KingsReaction;//обработчик ивента 
        }
        public override string ToString()
        {
            return Name;
        }
    }
class KingAttackedEventArgs//аргументы для события короля
    {
        public List<ISoldier> Soldiers;
        public KingAttackedEventArgs(List<ISoldier>soldiers)
        {
            Soldiers = soldiers;
        }

    }

