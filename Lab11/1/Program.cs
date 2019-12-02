using System;
using System.Reflection;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(RichSoilLand);
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "HARVEST")
                    break;
                else
                {
                                        
                    switch (command)
                    {
                        case "private":
                        case "protected":
                            {
                                FieldInfo[] fields1 = myType.GetFields(BindingFlags.NonPublic|BindingFlags.Instance);
                                if (command == "protected")
                                    foreach (FieldInfo field in fields1)
                                    {
                                        if (field.IsPrivate == false)
                                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                                    }
                                else
                                    foreach (FieldInfo field in fields1)
                                    {
                                        if (field.IsPrivate)
                                            Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                                    }
                            }                          
                            break;                        
                        case "public":
                            {
                                FieldInfo[] fields2 = myType.GetFields(BindingFlags.Public | BindingFlags.Instance);
                                foreach (FieldInfo field in fields2)
                                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                            }
                            break;
                        case "all":
                            FieldInfo[] fields3 = myType.GetFields(BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic);
                            foreach(FieldInfo field in fields3)
                            {
                                if (field.IsPublic)
                                    Console.Write("public ");
                                if(field.IsPrivate)
                                    Console.Write("private ");
                                if (field.IsPublic == false && field.IsPrivate == false)
                                    Console.Write("protected ");
                                Console.WriteLine($"{field.FieldType.Name} {field.Name}");
                            }
                                
                            break;
                    }
                }
            }
        }
    }
}
