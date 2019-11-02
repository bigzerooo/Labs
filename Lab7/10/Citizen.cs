using System;
class Citizen : IResident, IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    string IResident.GetName()
    {
        return "Mr/Ms/Mrs " + Name;
    }
    string IPerson.GetName()
    {
        return Name;
    }
    public Citizen(string name,string country,int age)
    {
        Name = name;
        Age = age;
        Country = country;
    }
}