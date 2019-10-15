using System;
class Worker:Human
{
    double weekSalary;
    double hoursPerDay;
    double hourSalary;
    double WeekSalary
    {
        get
        {
            return weekSalary;
        }
        set
        {
            if (value > 10)
                weekSalary = value;
            else
                throw new Exception("Expected value mismatch! Argument: weekSalary");
        }
    }
    double HoursPerDay
    {
        get
        {
            return hoursPerDay;
        }
        set
        {
            if (value < 1 || value > 12)
                throw new Exception("Expected value mismatch! Argument: workHoursPerDay");
            else
                hoursPerDay = value;
        }
    }
    double HourSalary
    {
        get
        {
            return hourSalary;
        }
        set
        {
            hourSalary = value;
        }
    }
    public Worker(string firstName, string lastName,double weekSalary,double hoursPerDay) : base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        HoursPerDay = hoursPerDay;
        HourSalary = weekSalary / (hoursPerDay * 5);
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Week Salary: {WeekSalary:f2}");
        Console.WriteLine($"Hours per day: {HoursPerDay:f2}");
        Console.WriteLine($"Salary per hour: {HourSalary:f2}");
    }
}