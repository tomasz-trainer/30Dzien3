using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody managerPogody = new ManagerPogody();
            try
            {
                double temperatra = managerPogody.PodajTemperature("Warszawa", "......");
                Console.WriteLine(temperatra);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("(Nieznany bład) Nie udało się pobrać temperatury");
            }
            Console.ReadKey();

        }
    }
}
