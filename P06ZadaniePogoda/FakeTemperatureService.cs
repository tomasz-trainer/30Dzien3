using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class FakeTemperatureService
    {
        public double GetTemperature(string city)
        {
            if (city == "Warszawa")
                return 20.0;
            else if (city == "Kraków")
                return 18.5;
            else if (city == "Gdańsk")
                return 15.0;
            else
                throw new ArgumentException("Nieznane miasto");
        }
    }
}
