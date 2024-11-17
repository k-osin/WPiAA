using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Bridge
{
    public class TextInterface : IInterface
    {
        public void ShowMenu(List<string> programs)
        {
            Console.WriteLine("Menu interfejsu tekstowego:");
            foreach (var program in programs)
            {
                Console.WriteLine($"[TEXT] {program}");
            }
        }
    }
}
