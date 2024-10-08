using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Factory
{
    public class Garnizon
    {
        public Wojownik SzkolWojownika(string profesja)
        {
            switch (profesja.ToLower())
            {
                case "piechur":
                    return new Piechur();
                case "strzelec":
                    return new Strzelec();
                case "konny":
                    return new Konny();
                default:
                    throw new ArgumentException("Nieznana profesja: " + profesja);
            }
        }
    }
}
