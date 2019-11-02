using System;
using System.Collections.Generic;
class Commando:SpecialisedSoldier,ICommando
{
    public List<Mission> SetOfMissions { get; set; }
    public Commando(string id, string firstName, string lastName, double salary, string corps,List<Mission>missions) :
        base(id, firstName, lastName, salary, corps)
    {
        SetOfMissions = missions;
    }
    public override string ToString()
    {
        string Base= base.ToString();
        Base += "\nMissions:\n";
        for(int i=0;i<SetOfMissions.Count;i++)
        {
            Base += "\t";
            Base += SetOfMissions[i];
            Base += "\n";
        }
        return Base;
    }
}