using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Decorator
{
    public class LoyaltyPoints : IPayment
    {
        private readonly IPayment _payment;

        public LoyaltyPoints(IPayment payment)
        {
            _payment = payment;
        }

        public void Pay()
        {
            _payment.Pay();
            
            AddLoyaltyPoints();
        }

        private void AddLoyaltyPoints()
        {
            Console.WriteLine("Dodano punkty lojalnościowe.");
        }
    }
}
