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
            string url = $"https://wttr.in/{"warszawa"}?format=%t";

            using (WebClient client = new WebClient())
            {
                string odpowiedz = client.DownloadString(url);
                // odpowiedź wygląda np. tak: "+18°C"
                string liczba = odpowiedz.Replace("+", "").Replace("-", "-")
                                         .Replace("°C", "").Trim();
                double tempCelsjusz = double.Parse(liczba);

                
            }
        }
    }
}
