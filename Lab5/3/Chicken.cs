using System;
class Chicken
{
    string name;
    int age;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == "" || value == " " || value == null)
                Console.WriteLine("Name cannot be empty");
            else
                name = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0 || value > 15)
            { 
                Console.WriteLine("Age should be between 0 and 15");
                age = -1;
            }
            else
                age = value;
        }
    }
    public Chicken(string name, int age)
    {
        Name = name;
        Age = age;
    }
    int ProductPerDay()
    {
        if (Name == null || Name == "" || Name == " " || Age < 0 || Age > 15)
            return 0;
        else
            return 1;
    }
    public int CalculateProductPerDay()
    {
        return this.ProductPerDay();
    }
}
