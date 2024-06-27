using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
    public class PaymentFactory
    {
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();

                case PaymentMethod.PayTm:
                    return new PayTmPayment();

                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();

                case PaymentMethod.PhonePe:
                    return new PhonePePayment();

                default:
                    throw new NotSupportedException($"{paymentMethod} is not supported yet");
            }
        }
    }
}
