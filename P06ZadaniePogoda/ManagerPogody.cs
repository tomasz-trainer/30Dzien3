using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class ManagerPogody
    {
        public double PodajTemperature(string miasto, string jednostka)
        {
            string url = $"https://wttr.in/{miasto}?format=%t";

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string odpowiedz = client.DownloadString(url);
                string liczba = odpowiedz.Replace("+", "").Replace("°C", "").Trim();
                double tempCelsjusz = Convert.ToDouble(liczba);
                return tempCelsjusz;
            }
        }
    }
}
