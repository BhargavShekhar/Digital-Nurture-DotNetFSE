using System;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stock market subject
            StockMarket stockMarket = new StockMarket("ABC", 1000);

            // Create observers
            MobileApp mobileApp = new MobileApp();
            WebApp webApp = new WebApp();

            // Register observers
            stockMarket.RegisterObserver(mobileApp);
            stockMarket.RegisterObserver(webApp);

            // Change stock price
            Console.WriteLine("Changing ABC stock price to 1200:\n");
            stockMarket.SetStockPrice(1200);

            // Change stock price again
            Console.WriteLine("Changing ABC stock price to 1150:\n");
            stockMarket.SetStockPrice(1150);

            // Remove an observer
            Console.WriteLine("Removing Mobile App observer.\n");
            stockMarket.RemoveObserver(mobileApp);

            // Change stock price again
            Console.WriteLine("Changing ABC stock price to 1300:\n");
            stockMarket.SetStockPrice(1300);
        }
    }
}
