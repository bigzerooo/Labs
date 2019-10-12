using System;
using System.Collections.Generic;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(";");
                if (tokens[0] == "END")
                    break;
                switch (tokens[0])
                {
                    case "Team":
                        if(tokens.Length==2)
                        { 
                        if (tokens[1] == " "||tokens[1]=="")
                            Console.WriteLine("A name should not be empty.");
                        else
                        {
                            Team t = new Team(tokens[1]);
                            teams.Add(t);
                        }
                        }
                        break;
                    case "Add":
                        if(tokens.Length==8)
                        {
                            string teamName = tokens[1];
                            string personName = tokens[2];
                            int endurance = Convert.ToInt32(tokens[3]);
                            int sprint = Convert.ToInt32(tokens[4]);
                            int dribble = Convert.ToInt32(tokens[5]);
                            int passing = Convert.ToInt32(tokens[6]);
                            int shooting = Convert.ToInt32(tokens[7]);
                            if (teamName == "" || teamName == " " || personName == "" || personName == " ")
                                Console.WriteLine("A name should not be empty.");
                            else if (endurance < 0 || endurance > 100)
                                Console.WriteLine("Endurance should be between 0 and 100.");
                            else if(sprint<0||sprint>100)
                                Console.WriteLine("Sprint should be between 0 and 100.");
                            else if(dribble<0||dribble>100)
                                Console.WriteLine("Dribble should be between 0 and 100.");
                            else if (passing < 0 || passing > 100)
                                Console.WriteLine("Passing should be between 0 and 100.");
                            else if (shooting < 0 || shooting > 100)
                                Console.WriteLine("Shooting should be between 0 and 100.");
                            else
                            {
                                Team team = null;
                                team = teams.Find(t => t.Name == teamName);
                                if (team != null)
                                {
                                    Player player = new Player(personName, endurance, sprint, dribble, passing, shooting);
                                    team.Add(player);
                                }
                                else
                                    Console.WriteLine($"Team {teamName} does not exist.");
                            }
                        }
                        break;
                    case "Remove":
                        if(tokens.Length==3)
                        {
                            Team team = null;
                            Player player = null;
                            team = teams.Find(t => t.Name == tokens[1]);
                            if (team != null)
                            {
                                player = team.Players.Find(p => p.Name == tokens[2]);
                                if (player != null)
                                    team.Remove(player.Name);
                                else
                                    Console.WriteLine($"Player {tokens[2]} is not in {team.Name} team.");
                            }
                            else
                                Console.WriteLine($"Team {tokens[1]} does not exist.");

                        }
                        break;
                    case "Rating":
                        if(tokens.Length==2)
                        {
                            Team team = null;
                            team = teams.Find(t => t.Name == tokens[1]);
                            if (team != null)
                                Console.WriteLine(team.Rating);
                            else
                                Console.WriteLine($"Team {team.Name} does not exist.");
                        }
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
