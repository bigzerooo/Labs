using System;
using System.Reflection;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Type myType = typeof(BlackBoxInt);//тип - БлэкБоксИнт
                object a;//обьект для конструктора
                object[] constructorParams = { };//пустые параметры для конструктора
                ConstructorInfo[] constructors = myType.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);//заберает все неприватные конструкторы
                a = constructors[0].Invoke(constructorParams);//создание обьекта а (по сути блэкБоксИнт)

                while (true)
                {
                    try
                    {
                        string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                        if (tokens[0] == "END")
                            break;
                        else
                        {
                            MethodInfo method = myType.GetMethod(tokens[0], BindingFlags.Instance | BindingFlags.NonPublic);//заберает нужный метод
                            object[] methodParams = new object[1];//параметры нужного метода
                            methodParams[0] = int.Parse(tokens[1]);//заполняет параметр
                            method.Invoke(a, methodParams);//вызывает метод для обьекта а с данными параметрами

                            FieldInfo field = myType.GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);//возвращает нужное поле
                            Console.WriteLine(field.GetValue(a));//возвращает значение по полю для обьекта
                        }
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine(x.Message);
                    }
                }
            }
            catch(Exception x)
            {
                Console.Write(x.Message);
            }
            Console.ReadKey();


            }        
    }
}
