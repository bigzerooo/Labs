using System;
using System.Collections;
using System.Collections.Generic;
class ListyIterator<T> : IEnumerator<T>
{//технически этот класс являеться IEnumerator и IEnumerable одновременно
    List<T> List; //Список итератора
    int index; //индекс итератора
    public ListyIterator()//Создание листа в конструкторе
    {
        List = new List<T>();
        index = 0;
    }
    public ListyIterator(List<T> list)//Передача листа извне
    {
        List = list;
        index = 0;
    }
    public T Current // Поточный элемент (возвращает T)
    {
        get
        {
            if (List.Count == 0 || index >= List.Count)
                throw new InvalidOperationException("Invalid Operation!");
            else
                return List[index];
        }
    }
    object IEnumerator.Current// Поточный элемент (возвращает object)
    {
        get
        {
            return Current; 
        }
    }
    public void Print() //Вывод поточного элемента
    {
        Console.WriteLine(Current); 
    }
    public bool MoveNext()//Инкремент индекса
    {
        if (index < List.Count - 1)
        {
            index++;
            return true;
        }
        else
            return false;   
    }
    public bool Move()//По сути тот же MoveNext, но в заданиях другое название
    {
        return MoveNext();
    }
    public bool HasNext()//Есть ли следующий элемент?
    {
        if (index < List.Count - 1)
        {            
            return true;
        }
        else
            return false;
    }
    public void Reset()//Обнуление индекса
    {
        index = 0;
    }
    public void Dispose()//Деструктор неуправляемих обьектов (не реализован)
    {
        
    }
}