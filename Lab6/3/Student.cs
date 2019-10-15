using System;
class Student:Human
{
    string facultyNumber;
    string FacultyNumber
    {
        get
        {
            return facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10)
                throw new Exception("Invalid faculty number!");
            else
                facultyNumber = value;
        }
    }
    public Student(string firstName,string lastName,string facultyNumber) : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Faculty number: {FacultyNumber}");
    }
}