using System;

namespace ObserverPatternExample
{
    public class WebApp : IObserver
    {
        public void Update(string stockName, double price)
        {
            Console.WriteLine("Web App:");
            Console.WriteLine($"{stockName} Stock price is ₹{price}\n");
        }
    }
}
