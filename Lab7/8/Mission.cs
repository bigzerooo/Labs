using System;
class Mission
{
    public string CodeName { get; set; }
    string _State;
    public string State
    {
        get
        {
            return _State;
        }
        set
        {
            if (value == "inProgress" || value == "Finished")
                _State = value;
            else
                throw new Exception("Invalid state");
        }
    }
    public Mission(string codeName,string state)
    {
        CodeName = codeName;
        State = state;
    }
    public void CompleteMission()
    {
        State = "Finished";
    }
    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}