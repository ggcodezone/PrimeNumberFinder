using System;

namespace Eratosthenes_v2
{
    //Name: Prime Finder Ver. 2
    //Author: Gwen Kalasky
    //Date: 11/20/20
    //Synopsis: Finds the first 1000 prime numbers using Eratosthenes Sieve
    class SieveOfEratosthenesTask
    {
        static bool[] SieveOfEratosthenes(int n)
        {
            bool[] array = new bool[n];

            for (int i = 2; i < n; i++)
            {
                array[i] = true;
            }

            for (int j = 2; j * j <= n; j++)
            {
                if (array[j] == true)
                {
                    for (int k = j * j; k < n; k += j)
                    {
                        array[k] = false;
                    }
                }
            }
            return array;
        }

        class Program
        {
            static void Main(string[] args)
            { //driver code
                var arrayOfPrimes = SieveOfEratosthenes(1000);
                for (int i = 0; i < arrayOfPrimes.Length; i++)
                {
                    if (arrayOfPrimes[i] != false)
                    {
                        Console.Write($"{i} "); 
                    }
                }
            }
        }
    }
}
