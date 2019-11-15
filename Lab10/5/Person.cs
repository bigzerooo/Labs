using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace _5
{
    class Person:IComparable<Person>
    {
        public string Name { get; set; }
        int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 2 && value <= 100)
                    _age = value;
                else
                    throw new Exception("Invalid age!");
            }
        }
        public string Town { get; set; }
        public Person(string name,int age,string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public int CompareTo(Person person)
        {
            if (Name.CompareTo(person.Name) != 0)
                return Name.CompareTo(person.Name);
            else if (Age.CompareTo(person.Age) != 0)
                return Age.CompareTo(person.Age);
            else
                return Town.CompareTo(person.Town);
        }        
    }
}
