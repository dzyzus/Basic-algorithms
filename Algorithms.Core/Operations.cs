using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Core
{
    public class Operations
    {
        public static int TryparseUerInput(string userInput)
        {
            int number;

            bool succes = int.TryParse(userInput, out number);

            if(!succes)
                Console.WriteLine("Podany string nie jest liczbą.");

            return number;
        }

        public static string GetPathInput(string path)
        {
            Console.Write("Podaj ścieżkę do pliku z tekstem jawnym: ");
            var inputPath = Console.ReadLine();

            return inputPath;
        }
        public static string GetPathOutput(string path)
        {
            Console.Write("Podaj ścieżkę gdzie ma zostać utworzony plik z tekstem zaszyfrowanym: ");
            var outputPath = Console.ReadLine();

            return outputPath;
        }
    }
}
