using System;

namespace _11
{
    class MyTuple<U,V,R>:MyTuple<U,V>
    {        
        public R item3 { get; set; }
        public MyTuple(U item1,V item2,R item3):base(item1,item2)
        {
            this.item3 = item3;
        }        
        public override string ToString()
        {
            return $"({item1} -> {item2} -> {item3})";
        }
    }
    class MyTuple<U, V>
    {
        public U item1 { get; set; }
        public V item2 { get; set; }
        public MyTuple(U item1, V item2)
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
