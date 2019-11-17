using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace _9
{
    class MyLinkedList:IEnumerable
    {
        int[] values;
        public MyLinkedList()
        {
            values = new int[0];
        }
        public IEnumerator GetEnumerator()
        {
            return values.GetEnumerator();
        }
        public int Count
        {
            get
            {
                return values.Length;
            }
        }
        public void Add(int item)
        {
            int k = values.Length;
            Array.Resize(ref values, k + 1);
            values[k] = item;
        }
        public bool Remove(int item)
        {
            bool removed = false;
            for (int i=0;i<values.Length;i++)
            {                
                if (values[i] == item)
                {
                    for (int j = i; j < values.Length - 1; j++)
                        values[j] = values[j + 1];
                    int k = values.Length;
                    Array.Resize(ref values, k - 1);
                    removed = true;       
                    break;
                }
            }
            return removed;
        }


    }
}
