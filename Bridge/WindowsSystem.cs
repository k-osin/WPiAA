using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Bridge
{
    public class WindowsSystem : OperatingSystem
    {
        public WindowsSystem(IInterface userInterface) : base(userInterface)
        {
        
        }

        public override void DisplayMenu()
        {
            List<string> installedPrograms = new List<string> { "Notepad", "Paint", "Edge", "Microsoft Office" };
            Console.WriteLine("Windows System:");
            UserInterface.ShowMenu(installedPrograms);
        }
    }

}
