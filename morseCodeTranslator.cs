using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DPSolns
{
    class morseCodeTranslator
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> codeTable = new Dictionary<char, string>();
            Dictionary<string, char> reversedCodeTable = new Dictionary<string, char>();
            codeTable.Add('A', ".-");
            codeTable.Add('N',"-.");
            codeTable.Add('B',"-...");
            codeTable.Add('O',"---");
            codeTable.Add('C',"-.-.");
            codeTable.Add('P',".--.");
            codeTable.Add('D',"-..");
            codeTable.Add('Q',"--.-");
            codeTable.Add('E',".");
            codeTable.Add('R',".-.");
            codeTable.Add('F',"..-.");
            codeTable.Add('S',"...");
            codeTable.Add('G',"--.");
            codeTable.Add('T',"-");
            codeTable.Add('H',"....");
            codeTable.Add('U',"..-");
            codeTable.Add('I',"..");
            codeTable.Add('V',"...-");
            codeTable.Add('J',".---");
            codeTable.Add('W',".--");
            codeTable.Add('K',"-.-");
            codeTable.Add('X',"-..-");
            codeTable.Add('L',".-..");
            codeTable.Add('Y',"-.--");
            codeTable.Add('M',"--");
            codeTable.Add('Z',"--..");
            reversedCodeTable = codeTable.ToDictionary(od => od.Value, od => od.Key);

            string input = ".... . .-.. .-.. --- / -.. .- .. .-.. -.-- / .--. .-. --- --. .-. .- -- -- . .-. / --. --- --- -.. / .-.. ..- -.-. -.- / --- -. / - .... . / -.-. .... .- .-.. .-.. . -. --. . ... / - --- -.. .- -.--";
            string[] words = input.Split('/');
            string[] tempwords = words;

            for (int i = 0; i < words.Length; i++ )
            {
                tempwords[i] = words[i].Trim();
            }
            foreach (string tempword in tempwords)
            {
                string[] supertempword = tempword.Split(' ');
                int leng = supertempword.Length;
                //Console.ReadLine();
                for (int j = 0; j < leng; j++)
                {
                    char value = reversedCodeTable[supertempword[j]];
                    Console.WriteLine(value);
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
