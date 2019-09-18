using System;

namespace _7
{
    class Car
    {
        public string model;
        public double fuel_amount;
        public double fuel_consumption;
        public double distance_traveled;
        public void drive(double km)
        {
            if(fuel_amount>=fuel_consumption*km)
            {
                fuel_amount -= fuel_consumption * km;
                distance_traveled += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public void show()
        {
            Console.WriteLine($"{this.model} {this.fuel_amount.ToString("0.00")} {this.distance_traveled}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of cars: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Car[] a = new Car[n];
            for (int i = 0; i < n; i++)
                a[i] = new Car();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input {i + 1} car model: ");
            s1:
                string t = Console.ReadLine();
                bool good = true;
                for (int j = i; j >= 0; j--)
                    if (t == a[j].model)
                        good = false;
                if (good)
                {
                    a[i].model = t;
                }
                else
                {
                    Console.WriteLine("Not unique model, try again!");
                    goto s1;
                }
                Console.Write($"Input {i + 1} car fuel amount: ");
                a[i].fuel_amount = double.Parse(Console.ReadLine());
                Console.Write($"Input {i + 1} fuel consumption for 1 km: ");
                a[i].fuel_consumption = double.Parse(Console.ReadLine());
                a[i].distance_traveled = 0;
            }
                while (true)
                {
                    Console.Write("Drive ");
                    string a1 = Console.ReadLine();
                    if (a1 == "End")
                        break;

                    double a2 =double.Parse( Console.ReadLine());
                    for(int i=0;i<n;i++)
                    {
                        if (a1 == a[i].model)
                            a[i].drive(a2);
                    }
                }
            Console.Clear();
            for (int i = 0; i < n; i++)
                a[i].show();

            Console.ReadKey();
            }
        }
    }
