using System;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a payment context with Credit Card strategy
            IPaymentStrategy creditCardStrategy = new CreditCardPayment("1234567890123456", "John Doe");
            PaymentContext paymentContext = new PaymentContext(creditCardStrategy);

            // Scenario 1: Pay ₹1000 using Credit Card
            Console.WriteLine("Scenario 1: Paying ₹1000 using Credit Card");
            paymentContext.ExecutePayment(1000);

            // Scenario 2: Change strategy to PayPal and pay ₹2000
            Console.WriteLine("Scenario 2: Changing Strategy to PayPal and paying ₹2000");
            IPaymentStrategy paypalStrategy = new PayPalPayment("john.doe@example.com");
            paymentContext.SetPaymentStrategy(paypalStrategy);
            paymentContext.ExecutePayment(2000);

            // Scenario 3: Change back to Credit Card
            Console.WriteLine("Scenario 3: Changing back to Credit Card and paying ₹1500");
            IPaymentStrategy anotherCreditCardStrategy = new CreditCardPayment("9876543210987654", "Jane Smith");
            paymentContext.SetPaymentStrategy(anotherCreditCardStrategy);
            paymentContext.ExecutePayment(1500);
        }
    }
}
