using System;
using System.Collections.Generic;

namespace ObserverPatternExample
{
    public class StockMarket : IStock
    {
        private List<IObserver> _observers;
        private string _stockName;
        private double _stockPrice;

        public StockMarket(string stockName, double initialPrice)
        {
            _stockName = stockName;
            _stockPrice = initialPrice;
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_stockName, _stockPrice);
            }
        }

        public void SetStockPrice(double newPrice)
        {
            _stockPrice = newPrice;
            Console.WriteLine("Stock price updated.\n");
            NotifyObservers();
        }

        public double GetStockPrice()
        {
            return _stockPrice;
        }

        public string GetStockName()
        {
            return _stockName;
        }
    }
}
