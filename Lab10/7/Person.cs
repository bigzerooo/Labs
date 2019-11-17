using System;
using System.Collections.Generic;

namespace _7
{
    class Person: IComparable<Person>
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
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType() && this.Age == ((Person)obj).Age && this.Name == ((Person)obj).Name)
                return true;
            else
                return false;
        }//Два обьекта равны только если это однотипные обьекты с равными свойствами
        public override int GetHashCode()
        {
            int hash = 17;//17 - одно из простых чисел
            hash = hash * 23 + Name.GetHashCode();//23 - второе простое число
            hash = hash * 23 + Age.GetHashCode();
            return hash;
        }
        public int CompareTo(Person person)
        {
            if (this.Name != person.Name)
                return this.Name.CompareTo(person.Name);
            else
                return this.Age.CompareTo(person.Age);
        }
        /*Уникальный код - два простых числа, действия как вверху.
        I usually go with something like the implementation given in
        Josh Bloch's fabulous Effective Java. It's fast and creates a
        pretty good hash which is unlikely to cause collisions. */

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
