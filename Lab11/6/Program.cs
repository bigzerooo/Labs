using System;
using System.Collections.Generic;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<TrafficLight> trafficLights = new List<TrafficLight>();

            for (int i = 0; i < tokens.Length; i++)
            {
                try
                {
                    trafficLights.Add(new TrafficLight(tokens[i]));
                }
                catch(Exception x)
                {
                    Console.WriteLine($"{x.Message}");
                }
            }
                
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < trafficLights.Count; j++)
                {                    
                    try
                    {
                        trafficLights[j].Change();
                        Console.Write($"{trafficLights[j].State} ");
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine($"{x.Message}");
                    }
                }                    
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
