using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class randomPasswordGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YAY DO U WANT A NEW RANDOM PASSWORD ??? :D, Enter Yes or No");
            String answer = Console.ReadLine();
            if(string.Equals(answer, "yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the length of the password");
                int lengthOfPassword = Convert.ToInt32(Console.ReadLine());
                var totalChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random();
                var result = new string(Enumerable.Repeat(totalChars, lengthOfPassword).Select(s => s[random.Next(s.Length)]).ToArray());
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else{
                Console.WriteLine("boo u");
                Console.ReadLine();
            }
        }
    }
}
