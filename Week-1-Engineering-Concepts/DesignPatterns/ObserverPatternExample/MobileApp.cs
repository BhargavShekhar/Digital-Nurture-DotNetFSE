using System;

namespace ObserverPatternExample
{
    public class MobileApp : IObserver
    {
        public void Update(string stockName, double price)
        {
            Console.WriteLine("Mobile App:");
            Console.WriteLine($"{stockName} Stock price is ₹{price}\n");
        }
    }
}
