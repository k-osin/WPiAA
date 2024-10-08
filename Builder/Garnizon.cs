using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPiAA.Factory;

namespace WPiAA.Builder
{
    public class Garnizon
    {
#pragma warning disable CS8618 // Pole niedopuszczające wartości null musi zawierać wartość inną niż null podczas kończenia działania konstruktora. Rozważ dodanie modyfikatora „required” lub zadeklarowanie go jako dopuszczającego wartość null.
        private WarriorBuilder builder;
#pragma warning restore CS8618 // Pole niedopuszczające wartości null musi zawierać wartość inną niż null podczas kończenia działania konstruktora. Rozważ dodanie modyfikatora „required” lub zadeklarowanie go jako dopuszczającego wartość null.

        public void SetBuilder(WarriorBuilder builder)
        {
            this.builder = builder;
        }

        public void Szkolenie()
        {
            builder.ZapiszDoArmii();
            builder.PobierzBron();
            builder.Trenuj();
        }

        public Wojownik GetWojownik()
        {
            return builder.GetWojownik();
        }
    }
}
