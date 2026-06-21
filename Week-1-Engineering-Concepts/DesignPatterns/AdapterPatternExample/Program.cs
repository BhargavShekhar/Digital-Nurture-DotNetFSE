namespace AdapterPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paypal =
                new PayPalAdapter(new PayPalGateway());

            IPaymentProcessor stripe =
                new StripeAdapter(new StripeGateway());

            paypal.ProcessPayment(1000);
            stripe.ProcessPayment(2000);
        }
    }
}