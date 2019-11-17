using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class Room
    {
        public int Number { get; set; }
        public Pet Pet { get; set; }
        public Room(int number)
        {
            Number = number;
            Pet = null;
        }
        public bool IsEmpty()
        {
            if (Pet == null)
                return true;
            else
                return false;
        }
        public void Add(Pet pet)
        {
            Pet = pet;
        }
        public void Remove()
        {
            Pet = null;
        }
        public void Print()
        {
            if (IsEmpty())
                Console.WriteLine("Room empty");
            else
                Console.WriteLine($"{Pet.Name} {Pet.Age} {Pet.Kind}");
        }
    }
}
