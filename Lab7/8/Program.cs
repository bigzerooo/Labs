using System;
using System.Collections.Generic;
namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> Army = new List<ISoldier>();
            List<Private> Privates = new List<Private>();//конкретно приваты
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1 && tokens[0] == "End")
                {
                    break;
                }                    
                if (tokens.Length==5 &&tokens[0]=="Private")
                {
                    Private t = new Private(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]));
                    Privates.Add(t);
                    Army.Add(t);
                }
                if (tokens.Length >= 5 && tokens[0] == "LeutenantGeneral")
                {
                    List<Private> privates = new List<Private>();

                    for(int i=5;i<tokens.Length;i++)
                    {
                        for(int j = 0; j < Privates.Count; j++)
                        {
                            if (tokens[i] == Privates[j].ID)
                                privates.Add(Privates[j]);
                        }
                    }

                    LeutenantGeneral t = new LeutenantGeneral(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), privates);
                    Army.Add(t);
                }
                if (tokens.Length >= 6 && tokens.Length % 2 == 0 && tokens[0] == "Engineer")
                {
                    List<Repair> repairs = new List<Repair>();
                    for(int i = 6; i < tokens.Length; i += 2)
                    {
                        Repair x = new Repair(tokens[i], int.Parse(tokens[i + 1]));
                        repairs.Add(x);
                    }
                    try
                    { 
                        Engineer t = new Engineer(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5], repairs);
                        Army.Add(t);
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine(x.Message);
                    }
                }
                if (tokens.Length >= 6 && tokens.Length % 2 == 0 && tokens[0] == "Commando")
                {
                    List<Mission> missions = new List<Mission>();
                    for(int i = 6; i < tokens.Length; i += 2)
                    {
                        try
                        {
                            Mission x = new Mission(tokens[i], tokens[i + 1]);
                            missions.Add(x);
                        }
                        catch(Exception xs)
                        {
                            Console.WriteLine(xs.Message);
                        }
                    }

                    try
                    { 
                        Commando t = new Commando(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5], missions);
                        Army.Add(t);
                    }
                    catch(Exception x)
                    {
                        Console.WriteLine(x.Message);
                    }


                }
                if(tokens.Length==5&&tokens[0]=="Spy")
                {
                    Spy t = new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]));
                    Army.Add(t);
                }
            }
            for(int i=0;i<Army.Count;i++)
            {
                Console.WriteLine(Army[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
