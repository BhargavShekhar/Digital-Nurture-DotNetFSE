using System;

namespace StrategyPatternExample
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        private string _cardHolderName;

        public CreditCardPayment(string cardNumber, string cardHolderName)
        {
            _cardNumber = cardNumber;
            _cardHolderName = cardHolderName;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Credit Card Payment Processing");
            Console.WriteLine($"   Card Holder: {_cardHolderName}");
            Console.WriteLine($"   Card Number: {_cardNumber.Substring(_cardNumber.Length - 4).PadLeft(_cardNumber.Length, '*')}");
            Console.WriteLine($"   Amount: {amount}");
            Console.WriteLine($"   Status: Payment Successful\n");
        }
    }
}
