using System;

namespace StrategyPatternExample
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"PayPal Payment Processing");
            Console.WriteLine($"   Email: {_email}");
            Console.WriteLine($"   Amount: {amount}");
            Console.WriteLine($"   Status: Payment Successful\n");
        }
    }
}
