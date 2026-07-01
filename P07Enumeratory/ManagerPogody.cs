using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07Enumeratory
{
    enum JednostkaTemperatury
    {
        Celsjusz,
        Kelvin,
        Farenheit
    }

    internal class ManagerPogody
    {
        public double PodajTemperature(string miasto, JednostkaTemperatury jednostka)
        {
            string url = $"https://wttr.in/{miasto}?format=%t";

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string odpowiedz = client.DownloadString(url);
                string liczba = odpowiedz.Replace("+", "").Replace("°C", "").Trim();
                double tempCelsjusz = Convert.ToDouble(liczba);
                
                return transformujTemperature(jednostka, Convert.ToDouble(tempCelsjusz));
            }
        }

        private double transformujTemperature(JednostkaTemperatury jednostka, double temp)
        {
            if (jednostka == JednostkaTemperatury.Celsjusz)
                return temp;
            else if (jednostka == JednostkaTemperatury.Farenheit)
                return (temp * 1.8) + 32;
            else if (jednostka == JednostkaTemperatury.Kelvin)
                return temp + 273.15;
            else
                throw new ArgumentException("Nieznana jednostka temperatury");


        }
    }
}
