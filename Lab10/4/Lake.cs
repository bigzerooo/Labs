using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _4
{
    class Lake:IEnumerable<int>
    {
        List<int> Stones { get; set; }//Базовая структура - список
        public Lake()
        {
            Stones = new List<int>();
        }//конструктор (создает пустой список, в принципе не нужен)
        public Lake(List<int> stones)
        {
            Stones = stones;
        }//констурктор(берет список из программы)
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Count; i+=2)
                yield return Stones[i];            
            if (Stones.Count % 2 == 0)                
            for (int j = Stones.Count - 1; j > 0; j -= 2)
                yield return Stones[j];
            else                
            for (int j = Stones.Count - 2; j > 0; j -= 2)
                yield return Stones[j];
        }//перебор
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }//ссылается на перебор сверху
    }
}
