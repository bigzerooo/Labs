using System;

namespace _8
{
    public static class Sorter
    {
        public static void Sort<T>(CustomList<T> list) where T:IComparable
        {
            for(int i=0;i<list.Count;i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                    if (list.Values[i].CompareTo(list.Values[j]) > 0)
                        list.Swap(i, j);
            }
        }
    }
}
