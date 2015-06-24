using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class permutaions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to be permuted:");
            String input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
//            permut(inputArray);
            permutation("", input);
            Console.ReadLine();

        }

 /*       private static void permut(char[] inputArray)
        {
            if (inputArray.Length == 1)
            {
                Console.WriteLine(inputArray);
            }
            else if (inputArray.Length == 0)
            {
                Console.WriteLine("nuthin here");
            }
            else if (inputArray.Length > 1)
            {
                string str = inputArray.ToString();
                Console.WriteLine(str);
                permutation("", str); 
            }

            
        }
*/
        private static void permutation(string p, string str)
        {

            int leng = str.Length;
            if (leng == 0)
            {
                Console.WriteLine(p);
            }
            for (int i = 0; i < leng; i++)
            {
                permutation(p + str[i], str.Substring(0, i) + str.Substring(i + 1));
                
            } 
        }
    }
}
