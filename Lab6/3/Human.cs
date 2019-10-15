using System;
class Human
{
    string firstName;
    string lastName;
    string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (value[0] < 'A' || value[0] > 'Z')
                throw new Exception("Expected upper case letter! Argument: firstName");
            else if (value.Length <= 3)
                throw new Exception("Expected length at least 4 symbols! Argument: firstName");
            else
                firstName = value;
        }
    }
    string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            if (value[0] < 'A' || value[0] > 'Z')
                throw new Exception("Expected upper case letter! Argument: lastName");
            else if (value.Length <= 2)
                throw new Exception("Expected length at least 3 symbols! Argument: lastName");
            else
                lastName = value;
        }
    }
    public Human(string firstName,string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public virtual void Display()
    {
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"First Name: {LastName}");
    }
}