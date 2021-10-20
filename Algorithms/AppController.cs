using Algorithms.Core;
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
        public void Ceaser()
        {

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
                        Console.Write("Wybrałeś szyfr cezara.\nwstecz - aby wrócić do menu\n[int] - liczba, o którą zostanie wykonane przesunięcie.\nOpcja:");
                        userInput = Console.ReadLine();

                        while (input != "wstecz") 
                        {
                            input = userInput.ToLower();
                            if (input == "wstecz")
                                break;
                            else
                            {
                                var number = Operations.TryparseUerInput(input);
                                Console.WriteLine("Przesunięcie o: " + number);
                                break;
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
