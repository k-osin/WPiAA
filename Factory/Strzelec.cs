using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Factory
{
    public class Strzelec : Wojownik
    {
        public override void Walcz()
        {
            Console.WriteLine("Strzelec walczy na dystans.");
        }
    }
}
