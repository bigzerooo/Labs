using System;
class Child:Person
{
    public override int Age
    {
        get
        {
            return base.Age;
        }
        set
        {
            if (value <= 15)
                base.Age = value;
            else
                throw new Exception("Child's age must be less than 15!");
        }
    }
    public Child(string name,int age) : base(name, age)
    {

    }
}
