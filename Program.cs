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
      //  Klasa Budziki, posiada pola cena i nazwa. Metode DodajPromocje.
        class Budziki
        {
            public int cena { get; set; }
            public string nazwa { get; set; }
            public int ilosc { get; set; }

            public int DodajPromocje(int Ncena)
            {
                Ncena = int.Parse(Console.ReadLine());
                cena = Ncena;
                return Ncena;
            }

            public Budziki(int ncena, string nnazwa,int nilosc)
            {
                cena = ncena;
                nazwa = nnazwa;
                ilosc = nilosc;
            }

        }
        //class Promocje
        //{
        //    //cena
        //    //
        //}

        static void Main()
        {
           // public string haslo{get;private set;}
            #region Zmienne
            int menu=0;
            int phaslo;
            string menuadmin;
            string produktdodaj; //potrzebna do PA
            int cenaproduktu; //potrzebne do PA
            int iloscproduktow; //potrzebne do PA
            #endregion
            
         
            #region Acesory
             
          
            #endregion

            #region konstruktor
            Haslo admin = new Haslo();
            admin.haslo = 123456;
            
            #endregion

            #region ListaProduktow
            List<Budziki> budzki=new List<Budziki>();
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
                          Console.WriteLine(" d) Dodaj produkt ");
                          Console.WriteLine(" u) dodaj promocje ");
                          

                          menuadmin = Console.ReadLine();

                          switch (menuadmin)
                          {
                              case "d":
                                  Console.WriteLine("Jaki produkt chcesz dodać ( podaj nazwe ): ");
                                  produktdodaj = Console.ReadLine();
                                  Console.WriteLine("Podaj cene tego produktu: ");
                                  cenaproduktu=int.Parse(Console.ReadLine());
                                  Console.WriteLine("Podaj ilosc produktow: ");
                                  iloscproduktow = int.Parse(Console.ReadLine());

                                  budzki.Add(new Budziki(cenaproduktu,produktdodaj,iloscproduktow));
                                  //Console.WriteLine("Dodałeś " + budzki);
                                  Console.ReadKey();
                                  
                                  
                                  break;
                              case "u":
                                  Console.WriteLine(" Jaką chcesz dodać promocje: ");
                                  //
                                  //
                                  //
                                
                                  break;


                             

                          }


                          //Console.WriteLine(" 2)



                      }
                      else
                      {
                          Console.WriteLine("Nie jesteś adminem ");
                      }
                    break;
                case 2:
                    Console.WriteLine(" Witaj w sklepiej. Wybierze menu ");
                   // Console.WriteLine(" 
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


    

