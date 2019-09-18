using System;

namespace _1
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
        public Person(int a,string b){
            age = a;
            name=b;
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
            int n =Int32.Parse( Console.ReadLine());
            Person[] group = new Person[n];
            for (int i = 0; i < n; i++)
                group[i] = new Person();
            for (int i = 0; i < n; i++)
            { 
                Console.Write($"Введите {i+1} имя: ");
                group[i].Name = Console.ReadLine();
                Console.Write($"Введите {i + 1} возраст: ");
                group[i].Age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nВведенные данные: ");
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i+1}. {group[i].Name} {group[i].Age}");
        }
    }
}
