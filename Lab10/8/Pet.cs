using System;
using System.Collections.Generic;

namespace _8
{
    class Pet
    {
        string _name;
        int _age;
        string _kind;
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
                    if(char.IsLetter(value[i])==false)
                    {
                        good = false;
                        break;
                    }
                if (value.Length < 1 || value.Length > 50)
                    good = false;
                if (good)
                    _name = value;
                else
                    throw new Exception("Invalid Name!");
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 1 && value <= 100)
                    _age = value;
                else
                    throw new Exception("Invalid Age!");
            }
        }
        public string Kind
        {
            get
            {
                return _kind;
            }
            set
            {
                bool good = true;
                for (int i = 0; i < value.Length; i++)
                    if (char.IsLetter(value[i]) == false)
                    {
                        good = false;
                        break;
                    }
                if (value.Length < 1 || value.Length > 50)
                    good = false;
                if (good)
                    _kind = value;
                else
                    throw new Exception("Invalid Kind!");
            }
        }
        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }
        
        
    }
}
