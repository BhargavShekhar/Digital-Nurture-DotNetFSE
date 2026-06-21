namespace FinancialForecasting
{
    public class FinancialForecast
    {
        /// <summary>
        /// Predicts the future value using recursive forecasting.
        /// 
        /// Formula: Future Value = Current Value × (1 + GrowthRate)
        /// This formula is applied recursively for the specified number of years.
        /// 
        /// Time Complexity: O(n) - where n is the number of years
        /// Space Complexity: O(n) - due to the call stack depth
        /// 
        /// Base Case: When years = 0, return the current value
        /// Recursive Case: Return currentValue × (1 + growthRate) for each year
        /// </summary>
        public double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            // Base case: no more years to calculate
            if (years == 0)
            {
                return currentValue;
            }

            // Recursive case: apply growth rate and recurse for remaining years
            return PredictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }
    }
}
