using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Konstruktory
{
    internal class Kalkulator
    {
        private string _tryb; // dobra konwencja to dodawanie podkreślenia  przy polach prywatnch 

        private string kolor;

        public string Tryb
        {
            get { return _tryb; }
            set { _tryb = value; }
        }

        public string Policz(double a, double b)
        {
            if(_tryb == "naukowy")
            {
                return string.Format("{0:0.0000}", a / b);
            }
            if (_tryb == "normalny")
            {
                return string.Format("{0:0.00}", a / b);
            }

            throw new Exception("Nieznany tryb");

        }

        public Kalkulator(string tryb)
        {
            _tryb = tryb;
        }
        public Kalkulator(string tryb, string kolor)
        {
            _tryb = tryb;
            this.kolor = kolor;
        }

    }
}
