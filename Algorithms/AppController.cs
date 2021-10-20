using System;
namespace Algorithms
{
    public class AppController
    {
        public void IntroduceUser()
        {
            Console.WriteLine("Aplikacja jest zbiorem algorytmów.\nUżytkownik za pomocą instrukcji sterujących może wywoływać kolejne algorytmy.");
        }
        public void DoSomeAction()
        {
            Console.WriteLine("Dostępne opcje porgramu:\nc - szyfr Cezara\nexit - wyjście z programu");
        }
    }
}
