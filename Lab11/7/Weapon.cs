using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class Weapon
    {
        Gem[] sockets;
        string _type;
        string _rarity;
        public string Name { get; set; }        
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == "Axe" || value == "Sword" || value == "Knife")
                    _type = value;
                else
                    throw new Exception("Invalid Weapon Type!");
            }
        }
        public string Rarity
        {
            get
            {
                return _rarity;
            }
            set
            {
                if (value == "Common" || value == "Uncommon" || value == "Rare" || value == "Epic")
                    _rarity = value;
                else
                    throw new Exception("Invalid Weapon Type!");
            }
        }
        public void AddGem(int index,Gem gem)
        {
            sockets[index] = gem;
        }
        public void RemoveGem(int index)
        {
            sockets[index] = null;
        }
        public int GetMinDamage()
        {
            int value = 0;
            switch (Type)
            {
                case "Axe":
                    value += 5;
                    break;
                case "Sword":
                    value += 4;
                    break;
                case "Knife":
                    value += 3;
                    break;
            }
            switch (Rarity)
            {
                case "Common":
                    value *= 1;
                    break;
                case "Uncommon":
                    value *= 2;
                    break;
                case "Rare":
                    value *= 3;
                    break;
                case "Epic":
                    value *= 5;
                    break;
            }
            for(int i=0;i<sockets.Length;i++)
            {
                if (sockets[i] != null)
                {
                    value += 2 * sockets[i].GetStength();
                    value += 1 * sockets[i].GetAgility();
                }
            }
            return value;
        }
        public int GetMaxDamage()
        {
            int value = 0;
            switch (Type)
            {
                case "Axe":
                    value += 10;
                    break;
                case "Sword":
                    value += 6;
                    break;
                case "Knife":
                    value += 4;
                    break;
            }
            switch (Rarity)
            {
                case "Common":
                    value *= 1;
                    break;
                case "Uncommon":
                    value *= 2;
                    break;
                case "Rare":
                    value *= 3;
                    break;
                case "Epic":
                    value *= 5;
                    break;
            }
            for (int i = 0; i < sockets.Length; i++)
            {
                if (sockets[i] != null)
                {
                    value += 3 * sockets[i].GetStength();
                    value += 4 * sockets[i].GetAgility();
                }
            }
            return value;
        }
        public int GetStrength()
        {
            int value = 0;
            for(int i=0;i<sockets.Length;i++)
            {
                if (sockets[i] != null)
                    value += sockets[i].GetStength();
            }
            return value;
        }
        public int GetAgility()
        {
            int value = 0;
            for (int i = 0; i < sockets.Length; i++)
            {
                if (sockets[i] != null)
                    value += sockets[i].GetAgility();
            }
            return value;
        }
        public int GetVitality()
        {
            int value = 0;
            for (int i = 0; i < sockets.Length; i++)
            {
                if (sockets[i] != null)
                    value += sockets[i].GetVitality();
            }
            return value;
        }
        public override string ToString()
        {
            return $"{Name}: {GetMinDamage()}-{GetMaxDamage()} Damage, +{GetStrength()} Strength, +{GetAgility()} Agility, +{GetVitality()} Vitality";
        }
        public Weapon(string type,string rarity,string name)
        {
            Type = type;
            Rarity = rarity;
            Name = name;
            switch (Type)
            {
                case "Axe":
                    sockets = new Gem[4];
                    break;
                case "Sword":
                    sockets = new Gem[3];
                    break;
                case "Knife":
                    sockets = new Gem[2];
                    break;
            }
        }
    }
}
