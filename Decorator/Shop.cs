using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Decorator
{
    public class Shop
    {
        private IPayment payment;

        public Shop(IPayment payment)
        {
            this.payment = payment;
        }

        public void ProcessPayment()
        {
            payment.Pay();
        }
    }
}
