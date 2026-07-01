using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieZawodnicy.txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerZawodnikow managerZawodnikow = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = managerZawodnikow
                .WczytajZawodnikow("C:\\Users\\csharp\\source\\repos\\Dzien3\\P11ZadanieZawodnicy\\zawodnicy.txt");


            foreach (var z in zawodnicy)
            {
                Console.WriteLine(z.Imie + " " + z.Nazwisko + " " + z.Kraj);
            }
        }
    }
}
