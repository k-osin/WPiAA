using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Decorator
{
    public class RedirectToHome : IPayment
    {
        private readonly IPayment _payment;

        public RedirectToHome(IPayment payment)
        {
            _payment = payment;
        }

        public void Pay()
        {
            _payment.Pay();
            RedirectToHomeSite();
        }

        private void RedirectToHomeSite()
        {
            Console.WriteLine("Przekierowano na stronę główną.");
        }
    }
}
