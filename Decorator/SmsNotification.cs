using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Decorator
{
    public class SMSNotification : IPayment
    {
        private readonly IPayment _payment;

        public SMSNotification(IPayment payment)
        {
            _payment = payment;
        }

        public void Pay()
        {
            _payment.Pay();

            SendSmsNotification();
        }

        private void SendSmsNotification()
        {
            Console.WriteLine("Wysłano powiadomienie SMS o dokonanej płatności.");
        }
    }
}
