using System;
using System.Collections.Generic;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>();
            MyList jobs = new MyList();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length==1 && tokens[0] == "End")
                {
                    break;
                }                    
                if(tokens.Length==4 &&tokens[0]=="Job")
                {
                    IEmployee employee = employees.Find(x => x.Name == tokens[3]);
                    if(employee!= null)
                    {
                        Job t = new Job(tokens[1], int.Parse(tokens[2]), employee);
                        jobs.Add(t);
                    }
                }
                if(tokens.Length==2 && tokens[0] == "StandardEmployee")
                {
                    StandardEmployee t = new StandardEmployee(tokens[1]);
                    employees.Add(t);
                }
                if (tokens.Length == 2 && tokens[0] == "PartTimeEmployee")
                {
                    PartTimeEmployee t = new PartTimeEmployee(tokens[1]);
                    employees.Add(t);
                }
                if (tokens.Length == 2 && tokens[0] == "Pass" && tokens[1] == "Week")
                {
                    jobs.PassWeek();
                }
                if (tokens.Length == 1 && tokens[0] == "Status")
                {
                    jobs.Status();
                }
            }
        }
    }
}
