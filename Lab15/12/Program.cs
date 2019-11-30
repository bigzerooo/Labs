using System;
using System.Linq;
using System.Collections.Generic;
namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100)
                {
                    Dictionary<string, Company> companies = new Dictionary<string, Company>();
                    char[] chars = { ' ', '-', '|' };
                    for (int i = 0; i < n; i++)
                    {
                        string[] tokens = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries);
                        if (companies.ContainsKey(tokens[0]))
                        {
                            try
                            {
                                companies[tokens[0]].AddProduct(tokens[2], int.Parse(tokens[1]));
                            }
                            catch (Exception x)
                            {
                                Console.WriteLine(x.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                Company t = new Company(tokens[0]);
                                t.AddProduct(tokens[2], int.Parse(tokens[1]));
                                companies.Add(tokens[0], t);
                            }
                            catch (Exception x)
                            {
                                Console.WriteLine(x.Message);
                            }
                        }
                    }
//                    companies.OrderBy(x=>x.Key);
                    foreach (var company in companies.OrderBy(x => x.Key))
                        Console.WriteLine(company.Value);
                }
                else
                    throw new Exception("Invalid number of commands!");
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
            
        }
    }
}
