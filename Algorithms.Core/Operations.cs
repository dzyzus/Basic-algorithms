using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.Core
{
    public class Operations
    {
        public static int TryParseUerInput(string userInput)
        {
            int number;

            bool succes = int.TryParse(userInput, out number);

            if (!succes)
            {
                Console.WriteLine("Podany string nie jest liczbą.");
            }

            return number;
        }

        public static string GetPathInput()
        {
            Console.Write("Podaj ścieżkę do pliku z tekstem jawnym: ");
            var inputPath = Console.ReadLine();

            if (File.Exists(inputPath))
                return inputPath;
            else
            {
                Console.WriteLine("Pod podanym url nie ma pliku z tekstem jawnym.");
                return null;
            }
        }
        public static string GetPathOutput()
        {
            Console.Write("Podaj ścieżkę gdzie ma zostać utworzony plik z tekstem zaszyfrowanym: ");
            var outputPath = Console.ReadLine();

            return outputPath;
        }
    }
}
