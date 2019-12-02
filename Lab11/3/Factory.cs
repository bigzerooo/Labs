using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
namespace _3
{
    class Factory
    {
        public object Produce(string type)
        {            
            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_units").ToArray();//возвращает всех юнитов армии
            //foreach (var t in types)
            //    Console.WriteLine(t.Name);
            Type myType = types.First(x => x.Name == type);//возвращает тип данных для аргумента type
            ConstructorInfo[] constructors = myType.GetConstructors(BindingFlags.Public | BindingFlags.Instance);//ищет конструктора этого типа
            object a;
            object[] constructorParams = { };
            a=constructors[0].Invoke(constructorParams);//создает экземпляр типа
            return a;//вовзращает его
        }
    }
}
