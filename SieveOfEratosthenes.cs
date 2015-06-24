using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numer to which you need the primes:");
            int maxPrimeNumber = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[maxPrimeNumber-2];
            int j = 2;
            for (int i = 0; i < maxPrimeNumber-2; i++)
            {
                numbers[i] = j;
                j++;
            }
        }
    }
}
