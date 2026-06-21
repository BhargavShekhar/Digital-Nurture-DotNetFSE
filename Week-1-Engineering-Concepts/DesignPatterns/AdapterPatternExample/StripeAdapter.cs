namespace AdapterPatternExample;

public class StripeAdapter : IPaymentProcessor
{
    private readonly StripeGateway _gateway;

    public StripeAdapter(StripeGateway gateway)
    {
        _gateway = gateway;
    }

    public void ProcessPayment(decimal amount)
    {
        _gateway.ProcessStripePayment(amount);
    }
}