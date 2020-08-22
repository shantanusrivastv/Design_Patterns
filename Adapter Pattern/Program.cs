using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayment aPayment;
            string paymentType = "CreditCard";
            //  this value would be populated elsewhere
            aPayment = PaymentFactory.getPayment(paymentType);
            aPayment.takePayment(10.5);

            paymentType = "PayPal";
            //  this value would be populated elsewhere
            aPayment = PaymentFactory.getPayment(paymentType);
            aPayment.takePayment(10.5);

            paymentType = "3rd Party";
            //  this value would be populated elsewhere
            aPayment = PaymentFactory.getPayment(paymentType);
            aPayment.takePayment(10.5);
        }
    }
}
