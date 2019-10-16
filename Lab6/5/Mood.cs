using System;
class Mood
{
    string name;
    int happiness;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Happiness
    {
        get
        {
            return happiness;
        }
        private set
        {
            happiness = value;
        }
    }
    public Mood(int hapiness)
    {
        Happiness = hapiness;
        if (hapiness < -5)
            Name = "Angry";
        else if (hapiness >= -5 && hapiness <= 0)
            Name = "Sad";
        else if (hapiness >= 1 && hapiness <= 15)
            Name = "Happy";
        else
            Name = "JavaScript";
    }
}