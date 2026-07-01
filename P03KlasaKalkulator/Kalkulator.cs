using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KlasaKalkulator
{
    internal class Kalkulator
    {
        // ciało klasy 

        public int Policz(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public string Policz2(int a, int b)
        {
            int c = a + b;
            return Convert.ToString(c);
        }

        public void Policz3(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }






    }
}
