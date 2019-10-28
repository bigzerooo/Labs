using System;
using System.Collections.Generic;
namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            for(int i=0;i<n;i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(tokens.Length>0)
                { 
                    string name = tokens[0];
                    bool unique = true; 
                    for (int j = 0; j < citizens.Count; j++)
                        if (citizens[j].Name == name)
                            unique = false;
                    for (int j = 0; j < rebels.Count; j++)
                        if (rebels[j].Name == name)
                            unique = false;
                    if (unique == false)
                        continue;
                }
                if (tokens.Length == 3)
                { 
                    Rebel t = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);                    
                    rebels.Add(t);
                }
                if(tokens.Length==4)
                {
                    Citizen t = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    citizens.Add(t);
                }
            }
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                    break;
                for (int i = 0; i < citizens.Count; i++)
                    if (citizens[i].Name == name)
                        citizens[i].BuyFood();
                for (int i = 0; i < rebels.Count; i++)
                    if (rebels[i].Name == name)
                        rebels[i].BuyFood();
            }
            int k = 0;
            for(int i=0;i<citizens.Count;i++)
            {
                k += citizens[i].Food;
            }
            for(int i=0;i<rebels.Count;i++)
            {
                k += rebels[i].Food;
            }
            Console.WriteLine(k);
        }
    }
}
