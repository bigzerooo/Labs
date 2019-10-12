using System;
class Player
{
    public string Name { get; set; }
    int Endurance { get; set; }
    int Sprint { get; set; }
    int Dribble { get; set; }
    int Passing { get; set; }
    int Shooting { get; set; }
    public Player(string name,int endurance,int sprint,int dribble,int passing,int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }
    public float Average
    {


        get
        {
            return (float)(Endurance + Sprint + Dribble + Passing + Shooting) / (float)5;
        }
    }

}
