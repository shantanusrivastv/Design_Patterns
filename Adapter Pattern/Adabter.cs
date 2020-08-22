using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Pattern
{

        //  The payment interface
        public interface IPayment
        {

            void takePayment(double Amount);
        }

        //  PayPal Payment class that implements the IPayment Interface
        public class PayPalPayment : IPayment
        {

            public void takePayment(double Amount)
            {
                //  Code to take payment via PayPal merchant
            }
        }

        //  Credit Card Payment class that implements the IPayment Interface
        public class CreditCardPayment : IPayment
        {

            public void takePayment(double Amount)
            {
                //  Code to take payment via a credit card
            }
        }

        //  Adapter Class to ensure third party code implements IPayment
        public class ThirdPartyPaymentAdapter : ThirdPartyPayment, IPayment
        {

            public void takePayment(double Amount)
            {
                //  This methods calls the actual thrid party code.
                //  If we couldn't inherit we could instantiate the object here or in the
                //  constructor method.
                base.makeTransasction(Amount, false);
            }
        }

        //  Third Party Payment Class
        public class ThirdPartyPayment
        {

            public void makeTransasction(double amount, bool refund)
            {
                //  Third party code...
            }
        }

        //  Factory Class to return Concrete Payment object
        public class PaymentFactory
        {

            public static IPayment getPayment(string PaymentType)
            {
                switch (PaymentType)
                {
                    case "CreditCard":
                        return new CreditCardPayment();                       
                    case "PayPal":
                        return new PayPalPayment();                        
                    default:
                        return new ThirdPartyPaymentAdapter();                        
                }
            }
        }
    }
