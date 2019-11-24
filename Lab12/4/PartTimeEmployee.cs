using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class PartTimeEmployee:IEmployee
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
        public int WorkHours { get; set; }
        public PartTimeEmployee(string name)
        {
            Name = name;
            WorkHours = 20;
        }
    }
}
