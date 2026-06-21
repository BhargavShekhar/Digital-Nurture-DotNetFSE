namespace AdapterPatternExample
{
    public class PayPalGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using PayPal.");
        }
    }
}