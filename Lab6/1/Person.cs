using System;
class Person
{
    string name;
    int age;
    public virtual string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length >= 3)
                name = value;
            else
                throw new Exception("Name's length should not be less than 3 symbols!");
        }
    }
    public virtual int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value > 0)
                age = value;
            else
                throw new Exception("Age must be positive!");
        }
    }
    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
