using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class RemoveOneStringFromAnother
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the string to replace from:");
            string input2 = Console.ReadLine();
            string text = "";
            foreach (char c in input2)
            {
                text = input1.Replace(c.ToString(), "");
            }
            Console.WriteLine(text);
        }
    }
}
