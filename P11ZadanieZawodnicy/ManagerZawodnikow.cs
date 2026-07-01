using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieZawodnicy.txt
{
    internal class ManagerZawodnikow
    {
        public Zawodnik[] WczytajZawodnikow(string sciezka)
        {

            //string[] wiersze = File.ReadAllText(sciezka).Split(new string[1] {"\r\n"},StringSplitOptions.RemoveEmptyEntries);
            string[] wiersze =  File.ReadAllLines(sciezka);

            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length-1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki =  wiersze[i].Split(',');

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = int.Parse(komorki[0]);
                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = int.Parse(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = DateTime.Parse(komorki[5]);
                z.Wzrost = int.Parse(komorki[6]);
                z.Waga = int.Parse(komorki[7]);

                zawodnicy[i - 1] = z;

            }
            return zawodnicy;
        }

    }
}
