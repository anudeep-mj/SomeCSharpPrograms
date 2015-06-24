//Execution: Input: 1-800-COMCAST Output: 1-800-266-2278

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class WordPhoneToNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be deciphered");
            string input = Console.ReadLine();
            string inputWithDashRemoved = input.Replace("-", "");
            string neededString = inputWithDashRemoved.Substring(4, 10);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("ABC",2);
            dict.Add("DEF",3);
            dict.Add("GHI",4);
            dict.Add("JKL",5);
            dict.Add("MNO",6);
            dict.Add("PQRS",7);
            dict.Add("TUV",8);
            dict.Add("WXYZ",9);
            foreach (char c in neededString)
            {

            }
        }
    }
}
