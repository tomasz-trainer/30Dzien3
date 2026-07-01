using P05ZadanieManagerTekstu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            ManagerTekstu mt = new ManagerTekstu();

            try
            {
                string pierwszyNajdluzszy = mt.ZnajdzNajdluzszyWyraz(zdanie);
                Console.WriteLine($"Pierwszy najdluzszy wyraz: {pierwszyNajdluzszy}");

                string[] wyrazy = mt.ZnajdzWszystkieNajdluzszeWyrazy(zdanie);
                Console.WriteLine($"Wszystkie najdłuższe wyrazy: {string.Join(",", wyrazy)}");

            }
            catch (ZbytKroktkieZdanieException)
            {
                Console.WriteLine("Zbyt krótkie zdanie");
            }
            catch (ArgumentException ex)
            {
                // zamiast wyswietlac uzytkownikowi powinniśmy logować błąd do pliku logów,
                // ale na potrzeby tego zadania wyświetlamy komunikat
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bład przetwarzania tekstu");
            }
            Console.ReadKey();

        }

    }
}
