using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Bridge
{
    public abstract class OperatingSystem
    {
        protected IInterface UserInterface;

        public OperatingSystem(IInterface userInterface)
        {
            UserInterface = userInterface;
        }

        public abstract void DisplayMenu();
    }
}
