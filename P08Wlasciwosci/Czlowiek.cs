using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class Czlowiek
    {
        public string Nazwisko { get; set; } // właściwość 

        private string imie; // pole prywatne

        private int wzrost; // pole prywatne wartosc domsylana = 0

        public string Imie
        {
            get
            {
                int a = wzrost;
                return imie.ToUpper();
            }
            set
            {
                imie = value;
            }
        }

        public string ImieNazwisko
        {
            get
            {
                string s1 = imie.ToLower();
                string s2 = Nazwisko.ToUpper();

                return s1 + " " + s2; 
            }
            set
            {
                string[] s= value.Split(' ');
                imie = s[0];
                Nazwisko = s[1];
            }
        }

        public void Idz(int ileKrokow)
        {
           
        }

        public string PrzedstawSie()
        {
            return imie + " " + Nazwisko;
        }
    }
}
