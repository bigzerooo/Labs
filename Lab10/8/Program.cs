using System;
using System.Collections.Generic;
namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            List<Pet> pets=new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();
            try
            {
                if (n < 1 || n > 1000)
                    throw new Exception("Invalid number of commands!");
                for(int i = 0; i < n; i++)
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {                    
                        switch (tokens[0].ToLower())
                        {
                            case "create":
                                    { 
                                        if(tokens[1].ToLower()=="pet")
                                        {
                                            Pet t = new Pet(tokens[2], int.Parse(tokens[3]), tokens[4]);
                                            pets.Add(t);
                                        }
                                        else if (tokens[1].ToLower() == "clinic")
                                        {
                                            Clinic t = new Clinic(tokens[2], int.Parse(tokens[3]));
                                            clinics.Add(t);
                                        }
                                        break;
                                    }
                            case "add":
                                    {
                                        Clinic clinic;
                                        clinic = clinics.Find(x => x.Name == tokens[2]);
                                        Pet pet;
                                        pet = pets.Find(x => x.Name == tokens[1]);
                                        Console.WriteLine(clinic.Add(pet));
                                        break;
                                    }
                            case "release":
                                    {
                                    Clinic clinic;
                                    clinic=clinics.Find(x => x.Name == tokens[1]);
                                    Console.WriteLine(clinic.Release());
                                    break;
                                }
                            case "hasemptyrooms":
                                    {
                                    Clinic clinic;
                                    clinic = clinics.Find(x => x.Name == tokens[1]);
                                    Console.WriteLine(clinic.HasEmptyRooms());
                                    break;
                                }
                            case "print":
                                    {
                                    if(tokens.Length==2)
                                    {
                                        Clinic clinic;
                                        clinic = clinics.Find(x => x.Name == tokens[1]);
                                        clinic.Print();                                        
                                    }
                                    else if (tokens.Length == 3)
                                    {
                                        Clinic clinic;
                                        clinic = clinics.Find(x => x.Name == tokens[1]);
                                        Room room;
                                        room = clinic.Rooms.Find(x => x.Number == int.Parse(tokens[2]));
                                        room.Print();
                                    }
                                    break;
                                }
                        }
                    }
                    catch(Exception x1)
                    {
                        Console.WriteLine(x1.Message);
                    }
                }
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
            
        }
    }
}
