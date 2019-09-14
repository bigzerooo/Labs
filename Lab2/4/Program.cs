using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =Convert.ToInt32( Console.ReadLine());
            bool []primes = new bool[n+1];
            n++;
            for (int i = 0; i < n; i++)
                primes[i] = true;
            primes[0] = false;
            primes[1] = false;
            for(int p=2;p<n;p++)
            { 
            
             if(primes[p]==true)
                { 
            Console.Write($"{p} ");
            for (int i = 2; p*i < n; i++)
                primes[p * i]=false;
                }
            }
        }
    }
}
