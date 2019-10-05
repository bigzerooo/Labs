using System;
using System.Collections.Generic;
using System.Collections;

namespace P04_Hospital
{
    class Doctor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Patient> Patients = new List<Patient>();
        public Doctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Display()
        {
            List<string> T = new List<string>();
            for (int i = 0; i < Patients.Count; i++)
                T.Add(this.Patients[i].Name);
            T.Sort();
            for (int i = 0; i < T.Count; i++)
                Console.WriteLine(T[i]);
        }
    }
    class Department
    {
        public string Name { get; set; }
        public Room[] Rooms = new Room[20];
        public Department(string name)
        {
            Name = name;
            for (int i = 0; i < 20; i++)
            {
                Rooms[i] = new Room();
                for (int j = 0; j < 3; j++)
                {
                    Rooms[i].Beds[j] = new Bed();
                    this.Rooms[i].Beds[j].Occupied = false;
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 3; j++)
                    if (this.Rooms[i].Beds[j].Occupied)
                        Console.WriteLine(this.Rooms[i].Beds[j].Patient.Name);
        }
        public void Display(int x)
        {
            List<string> T = new List<string>();
            for (int j = 0; j < 3; j++)
                if (this.Rooms[x].Beds[j].Occupied)
                    T.Add(this.Rooms[x].Beds[j].Patient.Name);
            T.Sort();
            for (int i = 0; i < T.Count; i++)
                Console.WriteLine(T[i]);
        }
    }
    class Room
    {
        public Bed[] Beds = new Bed[3];
    }
    class Patient
    {
        public string Name { get; set; }
        public Patient(string name)
        {
            Name = name;
        }
    }
    class Bed
    {
        public Patient Patient { get; set; }
        public bool Occupied { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Doctor> doctors = new List<Doctor>();
            List<Department> departments = new List<Department>();
            Console.WriteLine("Input: Department DocFirstName DocLastName PatientName");
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Output")
                    break;
                else
                {
                    string[] command1 = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (command1.Length != 4)
                    {
                        Console.WriteLine("Wrong command!");
                        continue;
                    }
                    else
                    {
                        string dName, fName, lName, pName;
                        dName = command1[0];
                        fName = command1[1];
                        lName = command1[2];
                        pName = command1[3];
                        int iDep = -1, iDoc = -1;
                        bool exists = false;
                        for (int i = 0; i < departments.Count; i++)
                            if (departments[i].Name == dName)
                            {
                                exists = true;
                                iDep = i;
                            }
                        if (!exists)
                        {
                            Department t = new Department(dName);
                            iDep = departments.Count;
                            departments.Add(t);
                        }
                        exists = false;
                        for (int i = 0; i < doctors.Count; i++)
                            if (doctors[i].FirstName == fName && doctors[i].LastName == lName)
                            {
                                exists = true;
                                iDoc = i;
                            }
                        if (!exists)
                        {
                            Doctor t = new Doctor(fName, lName);
                            iDoc = doctors.Count;
                            doctors.Add(t);
                        }
                        Patient x = new Patient(pName);
                        doctors[iDoc].Patients.Add(x);
                        bool foundBed = false;
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (departments[iDep].Rooms[i].Beds[j].Occupied == false)
                                {
                                    departments[iDep].Rooms[i].Beds[j].Occupied = true;
                                    departments[iDep].Rooms[i].Beds[j].Patient = x;
                                    foundBed = true;
                                    break;
                                }
                            }
                            if (foundBed)
                                break;
                        }
                        if (!foundBed)
                            Console.WriteLine("Sorry, department is full.");
                    }
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                    break;
                else
                {
                    string[] command1 = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (command1.Length != 1 && command1.Length != 2)
                    {
                        Console.WriteLine("Wrong command!");
                        continue;
                    }
                    else
                    {
                        if (command1.Length == 1)
                            for (int i = 0; i < departments.Count; i++)
                                if (departments[i].Name == command1[0])
                                    departments[i].Display();

                        if (command1.Length == 2)
                            {
                                if (command1[1][0] >= 48 && command1[1][0] <= 57)
                                {
                                    for (int i = 0; i < departments.Count; i++)
                                        if (departments[i].Name == command1[0])
                                            departments[i].Display(Convert.ToInt32(command1[1]) - 1);
                                }
                                else
                                {
                                    for (int i = 0; i < doctors.Count; i++)
                                        if (doctors[i].FirstName == command1[0] && doctors[i].LastName == command1[1])
                                            doctors[i].Display();
                                }
                            }
                        }

                    }
            }
            Console.ReadKey();                                    
        }

                
    }
}
    
