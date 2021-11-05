using System;
using System.IO;
namespace Algorithms.Core.CaesarCipher
{
    public class CaesarOperations
    {
        public static int GetNumberOfShifts()
        {
            Console.Write("Podaj liczbę przesunięć: ");
            var number = Console.ReadLine();
            var numberOfShifts = Operations.TryParseUerInput(number);

            return numberOfShifts;

        }

        public static void Crypt(string inputPath, string outputPath, int numberOfShifts)
        {
            var plainText = File.ReadAllText(inputPath);

            if (!File.Exists(outputPath))
            {
                var cryptFile = File.Create(outputPath);
                cryptFile.Close();
            }
            var cryptedText = "";

            //problemo z textem 
            foreach(var letter in plainText)
            {
                cryptedText += MainLogic.CaesarCipher(numberOfShifts, letter).ToString();
            }

            File.AppendAllText(outputPath, cryptedText);
        }
        public static void Decrypt(string inputCryptedPath, string outputCryptedPath, int numberOfShifts)
        {
            var cryptedText = File.ReadAllText(inputCryptedPath);

            if (!File.Exists(outputCryptedPath))
            {
                var cryptFile = File.Create(outputCryptedPath);
                cryptFile.Close();
            }
            var decryptedText = "";

            //problemo z textem 
            foreach (var letter in cryptedText)
            {
                decryptedText += MainLogic.Decrypt(numberOfShifts, letter).ToString();
            }

            File.AppendAllText(outputCryptedPath, decryptedText);

        }
    }
}
