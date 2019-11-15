using System;
using System.Collections.Generic;
namespace _6
{
    class Person
    {
        string _name;
        int _age;
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
                if (value.Length < 1 || value.Length > 50)
                    good = false;

                if (good)
                    _name = value;
                else
                    throw new Exception("Name is invalid!");
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
                if (value >= 0 && value <= 100)
                    _age = value;
                else
                    throw new Exception("Invalid Age!");
            }
        }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
    class FirstComparator:IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1.Name.Length != p2.Name.Length)
                return p1.Name.Length.CompareTo(p2.Name.Length);//сравнивает длину имен
            else
            {
                string s1 = p1.Name.ToLower();
                string s2 = p2.Name.ToLower();
                return s1[0].CompareTo(s2[0]);//сравнивает первые буквы имен независимо от регистра
            }
                
        }
    }
    class SecondComparator : IComparer<Person>
    {
        public int Compare(Person p1,Person p2)
        {
            return p1.Age.CompareTo(p2.Age);
        }
    }
}
