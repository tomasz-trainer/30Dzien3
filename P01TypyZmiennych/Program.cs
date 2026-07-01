using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            char b = 'b';
            string c = "hej"; // string jest wyjątkiem bo jest klasą ale zachowuje się jak struktura 
            double d = 5.6;
            bool e = false;
            
            int a2 = a; // przekazanie wartosci przez kopie 
            a = 7;
            // pytanie co jest w a2?  
            // a = 7 
            // a2 = 6

            WebClient wc = new WebClient();
            DateTime dt = new DateTime();
            DateTime dt2 = new DateTime(2026, 07, 01);

           
            StringBuilder sb = new StringBuilder();
            sb.Append("ala ");
            sb.Append("ma ");
            sb.Append("kota");
            string s = sb.ToString();

            StringBuilder sb2 = sb; // przekazywanie przez referencje 

            sb.Append(" i psa");
            // co siedzi w sb2 ? 
            // sb2 = ala ma kota i psa

            DateTime dt3 = dt2;
            dt2 = dt2.AddDays(1); // 2026-07-02
            // co znajduje sie w dt3 ? 
            // w dt3 2026-07-01

        }
    }
}
