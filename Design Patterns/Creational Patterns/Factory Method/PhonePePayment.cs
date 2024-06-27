using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
    public class PhonePePayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} using PhonePe.");
        }
    }
}
