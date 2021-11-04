using System;

namespace Algorithms.Core.CaesarCipher
{
    public class MainLogic
    {
        public static char CaesarCipher(int numberOfShifts, char plainLetter)
        {
            char[] LowerAlphabet = {'a', 'ą', 'b', 'c', 'ć' ,'d', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k',
                'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r', 's', 'ś',
            't', 'u', 'w', 'y', 'z', 'ź', 'ż', 'a', 'ą', 'b', 'c', 'ć' ,'d', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k',
                'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r', 's', 'ś',
            't', 'u', 'w', 'y', 'z', 'ź', 'ż'};

            char[] Alphabet = {'A', 'Ą', 'B', 'C', 'Ć' ,'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K',
                'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'R', 'S', 'Ś',
            'T', 'U', 'W', 'Y', 'Z', 'Ź', 'Ż', 'A', 'Ą', 'B', 'C', 'Ć' ,'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K',
                'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'R', 'S', 'Ś',
            'T', 'U', 'W', 'Y', 'Z', 'Ź', 'Ż'};


            if (numberOfShifts <= -31 && numberOfShifts >= 31)
            {
                Console.WriteLine("Niepoprawna wielkość przesunięcia");
            }

            char letter = default;

            for (int i = 0; i < Alphabet.Length; i++)
            {
                if (plainLetter == LowerAlphabet[i])
                {
                    letter += LowerAlphabet[i + numberOfShifts];
                }
                else if (plainLetter == Alphabet[i])
                {
                    letter += Alphabet[i + numberOfShifts];
                }
            }
            return letter;
        }
    }
}
