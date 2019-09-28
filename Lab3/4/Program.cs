using System;

namespace _4
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }

        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }

        }
        public Person()
        {
            name = "no name";
            age = 1;
        }
        public Person(int a)
        {
            name = "no name";
            age = a;
        }
        public Person(int a, string b)
        {
            age = a;
            name = b;
        }
        public Person(string b, int a)
        {
            age = a;
            name = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество персон: ");
            int n = Int32.Parse(Console.ReadLine());
            Person[] group = new Person[n];
            for (int i = 0; i < n; i++)
                group[i] = new Person();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} имя: ");
                group[i].Name = Console.ReadLine();
                Console.Write($"Введите {i + 1} возраст: ");
                group[i].Age = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<n;i++)            //Условная сортировка лишь по 1 букве
            {
                for(int j=i+1;j<n;j++)
                {                        
                    if(group[i].Name[0]>group[j].Name[0])
                    {
                        Person t = group[j];
                        group[j] = group[i];
                        group[i] = t;                       
                    }
                }
            }

            for (int i=0;i<n;i++)
            {
                if(group[i].Age>30)
                 Console.WriteLine($"{group[i].Name} - {group[i].Age}");
            }
            Console.ReadKey();
        }
    }
}
