using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{

    public class Job//Паблишер
    {

        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool good = true;
                for (int i = 0; i < value.Length; i++)
                    if (char.IsLetterOrDigit(value[i]) == false)
                    {
                        good = false;
                        break;
                    }
                if (good)
                    _name = value;
                else
                    throw new Exception("Invalid Name!");
            }
        }
        public int HoursOfWork { get; set; }
        public IEmployee Employee { get; set; }
        public delegate void DeleteEventHandler(Job sender);
        public event DeleteEventHandler Delete;
        public void Update()
        {
            if (Employee != null)
                HoursOfWork -= Employee.WorkHours;
            if (HoursOfWork <= 0)
            {
                Console.WriteLine($"Job {Name} done!");
                Delete?.Invoke(this);
            }
        }
        public void Info()
        {
            Console.WriteLine($"Job: {Name} Hours Remaining: {HoursOfWork}");
        }
        public Job(string name, int hoursOfWork, IEmployee employee)
        {
            if (hoursOfWork < 1 || hoursOfWork > 1000)
                throw new Exception("Invalid hours of work!");
            else
            {
                Name = name;
                HoursOfWork = hoursOfWork;
                Employee = employee;
            }
        }
    }
}
