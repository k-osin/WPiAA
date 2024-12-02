using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Decorator
{
    public class CardPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Dokonano płatności kartą.");
            base.Pay();
        }
    }
}
