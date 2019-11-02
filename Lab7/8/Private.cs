using System;
class Private:Soldier, IPrivate
{
    public double Salary { get; set; }
    public Private(string id, string firstName, string lastName,double salary):base(id,firstName,lastName)
    {
        Salary = salary;
    }
    public override string ToString()
    {
        return base.ToString()+$" Salary: {Salary.ToString("0.00")}";
    }
}
