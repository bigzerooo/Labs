using System;

namespace _3
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
    class Family
    {
        static public int max_capacity=10;
        private int n;
        private Person[] Member=new Person[max_capacity];
        public Family()
        {
            n = 0;
            
        }
        public void AddMember(Person member)
        {
            Member[n] = member;
            n++;
        }
        public void WriteMembers()
        {
            
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i+1}. {Member[i].Name} {Member[i].Age}");
            
        }
        public void WriteMember(int i)
        {
            Console.WriteLine($"{Member[i].Name} {Member[i].Age}");
        }
        public Person GetMember(int i)
        {
            return Member[i];
        }
        public Person GetOldestMember()
        {
            int max = Member[0].Age;
            Person oldest = Member[0];
            for(int i=0;i<n;i++)
            {
                if(Member[i].Age>max)
                {
                    oldest = Member[i];
                    max = Member[i].Age;
                }

            }
            return oldest;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество персон:");
            int n;
            while(true)
            { 
                 n= Int32.Parse(Console.ReadLine());
                if (n <= 10)
                    break;
                else
                {
                    Console.WriteLine($"Максимальное количество членов семьи: {Family.max_capacity}.");
                }
            }
            Family fam = new Family();
            for(int i=0;i<n;i++)
            {
                Person a = new Person();
                Console.Write($"Введите {i + 1} имя: ");
                a.Name = Console.ReadLine();
                Console.Write($"Введите {i + 1} возраст: ");
                a.Age = Convert.ToInt32(Console.ReadLine());
                fam.AddMember(a);
            }
            Person oldest = fam.GetOldestMember();
            Console.WriteLine($"Самый старший: {oldest.Name} {oldest.Age}");
            Console.ReadKey();
        }
    }
}
