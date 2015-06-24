using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class Primality
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int x = isPrime(input);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        private static int isPrime(int input)
        {
            if (input <= 3)
                return 1;
            else if (input % 2 == 0 || input % 3 == 0)
            {
                return 0;
            }
            else
            {
                double sqrt = Math.Sqrt(input);
                for (int i = 5; i <= sqrt; i += 6)
                {
                    if (input % i == 0 || input % (i + 2) == 0)
                        return 0;
                }
            }
            return 1;
        }
    }
}
