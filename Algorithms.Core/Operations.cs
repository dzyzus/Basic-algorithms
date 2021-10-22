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
            Console.Write("Podaj ścieżkę do pliku: ");
            var inputPath = Console.ReadLine();

            return inputPath;
        }
        public static string GetPathOutput(string path)
        {
            var outputPath = path;

            return outputPath;
        }
    }
}
