using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPiAA.Factory;

namespace WPiAA.Builder
{
    public class StrzelecBuilder : WarriorBuilder
    {
        public override void ZapiszDoArmii()
        {
            wojownik = new Strzelec();
            Console.WriteLine("Strzelec zapisany do armii.");
        }

        public override void PobierzBron()
        {
            Console.WriteLine("Strzelec pobrał łuk.");
        }

        public override void Trenuj()
        {
            Console.WriteLine("Strzelec trenuje strzelanie na dystans.");
        }
    }
}
