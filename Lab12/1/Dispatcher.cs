using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    delegate void NameChangeEventHandler(NameChangeEventsArgs args);//делегат для события NameChange
    class Dispatcher//диспетчер
    {
        string _name;//поле
        public string Name//свойство
        {
            get
            {
                return _name;
            }
            set
            {                
                bool good = true;
                for(int i=0;i<value.Length;i++)//проверка на буквы/цифры
                { 
                    if(char.IsLetterOrDigit(value[i])==false)
                    {
                        good = false;
                        break;
                    }
                }
                if (good)//если подходит
                { 
                    _name = value;
                    OnNameChange(new NameChangeEventsArgs(value));//сетер вызывает метод OnNameChange                
                }
                else
                {
                    throw new Exception("Invalid name!");
                }
            }
        }
        
        public void OnNameChange(NameChangeEventsArgs args)//метод для вызова события NameChange
        {
            NameChange(args);
        }
        public event NameChangeEventHandler NameChange;//событие, переменная делегата

        //public Dispatcher(string name)//конструктор
        //{
        //    Name = name;
        //}
    }
}
