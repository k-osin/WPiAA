using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPiAA.Factory;

namespace WPiAA.Builder
{
    public class KonnyBuilder : WarriorBuilder
    {
        public override void ZapiszDoArmii()
        {
            wojownik = new Konny();
            Console.WriteLine("Konny zapisany do armii.");
        }

        public override void PobierzBron()
        {
            Console.WriteLine("Konny pobrał włócznię.");
        }

        public override void Trenuj()
        {
            Console.WriteLine("Konny trenuje walkę na koniu.");
        }
    }
}
