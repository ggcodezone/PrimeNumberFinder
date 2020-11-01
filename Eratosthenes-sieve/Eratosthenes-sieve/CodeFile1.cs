using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name:Prime Number Finder
//Author: Gwen Kalasky
//Date: 10/28/20
//Synopsis: Enter a value and the program will show you all the prime numbers leading up to said value.

namespace primefinder
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> NoPrime = new HashSet<int>();
            long count = 0;
            Console.WriteLine("please enter a max search value");
            bool input = int.TryParse(Console.ReadLine(), out int n);
            while (input == false)
            {
                Console.WriteLine($"{input} is not a valid value.\nPlease enter a valid number");
                input = int.TryParse(Console.ReadLine(), out n);

            }
            string name = $"Primes_to_{n}";
            string filename = String.Format("{0:yyyy-MM-dd-hh-mm}__{1}", DateTime.Now, name);
            for (int x = 2; x < n; x++)
            {
                for (int y = x * 2; y < n; y = y + x)
                {

                    if (!NoPrime.Contains(y))
                    {
                        NoPrime.Add(y);
                    }

                }

            }

            for (int z = 2; z < n; z++)
            {
                if (!NoPrime.Contains(z))
                {
                    Console.WriteLine(z);
                    using (System.IO.StreamWriter file =
            new System.IO.StreamWriter($@"{filename}.csv", true))
                    {
                        file.WriteLine(z);
                    }
                    count = count + z;
                }
            }


        }
    }
}