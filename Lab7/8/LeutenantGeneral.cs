using System;
using System.Collections.Generic;
class LeutenantGeneral:Private,ILeutenantGeneral
{
    public List<Private> SetOfPrivates { get; set; }//Наверно неправильно
    public LeutenantGeneral(string id, string firstName, string lastName, double salary,List<Private> privates) : base(id, firstName, lastName, salary)
    {
        SetOfPrivates = privates;
    }
    public override string ToString()
    {
        string Base = base.ToString();
        Base += "\nPrivates:\n";
        for (int i = 0; i < SetOfPrivates.Count; i++)
        {
            Base += "\t";
            Base += SetOfPrivates[i];
            Base += "\n";
        }
        return Base;
    }
}