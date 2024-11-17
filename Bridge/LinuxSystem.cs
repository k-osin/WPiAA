using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Bridge
{
    public class LinuxSystem : OperatingSystem
    {
        public LinuxSystem(IInterface userInterface) : base(userInterface)
        {
        
        }

        public override void DisplayMenu()
        {
            List<string> installedPrograms = new List<string> { "Terminal", "GIMP", "VLC", "LibreOffice" };
            Console.WriteLine("Linux System:");
            UserInterface.ShowMenu(installedPrograms);
        }
    }
}
