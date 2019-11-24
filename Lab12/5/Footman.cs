using System;
using System.Collections.Generic;
using System.Text;

class Footman:ISoldier
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
    public event MyKingAttackedEventHandler MyKingAttacked;//Событие атаки Короля
    public event DiedEventHandler Died;//Событие смерти
    public void KingAttacked()//вызов события
    {
        MyKingAttacked?.Invoke(this);
    }
    public void TryKill()//Попытка убить
    {
        if (HP > 0)
            HP -= 1;
        if(HP<=0)
            Die();
    }
    public void Die()//Вызов события Died
    {
        Died?.Invoke(this);
    }
    public Footman(string name)
    {
        Name = name;
        HP = 2;
        MyKingAttacked += Handler.FootmansReaction;
    }
    public override string ToString()
        {
            return Name;
        }
}

