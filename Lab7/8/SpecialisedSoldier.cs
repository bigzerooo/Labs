using System;
abstract class SpecialisedSoldier:Private,ISpecialisedSoldier
{
    string _Corps;
    public string Corps
    {
        get
        {
            return _Corps;
        }
        set
        {
            if (value == "Airforces" || value == "Marines")
                _Corps = value;
            else
                throw new Exception("Invalid Corps"); 
        }
    }
    public SpecialisedSoldier(string id, string firstName, string lastName, double salary,string corps):base(id,firstName,lastName,salary)
    {
        Corps = corps;
    }
    public override string ToString()
    {
        return base.ToString()+$"\nCorps: {Corps}";
    }
}