using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator("normalny");
            //k.Tryb = "normalny";

            string wynik = k.Policz(5, 3);
        }
    }
}
