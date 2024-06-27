namespace Design_Patterns.Creational_Patterns.Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = PaymentFactory.create(PaymentMethod.PayTm);

            payment.Pay(1000);

        }
    }
}


