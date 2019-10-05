using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class Car
    {
        public Engine Engine;
        public Cargo Cargo;
        public string Model { get; set; }
        public List<Tire> Tires = new List<Tire>();
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3age, double tire4Pressure, int tire4age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tire tire1 = new Tire(tire1Pressure, tire1Age);
            Tire tire2 = new Tire(tire2Pressure, tire2Age);
            Tire tire3 = new Tire(tire3Pressure, tire3age);
            Tire tire4 = new Tire(tire4Pressure, tire4age);
            Tires.Add(tire1);
            Tires.Add(tire2);
            Tires.Add(tire3);
            Tires.Add(tire4);
        }                        
    }
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
        public Engine(int speed,int power)
        {
            Speed = speed;
            Power = power;
        }
    }
    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
        public Cargo(int weight,string type)
        {
            Weight = weight;
            Type = type;
        }
    }
    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }
        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                double tire1Pressure = double.Parse(parameters[5]);
                int tire1age = int.Parse(parameters[6]);
                double tire2Pressure = double.Parse(parameters[7]);
                int tire2age = int.Parse(parameters[8]);
                double tire3Pressure = double.Parse(parameters[9]);
                int tire3age = int.Parse(parameters[10]);
                double tire4Pressure = double.Parse(parameters[11]);
                int tire4age = int.Parse(parameters[12]);
                cars.Add(new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1age, tire2Pressure, tire2age, tire3Pressure, tire3age, tire4Pressure, tire4age));
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                for(int i=0;i<cars.Count;i++)
                {
                    bool badPressure = false;
                    for (int j = 0; j < 4; j++)
                        if (cars[i].Tires[j].Pressure < 1)
                            badPressure = true;
                    if (cars[i].Cargo.Type == "fragile"&&badPressure)
                        Console.WriteLine(cars[i].Model);
                }                
            }
            if(command=="flamable")
            {
                for (int i = 0; i < cars.Count; i++)
                    if (cars[i].Cargo.Type == "flamable" && cars[i].Engine.Power > 250)
                        Console.WriteLine(cars[i].Model);
            }
            Console.ReadKey();
        }
    }
}