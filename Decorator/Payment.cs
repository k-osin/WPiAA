using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Decorator
{
    public class Payment : IPayment
    {
        public virtual void Pay()
        {
            Console.WriteLine("Dokonano płatności.");
        }
    }
}
