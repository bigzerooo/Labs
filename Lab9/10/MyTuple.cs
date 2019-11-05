﻿using System;

namespace _10
{
    class MyTuple<U,V>
    {
        public U item1 { get; set; }
        public V item2 { get; set; }
        public MyTuple(U item1,V item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }        
        public override string ToString()
        {
            return $"({item1} -> {item2})";
        }



    }
}
