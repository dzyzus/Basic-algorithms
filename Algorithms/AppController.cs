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
                            Console.Write("wstecz - aby wrócić do menu\nurl_input - ścieżkę do tekstu jawnego\nurl_output - ścieżkę gdzie ma zostać zapisany zaszyfrowany tekst\n" +
                                "[int] - liczba, o którą zostanie wykonane przesunięcie.\nszyfruj - rozpocznij szyfrowanie(jeśli masz podane wszystkie zmienne)\nOpcja:");
                            userInput = Console.ReadLine();
                            input = userInput.ToLower();
                            if (input == "wstecz")
                                break;
                            else if (input == "url_input")
                            {
                                var pathIn = Operations.GetPathInput(input);

                            }
                            else if (input == "url_output")
                            {
                                var pathOut = Operations.GetPathOutput(input);
                            }
                            else if(input == "szyfruj")
                            {
                                //
                            }
                            else
                            {
                                var number = Operations.TryparseUerInput(input);
                                Console.WriteLine("Przesunięcie o: " + number);
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
