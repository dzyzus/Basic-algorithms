using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.Core.CaesarCipher
{
    public class MainLogic
    {
        public static void CaesarCipher(int numberOfShifts)
        {
            string[] Alphabet = {"A", "Ą", "B", "C", "Ć" ,"D", "E", "Ę", "F", "G", "H", "I", "J", "K",
                "L", "Ł", "M", "N", "Ń", "O", "Ó", "P", "R", "S", "Ś",
            "T", "U", "W", "Y", "Z", "Ź", "Ż"};

            if(numberOfShifts <= -26 && numberOfShifts >= 26)
                Console.WriteLine("Niepoprawna wielkość przesunięcia");


            for(int i = 0; i < Alphabet.Length; i++)
            {

            }
        }
        public int CheckChar(char letter)
        {
            if (letter >= 'a' && letter <= 'z')
                return 0;
            if (letter >= 'A' && letter <= 'Z')
                return 1;
            return 2;
        }
    }
}
