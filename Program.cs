using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello!");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your username:");
            string uname = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ", you are " + age + " years old and your username is " + uname);
            Console.ReadLine();
        }
    }
}
