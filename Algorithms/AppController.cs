using Algorithms.Core;
using Algorithms.Core.CaesarCipher;
using System;

namespace Algorithms
{
    public class AppController
    {
        public Operations Operations = new Operations();
        public void IntroduceUser()
        {
            Console.WriteLine("Aplikacja jest zbiorem algorytmów.\nUżytkownik za pomocą instrukcji sterujących może wywoływać kolejne algorytmy.");
        }
        public void Menu()
        {
            var userInput = default(string);
            var input = default(string);

            while(input != "exit")
            {
                Console.WriteLine("Wpisz:\nc - aby skorzystać z szyfru cezara\nexit - aby zakończyć działanie programu");
                Console.Write("Opcja:");

                userInput = Console.ReadLine();
                input = userInput.ToLower();
                switch (input)
                {
                    case "c":
                        Console.WriteLine("Wybrałeś szyfr cezara.");
                        while (input != "wstecz")
                        {
                            Console.Write("crypt - szyfrowanie\ndecrypt - rozszyfrowanie\nback - wróć do poprzedniego menu.\n");
                            Console.Write("Opcja: ");
                            userInput = Console.ReadLine();
                            input = userInput.ToLower();
                            if (input == "back")
                                break;
                            else if (input == "crypt")
                            {
                                var pathIn = Operations.GetPathInput();
                                if(pathIn == null)
                                    break;
                                var pathOut = Operations.GetPathOutput();
                                if (pathOut == null)
                                    break;
                                var numberOfShifts = CaesarOperations.GetNumberOfShifts();
                                CaesarOperations.Crypt(pathIn, pathOut, numberOfShifts);
                                Console.WriteLine("--------------------------------------------------------------------------");
                            }
                            else if (input == "decrypt")
                            {
                                var pathIn = Operations.GetCryptedPathInput();
                                if (pathIn == null)
                                    break;
                                var pathOut = Operations.GetCryptedPathOutput();
                                if (pathOut == null)
                                    break;
                                var numberOfShifts = CaesarOperations.GetNumberOfShifts();
                                CaesarOperations.Decrypt(pathIn, pathOut, numberOfShifts);
                                Console.WriteLine("--------------------------------------------------------------------------");
                            }
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Program zostanie zakończony...");
                        break;
                    default:
                        Console.WriteLine("Wpisany parametr nie odpowiada żadnej funkcjonalności. Spróbuj jeszcze raz");
                        break;
                }
            }
        }
    }
}
