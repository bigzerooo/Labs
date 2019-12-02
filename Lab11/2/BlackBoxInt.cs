using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class BlackBoxInt
    {
        private int value;
        private void Add(int a)
        {
            value += a;
        }
        private void Substract(int a)
        {
            value -= a;
        }
        private void Divide(int a)
        {
            value /= a;
        }
        private void Multiply(int a)
        {
            value *= a;
        }
        private void RightShift(int a)
        {
            value = value >> a;
        }
        private void LeftShift(int a)
        {
            value = value << a;
        }
        private BlackBoxInt()
        {
            value = 0;            
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
