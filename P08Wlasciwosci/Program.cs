using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator(); 
            k.Kolor = "Czerwony";
            Console.WriteLine(k.Kolor);

            Czlowiek c = new Czlowiek();

            //wczesniej juz orzystalismy z wlasciwosci
            List<string> list = new List<string>();
            int liczbaelementow = list.Count;

            string s = "ala ma kota";
            int dlugosc = s.Length;

            Czlowiek czlowiek = new Czlowiek();
            czlowiek.Nazwisko = "Kowalski";
            czlowiek.Imie = "Jan";
            
            Console.WriteLine(czlowiek.Imie);

            Console.WriteLine(czlowiek.ImieNazwisko);

            czlowiek.ImieNazwisko = "Adam nowak";

            ManagerPogody mp = new ManagerPogody();
            mp.ZnakStopnia = "°C";

        }
    }
}
