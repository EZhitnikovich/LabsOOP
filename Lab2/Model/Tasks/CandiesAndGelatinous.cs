using static System.Math;

namespace Lab2
{
    public class CandiesAndGelatinous
    {
        // Task 5

        private const double candiesPricePerKg = 15.2;
        private const double gelatinousPricePerKg = 8.7;

        public static void Run(double candiesWeght, double gelatinousWeight)
        {
            OutputService.ShowMessage($"Candies price / 1kg {candiesPricePerKg}\n");
            OutputService.ShowMessage($"Gelatinous price / 1kg {gelatinousPricePerKg}\n");

            double candiesPrice = candiesPricePerKg * candiesWeght;
            double gelatinousPrice = gelatinousPricePerKg * gelatinousWeight;

            OutputService.ShowMessage($"{Round(candiesPrice/gelatinousPrice, 2)}");
        }
    }
}