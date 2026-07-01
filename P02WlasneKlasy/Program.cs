using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            Kalkulator k2; // Deklarujemy zmienna o nazwie 'k2'
                           //, która jest typu Kalkulator
                           // Nie moge pracowac na k2 bo to tylko uchwyt a nie obiekt
                           // To zmienna , która jest gotowa na to aby do niej 
                           // pzrypisać nowy obiekt typu Kalkulator
            
            k2 = new Kalkulator(); // tworzymy nową instancję klasy Kalkulator 
                                   // (nowy obiekt) i przypisujemy ten obiekt do zmiennej k2 

            new Kalkulator(); // tworzymy nowy obiekt w pamieci 
                              // ale nie mamy do niego uchwytu 

            Kalkulator k3 = k2;  // tworzymy nowa zmienna k3, ktora wskazuje na 
                                  // juz istniejacy obiekt (ten sam na ktorego wskazuje k2)

             
        }
    }
}
