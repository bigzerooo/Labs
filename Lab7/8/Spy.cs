using System;
class Spy:Soldier, ISpy
{
    public int CodeNumber { get; set; }
    public Spy(string id, string firstName, string lastName,int codeNumber) : base(id, firstName, lastName)
    {
        CodeNumber = codeNumber;
    }
    public override string ToString()
    {
        return base.ToString()+$"\nCode Number: {CodeNumber}";
    }
}