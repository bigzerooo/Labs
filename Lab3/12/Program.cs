using System;
using System.Collections;
using System.Collections.Generic;
namespace _12
{
    public class Person
    {
        public string name;
        public Company company;
        public Car car;
        public List<Parent> parent = new List<Parent>();
        public List<Pokemon> pokemon = new List<Pokemon>();
        public List<Children> children = new List<Children>();
        public Person()
        {
            company = new Company();
            car = new Car();
            parent = new List<Parent>();
            pokemon = new List<Pokemon>();
            children = new List<Children>();
        }
        public class Company
        {
            public string name="";
            public string department="";
            public double salary=0;
        }
        public class Pokemon
        {
            public string name="";
            public string type="";
        }
        public class Parent
        {
            public string name="";
            public string birthday="";
        }
        public class Children
        {
            public string name="";
            public string birthday="";
        }
        public class Car
        {
            public string model="";
            public double speed=0;
        }
        public void getInfo()
        {
            Console.WriteLine(name);
            if(company.name!="")
            Console.WriteLine($"Company:\n  {company.name} {company.department} {company.salary.ToString("0.00")}");
            if(car.model!="")
            Console.WriteLine($"Car:\n  {car.model} {car.speed}");
            Console.WriteLine($"Pokemons:");
            for(int i=0;i<pokemon.Count;i++)
                Console.WriteLine($"  {pokemon[i].name} {pokemon[i].type}");
            Console.WriteLine($"Parents:");
            for(int i=0;i<parent.Count;i++)
                Console.WriteLine($"  {parent[i].name} {parent[i].birthday}");
            Console.WriteLine($"Children:");
            for(int i=0;i<children.Count;i++)
                Console.WriteLine($"  {children[i].name} {children[i].birthday}");
        }
    }
    class Program
    {
        public static void noDots(ref string a)
        {
            int n = a.Length;
            char[] b = new char[n];
            for (int i = 0; i < n; i++)
            {
                if (a[i] == '.')
                    b[i] = ',';
                else
                    b[i] = a[i];
            }
            a = "";
            for (int i = 0; i < n; i++)
                a += b[i];
        }
        static void Main(string[] args)
        {
            List <Person> a = new List<Person>();
            while (true)
            {
                string s1 = Console.ReadLine();
                if (s1 == "End")
                    break;
                if(s1 == "Help")
                {
                    Console.WriteLine("<Name> company <companyName> <department> <salary>");
                    Console.WriteLine("<Name> pokemon <pokemonName> <pokemonType>");
                    Console.WriteLine("<Name> parents <parentName> <parentBirthday>");
                    Console.WriteLine("<Name> children <childName> <childBirthday>");
                    Console.WriteLine("<Name> car <carModel> <carSpeed>");
                    Console.WriteLine("End");
                    continue;
                }
                string[] s2 = s1.Split(" ");
                if(s2.Length<4||s2.Length>5)
                {
                    Console.WriteLine("Error. Wrong command. Type \"Help\" for more info");
                    continue;
                }
                switch (s2[1])
                {
                    case "company":
                        if(s2.Length!=5)
                        {
                            Console.WriteLine("Error. Wrong syntaxis.Type \"Help\" for more info");
                            continue;
                        }
                        else
                        {
                            bool exists = false;
                            for(int i=0;i<a.Count;i++)
                            {
                                if (a[i].name == s2[0])
                                { 
                                    exists = true;
                                    a[i].company.name = s2[2];
                                    a[i].company.department = s2[3];
                                    noDots(ref s2[4]);
                                    a[i].company.salary= Convert.ToDouble(s2[4]);
                                    break;
                                }
                            }
                            if(!exists)
                            {
                                Person t1 = new Person();
                                Person.Company t2 = new Person.Company();
                                t2.name = s2[2];
                                t2.department = s2[3];
                                noDots(ref s2[4]);
                                t2.salary =Convert.ToDouble(s2[4]);
                                t1.company = t2;
                                t1.name = s2[0];
                                a.Add(t1);
                            }
                        }
                        break;
                    case "pokemon":
                        if(s2.Length!=4)
                        {
                            Console.WriteLine("Error. Wrong syntaxis.Type \"Help\" for more info");
                            continue;
                        }
                        else
                        {
                            bool exists = false;
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].name == s2[0])
                                {
                                    exists = true;
                                    Person.Pokemon t = new Person.Pokemon();
                                    t.name = s2[2];
                                    t.type = s2[3];
                                    a[i].pokemon.Add(t);
                                    break;
                                }
                            }
                            if (!exists)
                            {
                                Person t1 = new Person();
                                Person.Pokemon t2 = new Person.Pokemon();
                                t2.name = s2[2];
                                t2.type = s2[3];
                                t1.pokemon.Add(t2);
                                t1.name = s2[0];
                                a.Add(t1);
                            }
                        }
                        break;
                    case "parents":
                        if (s2.Length != 4)
                        {
                            Console.WriteLine("Error. Wrong syntaxis.Type \"Help\" for more info");
                            continue;
                        }
                        else
                        {
                            bool exists = false;
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].name == s2[0])
                                {
                                    exists = true;
                                    Person.Parent t = new Person.Parent();
                                    t.name = s2[2];
                                    t.birthday = s2[3];
                                    a[i].parent.Add(t);                                    
                                    break;
                                }
                            }
                            if (!exists)
                            {
                                Person t1 = new Person();
                                Person.Parent t2 = new Person.Parent();
                                t2.name = s2[2];
                                t2.birthday = s2[3];
                                t1.parent.Add(t2);
                                t1.name = s2[0];
                                a.Add(t1);
                            }
                        }
                        break;
                    case "children":
                        if (s2.Length != 4)
                        {
                            Console.WriteLine("Error. Wrong syntaxis.Type \"Help\" for more info");
                            continue;
                        }
                        else
                        {
                            bool exists = false;
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].name == s2[0])
                                {
                                    exists = true;
                                    Person.Children t = new Person.Children();
                                    t.name = s2[2];
                                    t.birthday = s2[3];
                                    a[i].children.Add(t);                                    
                                    break;
                                }
                            }
                            if (!exists)
                            {
                                Person t1 = new Person();
                                Person.Children t2 = new Person.Children();
                                t2.name = s2[2];
                                t2.birthday = s2[3];
                                t1.children.Add(t2);
                                t1.name = s2[0];
                                a.Add(t1);
                            }
                        }
                        break;
                    case "car":
                        if (s2.Length != 4)
                        {
                            Console.WriteLine("Error. Wrong syntaxis.Type \"Help\" for more info");
                            continue;
                        }
                        else
                        {
                            bool exists = false;
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].name == s2[0])
                                {
                                    exists = true;
                                    a[i].car.model = s2[2];
                                    a[i].car.speed = Convert.ToDouble(s2[3]);
                                    break;
                                }
                            }
                            if (!exists)
                            {
                                Person t1 = new Person();
                                Person.Car t2 = new Person.Car();
                                t2.model = s2[2];
                                t2.speed =Convert.ToInt32( s2[3]);                                
                                t1.car = t2;
                                t1.name = s2[0];
                                a.Add(t1);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Error. Wrong command. Type \"Help\" for more info");
                        continue;                        
                }
            }
            Console.WriteLine("\n");
            while (true)
            {
                string s1 = Console.ReadLine();
                if (s1 == "End")
                    break;
                if (s1 == "Help")
                {
                    Console.WriteLine("Existing people: ");
                    for (int i = 0; i < a.Count; i++)
                        Console.Write($"{a[i].name} ");
                    Console.Write("End");
                    Console.WriteLine();
                    continue;

                }
                bool exists = false;
                for (int i = 0; i < a.Count; i++)
                    if (s1 == a[i].name)
                    {
                        exists = true;
                        a[i].getInfo();
                    }
                if (!exists)
                    Console.WriteLine("Error. Person not found.Type \"Help\" for more info");

                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
