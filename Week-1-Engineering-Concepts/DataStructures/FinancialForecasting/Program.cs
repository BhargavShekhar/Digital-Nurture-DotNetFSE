using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize financial forecast
            FinancialForecast forecast = new FinancialForecast();

            // Initial parameters
            double currentValue = 100000;
            double growthRate = 0.10; // 10% annual growth rate
            int yearsShort = 5;
            int yearsLong = 10;

            // Display initial values
            Console.WriteLine("Current Value: ₹{0:N2}", currentValue);
            Console.WriteLine("Growth Rate: {0:P0}", growthRate);
            Console.WriteLine();

            // Calculate and display forecast for 5 years
            double futureValueAfter5Years = forecast.PredictFutureValue(currentValue, growthRate, yearsShort);
            Console.WriteLine("Future Value after 5 years: ₹{0:N2}", futureValueAfter5Years);

            // Calculate and display forecast for 10 years
            double futureValueAfter10Years = forecast.PredictFutureValue(currentValue, growthRate, yearsLong);
            Console.WriteLine("Future Value after 10 years: ₹{0:N2}", futureValueAfter10Years);

            Console.WriteLine();

            // Display time and space complexity
            Console.WriteLine("Time Complexity: O(n)");
            Console.WriteLine("Space Complexity: O(n)");

            Console.WriteLine();

            // Additional demonstration with different growth rates
            Console.WriteLine("Additional Examples:");
            double[] growthRates = { 0.05, 0.15, 0.20 };
            int[] years = { 3, 7 };

            foreach (double rate in growthRates)
            {
                Console.WriteLine($"\nGrowth Rate: {rate:P0}");
                foreach (int y in years)
                {
                    double result = forecast.PredictFutureValue(currentValue, rate, y);
                    Console.WriteLine($"  After {y} years: ₹{result:N2}");
                }
            }
        }
    }
}
