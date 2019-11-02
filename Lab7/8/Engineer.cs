using System;
using System.Collections.Generic;
class Engineer:SpecialisedSoldier,IEngineer
{
    public List<Repair> SetOfRepairs { get; set; }
    public Engineer(string id, string firstName, string lastName, double salary, string corps,List<Repair>repairs):
        base(id,firstName,lastName,salary,corps)
    {
        SetOfRepairs = repairs;
    }
    public override string ToString()
    {
        string Base= base.ToString();
        Base += "\nRepairs:\n";
        for(int i=0;i<SetOfRepairs.Count;i++)
        {
            Base += "\t";
            Base += SetOfRepairs[i];
            Base += "\n";
        }
        return Base;
    }
}