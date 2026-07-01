using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Karta k = new Karta()
            {
                NrKarty = "1308/00",
                Wydanie = 1,
                Tytul = "O kurdlach dla opornych",
                Autorzy = new List<Autor>()
                {
                    new Autor() { Imie = "L", DrugieImie = "A", Nazwisko = "Tarantoga" },
                    new Autor() { Imie = "I", Nazwisko = "Tichy" }
                },
                Sygnatury = new List<Sygnatura>()
                {
                    new Sygnatura()
                    {
                        Aktywna = false,
                        Komentarz = " (zgłoszona utrata 01.05.2000)",
                        NrSygnatury = 012371,
                        Cena = new Cena()
                        {
                            WlasciwaCena = 17.5,
                            Komentarz = "zakup z 18.08 – 20,00"
                        },
                        DataZakupu = new DateTime(2000, 1, 27),
                        Wypozyczenia = new List<Wypozyczenie>()
                        {
                            new Wypozyczenie()
                            {
                                DataWypozyczenia = new DateTime(2000, 2, 22),
                                PrzewidywanaDataZwrotu = new DateTime(2000, 3, 7),
                                Uwagi = "06.03.2000 Zgoda na przedłużenie",
                                Przedluzenie = new Wypozyczenie()
                                {
                                    DataWypozyczenia = new DateTime(2000, 3, 7),
                                    PrzewidywanaDataZwrotu = new DateTime(2000, 3, 21),
                                    Uwagi = "21.03.2000 Zgoda na przedłużenie",
                                    Przedluzenie = new Wypozyczenie()
                                    {
                                        DataWypozyczenia = new DateTime(2000, 3, 21),
                                        PrzewidywanaDataZwrotu = new DateTime(2000, 4, 4),
                                        Uwagi = "04.04.2000 Zgoda na przedłużenie",
                                        Przedluzenie = new Wypozyczenie()
                                        {
                                            DataWypozyczenia = new DateTime(2000, 4, 4),
                                            PrzewidywanaDataZwrotu = new DateTime(2000, 4, 18),
                                            Uwagi = "18.04.2000 Zgoda na przedłużenie",
                                            Przedluzenie = new Wypozyczenie()
                                            {
                                                PrzewidywanaDataZwrotu = new DateTime(2000, 3, 15),
                                                RzeczywistaDataZwrotu = new DateTime(2000, 3, 15)
                                            }
                                        }
                                    }
                                }
                            }
                        },

                    }


                }
            };

            Console.WriteLine(k.Sygnatury[0].Wypozyczenia[0].Czytelnik.Nazwisko);
        }
    }
}
