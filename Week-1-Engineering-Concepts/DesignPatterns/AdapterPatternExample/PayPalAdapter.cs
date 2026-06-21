namespace AdapterPatternExample
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private PayPalGateway payPalGateway;

        public PayPalAdapter(PayPalGateway payPalGateway)
        {
            this.payPalGateway = payPalGateway;
        }

        public void ProcessPayment(decimal amount)
        {
            payPalGateway.MakePayment(amount);
        }
    }
}