using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPiAA.Factory;

namespace WPiAA.Builder
{
    public class PiechurBuilder : WarriorBuilder
    {
        public override void ZapiszDoArmii()
        {
            wojownik = new Piechur();
            Console.WriteLine("Piechur zapisany do armii.");
        }

        public override void PobierzBron()
        {
            Console.WriteLine("Piechur pobrał miecz.");
        }

        public override void Trenuj()
        {
            Console.WriteLine("Piechur trenuje walkę wręcz.");
        }
    }
}
