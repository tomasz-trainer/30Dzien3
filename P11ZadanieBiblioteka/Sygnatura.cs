using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    internal class Sygnatura
    {
        public int NrSygnatury { get; set; }
        public string Komentarz { get; set; }
        public bool Aktywna { get; set; }
        public DateTime DataZakupu { get; set; }
        public Cena Cena { get; set; }
        public List<Wypozyczenie> Wypozyczenia { get; set; }
    }
}
