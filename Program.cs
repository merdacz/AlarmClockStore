using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KoszykKonsola
{
    class Program
    {
        
        class Haslo
        {
            public int haslo { get;  set; }
            public int SprawdzHaslo(int nhaslo)
            {
               
                haslo = nhaslo;
               return haslo;
            }
        }
       

        static void Main()
        {
           // public string haslo{get;private set;}
            #region Zmienne
            int menu=0;
            int phaslo;
            #endregion
            
         
            #region Acesory
             
          
            #endregion
            #region konstruktor
            Haslo admin = new Haslo();
            admin.haslo = 123456;
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
                      phaslo = int.Parse(Console.ReadLine());
                      if (phaslo==admin.haslo)
                      {
                          Console.WriteLine("Witaj Administratorze. ");
                          //Console.WriteLine(" 1) Dodaj produkt ");
                          //Console.WriteLine(" 2)

                      }
                      else
                      {
                          Console.WriteLine("Nie jesteś adminem ");
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


    

