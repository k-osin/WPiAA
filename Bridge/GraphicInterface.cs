using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Bridge
{
    public class GraphicInterface : IInterface
    {
        public void ShowMenu(List<string> programs)
        {
            Console.WriteLine("Menu interfejsu graficznego:");
            foreach (var program in programs)
            {
                Console.WriteLine($"- {program}");
            }
        }
    }
}
