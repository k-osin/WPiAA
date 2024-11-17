using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Proxy
{
    public class PublicFile : IFile
    {
        public void Access()
        {
            Console.WriteLine("Dostęp do pliku publicznego został przyznany.");
        }
    }
}
