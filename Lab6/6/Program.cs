using System;
using System.Collections.Generic;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while(true)
            {
                string command = Console.ReadLine();
                if (command == "Beast!")
                    break;                
                string type = command;
                string[] tokens = Console.ReadLine().Split(" ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string gender = tokens[2];
                try
                {
                switch (type)
                {
                    case "Cat":
                        { 
                            Cat t = new Cat(name, age, gender);
                            animals.Add(t);
                        }
                        break;
                    case "Dog":
                        { 
                            Dog t = new Dog(name, age, gender);
                            animals.Add(t);
                        }
                        break;
                    case "Frog":
                        {
                            Frog t = new Frog(name, age, gender);
                            animals.Add(t);
                        }
                        break;
                    case "Kitten":
                        {
                            Kitten t = new  Kitten(name, age);
                            animals.Add(t);
                        }
                        break;
                    case "Tomcat":
                        {
                            Tomcat t = new Tomcat(name, age);
                        }
                        break;                        
                }
                }
                catch(Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            for (int i = 0; i < animals.Count; i++)
                animals[i].Display();
            Console.ReadKey();
        }
    }
}
