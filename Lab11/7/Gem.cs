using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class Gem
    {
        string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == "Ruby" || value == "Emerald" || value == "Amethyst")
                    _type = value;
                else
                    throw new Exception("Invalid Gem Type!");
            }
        }
        string _clarity;
        public string Clarity
        {
            get
            {
                return _clarity;
            }
            set
            {
                if (value == "Chipped" || value == "Regular" || value == "Perfect" || value == "Flawless")
                    _clarity = value;
                else
                    throw new Exception("Invalid Gem Clarity!");
            }
        }
        public int GetStength()
        {
            int value = 0;
            switch (Type)
            {
                case "Ruby":
                    value += 7;
                    break;
                case "Emerald":
                    value += 1;
                    break;
                case "Amethyst":
                    value += 2;
                    break;
            }
            switch (Clarity)
            {
                case "Chipped":
                    value += 1;
                    break;
                case "Regular":
                    value += 2;
                    break;
                case "Perfect":
                    value += 5;
                    break;
                case "Flawless":
                    value += 10;
                    break;                    
            }
            return value;
        }
        public int GetAgility()
        {
            int value = 0;
            switch (Type)
            {
                case "Ruby":
                    value += 2;
                    break;
                case "Emerald":
                    value += 4;
                    break;
                case "Amethyst":
                    value += 8;
                    break;
            }
            switch (Clarity)
            {
                case "Chipped":
                    value += 1;
                    break;
                case "Regular":
                    value += 2;
                    break;
                case "Perfect":
                    value += 5;
                    break;
                case "Flawless":
                    value += 10;
                    break;
            }
            return value;
        }
        public int GetVitality()
        {
            int value = 0;
            switch (Type)
            {
                case "Ruby":
                    value += 5;
                    break;
                case "Emerald":
                    value += 9;
                    break;
                case "Amethyst":
                    value += 4;
                    break;
            }
            switch (Clarity)
            {
                case "Chipped":
                    value += 1;
                    break;
                case "Regular":
                    value += 2;
                    break;
                case "Perfect":
                    value += 5;
                    break;
                case "Flawless":
                    value += 10;
                    break;
            }
            return value;
        }
        public Gem(string clarity,string type)
        {
            Clarity = clarity;
            Type = type;
        }
    }
}
