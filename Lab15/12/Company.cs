using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _12
{
    class Company
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
                if (value.All(x => char.IsLetter(x))&&value.Length<=20)
                    _name = value;
                else
                    throw new Exception("Invalid company name!");
            }
        }
        public Dictionary<string, int> Products;        
        public Company(string name)
        {
            Name = name;
            Products = new Dictionary<string, int>();
        }
        public void AddProduct(string name,int amount)
        {
            if (name.All(x => char.IsLetter(x))&&name.Length<=20)
            {
                if (Products.ContainsKey(name) && amount > 0)
                {
                    if (Products[name] + amount > 1000)
                        throw new Exception("Invalid amount!");
                    else
                        Products[name] += amount;
                }
                else if (amount > 0 && amount <= 1000)
                {
                    Products.Add(name, amount);
                }
                else
                {
                    throw new Exception("Invalid amount!");
                }
            }
            else
                throw new Exception("Invalid product name!");
            
        }
        public override string ToString()
        {
            string info = $"{Name}: ";
            foreach (var p in Products)
            {
                info += $"{p.Key}-{p.Value}";
                if (p.Equals(Products.Last())==false)
                    info += ", ";
            }
            return info;                
        }
    }
}
