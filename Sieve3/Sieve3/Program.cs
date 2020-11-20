using System;
using System.Collections.Generic;

namespace Sieve3
{
    class Program
    {//Title: Create and Search Queue
     //Author: Gwen Kalasky
     //Synopsis: This program creates a queue of random itegers and allows you to search through it for factors of a number
     //Date: 10/7/20
        static void Main(string[] args)
        {
            //CREATING QUEUE WITH RANDOM INTEGERS
            Random random = new Random(); //Object creates random number
            int[] array = new int[100]; //This sets the size of the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100); //this for loop is used to set the range for the value of the random numbers
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]); //this for loop prints out the array so we can check the contents 
            }
            //when I try to take this out to check if its even printing only primes for the second queue,
            //the program just prints "System.Collections.Generic.Queue`1[System.Int32[]]" and nothing else??

            Queue<int[]> numberQueue = new Queue<int[]> ();
            numberQueue.Enqueue(array); //adding the array into the Queue
            Queue<int[]> numberQueue2 = new Queue<int[]>(); //making the 2nd Queue


            //IDENTIFYING PRIMES IN QUEUE

            int n = 0;
            for (int i = 2; i < n; i++) 

                if (n %i==0)//no idea what the formula would be OOF
                {
                    numberQueue2.Enqueue(array);
                }

            Console.WriteLine(numberQueue2); //this prints the prime numbers stored in the second queue
        }
    }  //I dont get what this is printing out, because they're not prime? I tried to ask the MCC tutoring online
    //service and the guy legit asked me what a prime number is... so that didn't really help LOL
}
