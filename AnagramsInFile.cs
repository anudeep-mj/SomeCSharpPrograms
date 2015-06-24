using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPSolns
{
    class AnagramsInFile
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordWithList = new Dictionary<string, List<string>>();
            Dictionary<char, int> charRefernces = new Dictionary<char, int>();
            charRefernces.Add('a', 2);
            charRefernces.Add('b', 3);
            charRefernces.Add('c', 5);
            charRefernces.Add('d', 7);
            charRefernces.Add('e', 11);
            charRefernces.Add('f', 13);
            charRefernces.Add('g', 17);
            charRefernces.Add('h', 19);
            charRefernces.Add('i', 23);
            charRefernces.Add('j', 29);
            charRefernces.Add('k', 31);
            charRefernces.Add('l', 37);
            charRefernces.Add('m', 41);
            charRefernces.Add('n', 43);
            charRefernces.Add('o', 47);
            charRefernces.Add('p', 53);
            charRefernces.Add('q', 59);
            charRefernces.Add('r', 61);
            charRefernces.Add('s', 67);
            charRefernces.Add('t', 71);
            charRefernces.Add('u', 73);
            charRefernces.Add('v', 79);
            charRefernces.Add('w', 83);
            charRefernces.Add('x', 89);
            charRefernces.Add('y', 97);
            charRefernces.Add('z', 101);
            string text = System.IO.File.ReadAllText(@"C:\Users\aj8106\Documents\testfileForAnagrams.txt");
            Console.WriteLine("Original file contents:");
            Console.WriteLine(text);
            string[] words = text.Split(' ');
//            Console.ReadLine();
            foreach (string word in words)
            {
                
            }

        }
    }
}
