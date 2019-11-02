using System;
abstract class Soldier:ISoldier
{
    public string ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Soldier(string id,string firstName,string lastName)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"Name: {FirstName} {LastName} Id: {ID}";
    }
}