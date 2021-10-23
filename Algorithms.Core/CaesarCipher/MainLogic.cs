using System;

namespace Algorithms.Core.CaesarCipher
{
    public class MainLogic
    {
        public static char CaesarCipher(int numberOfShifts, char plainLetter)
        {
            char[] Alphabet = {'A', 'Ą', 'B', 'C', 'Ć' ,'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K',
                'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'R', 'S', 'Ś',
            'T', 'U', 'W', 'Y', 'Z', 'Ź', 'Ż'};

            if (numberOfShifts <= -26 && numberOfShifts >= 26)
            {
                Console.WriteLine("Niepoprawna wielkość przesunięcia");
            }

            char letter = default(char);

            for (int i = 0; i < Alphabet.Length; i++)
            {
                if(plainLetter == Alphabet[i])
                {
                    letter += Alphabet[i + numberOfShifts];
                }
            }
            return letter;
        }
    }
}
