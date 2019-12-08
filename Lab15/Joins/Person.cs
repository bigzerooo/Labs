using System;
using System.Collections.Generic;
using System.Text;

namespace Joins
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
