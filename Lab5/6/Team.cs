using System;
using System.Collections.Generic;
class Team
{
    public string Name { get; set; }
    public List<Player> Players = new List<Player>();
    public void Add(Player player)
    {
        Players.Add(player);
    }
    public void Remove(string name)
    {
        Players.RemoveAll(t => t.Name == name);
    }
    public int Rating
    {
        get
        {
            float average = 0;
            for (int i = 0; i < Players.Count; i++)
                average += Players[i].Average;
            if(Players.Count!=0)
                average /= Players.Count;            
            return (int)Math.Round(average);
        }
    }
    public Team(string name)
    {
        Name = name;
    }
}