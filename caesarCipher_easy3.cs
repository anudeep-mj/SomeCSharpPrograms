using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class caesarCipher_easy3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the shift");
            int shift = Convert.ToInt32(Console.ReadLine()); 
            int length = input.Length;
            if (length > 26 || length < 0)
            {
                Console.WriteLine("wrong input");
                Console.ReadLine();
            }
            input = input.Replace(" ", string.Empty);
            char[] chararray = input.ToCharArray();
            string opFromShift = caesar(chararray, shift);
            Console.WriteLine(opFromShift);
            Console.ReadLine();

        }

        private static string caesar(char[] chararray, int length)
        {
            char[] temp = chararray;
            for (int i = 0; i < temp.Length; i++)
            {
                char letter = temp[i];
                letter = (char)(letter + length);
                if (letter > 'z')
                    letter = (char)(letter - 26);
                if (letter < 'a')
                    letter = (char)(letter + 26);
                temp[i] = letter;
            }
            return new string(temp);
        }
    }
}
