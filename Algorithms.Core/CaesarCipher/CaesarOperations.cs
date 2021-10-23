﻿using System;
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
                File.AppendAllText(outputPath, (MainLogic.CaesarCipher(numberOfShifts, letter)).ToString());
            }

            File.AppendAllText(outputPath, cryptedText);
        }
    }
}
