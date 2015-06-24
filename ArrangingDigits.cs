using System;
using System.Collections;
using System.Linq;
using System.Text;


// write a program that will allow the user to input digits, and arrange them in numerical order.
//for extra credit, have it also arrange strings in alphabetical order

namespace DPSolns
{
    class arrandingDigits
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Enter the number of digits to be arranged");
            int lenOfDigits = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lenOfDigits; i++)
            {
                int tempVar = Convert.ToInt32(Console.ReadLine());
                list.Add(tempVar);
            }
            list.Sort();
            
        }
    }
}
