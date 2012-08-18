using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KoszykKonsola
{
    class Program
    {
        public string haslo { get; private set; }
        public string SprawdzHaslo(string Haslo)
        {
            Haslo="123456";
            haslo = Haslo;
            return haslo;
        }

        static void Main(string[] args)
        {
            #region Zmienne
            int menu=0;
            string phaslo;
            #endregion
           
            #region Acesory
            
            #endregion

            Console.WriteLine("Wybierz pozycje z menu: ");
            Console.WriteLine(" 1 ) Panel administracyjny ");
            Console.WriteLine(" 2 ) Sklep ");
            Console.WriteLine(" 3 ) Aktualne promocje ");
            Console.WriteLine(" 4 ) Wyjście ");

       
            menu = int.Parse(Console.ReadLine());
          
            switch (menu)
            {
                case 1:
                      Console.WriteLine("Witaj sprawdzimy czy jesteś administratorem. Podaj hasło: ");
                      phaslo = Console.ReadLine();
                      if (true)
                      {
                          //Console.WriteLine("Witaj Administratorze. ");
                          //Console.WriteLine(" 1) Dodaj produkt ");
                          //Console.WriteLine(" 2)

                      }
                    break;
                case 2:

                    break;
                case 3:
                    
                    break;
                case 4:
                    Console.WriteLine(" Koniec ");
                   // Console.Exit;
                    break;
                default:
                    Console.WriteLine(" Nie ma takiej pozycji  w menu ");
                    break;
            }
        }
    }
}


    

