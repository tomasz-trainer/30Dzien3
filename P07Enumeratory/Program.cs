using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Enumeratory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody manager = new ManagerPogody();
            Console.WriteLine("Podaj miasto");
            string miasto = Console.ReadLine();

            List<JednostkaTemperatury> jednostki =
                Enum.GetValues(typeof(JednostkaTemperatury))
                .Cast<JednostkaTemperatury>()
                .ToList();

            Console.WriteLine("Podaj jednostkę, jedną z: " + string.Join(", ", jednostki));


            string jednostka = Console.ReadLine();
            bool czyPoprawna = Enum.TryParse(jednostka, out JednostkaTemperatury jednostkaEnum);

            if (czyPoprawna)
            {
                try
                {
                    double temperatura = manager.PodajTemperature(miasto, jednostkaEnum);
                    Console.WriteLine(temperatura);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nie udało się pobrać temperatury");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna jednostka");
            }
            Console.Read();
        }
    }
}
