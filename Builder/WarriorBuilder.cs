using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPiAA.Factory;

namespace WPiAA.Builder
{
    public abstract class WarriorBuilder
    {
        protected Wojownik? wojownik;

        public abstract void ZapiszDoArmii();
        public abstract void PobierzBron();
        public abstract void Trenuj();

        public Wojownik GetWojownik()
        {
#pragma warning disable CS8603 // Możliwe zwrócenie odwołania o wartości null.
            return wojownik;
#pragma warning restore CS8603 // Możliwe zwrócenie odwołania o wartości null.
        }
    }
}
