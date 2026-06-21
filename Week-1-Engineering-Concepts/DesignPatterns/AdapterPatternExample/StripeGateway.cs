namespace AdapterPatternExample
{
    public class StripeGateway
    {
        public void ProcessStripePayment(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Stripe.");
        }
    }
}