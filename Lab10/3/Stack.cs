using System;
using System.Collections.Generic;
using System.Collections;

namespace _3
{
    class Stack<T>:IEnumerable<T>
    {
        List<T> List { get; set; }//Список как базовая структура
        public Stack()
        {
            List = new List<T>();
        }//Конструктор (создает новый пустой список)
        public IEnumerator<T> GetEnumerator()
        {
            for(int i= 0;i < List.Count; i++)
            {
                yield return List[i];
            }
        }//Перебор списка
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }//Вызвает перебор сверху
        public void Push(T item)
        {
            //if(List.Count==0)
            //    List.Add(item);
            //else
                List.Insert(0, item);
        }
        public void Pop()
        {
            if (List.Count > 0)
                List.RemoveAt(0);
            else
                Console.WriteLine("No elements");
        }
    }
}
