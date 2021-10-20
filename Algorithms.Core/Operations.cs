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
    }
}
