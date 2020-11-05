using Lab2.Services;
using System;
using static System.Math;

namespace Lab2.Tasks
{
    public static class Task5
    {
        public static void StartTask()
        {
            double candiesPrice = 12.1;
            double gelatinousPrice = 8.9;

            double candiesWeight = 1;
            double gelatinousWeight = 1;

            OutputService.ShowMessage($"Candies price : {candiesPrice * candiesWeight} rub / {candiesWeight}kg\n"+
                                      $"Gelatinous price : {gelatinousPrice * gelatinousWeight} rub / {gelatinousWeight}kg");

            OutputService.ShowMessage("Input candies weight: ");
            candiesWeight = Convert.ToDouble(InputService.GetUserMsg());

            OutputService.ShowMessage("Input gelatinous weight: ");
            gelatinousWeight = Convert.ToDouble(InputService.GetUserMsg());
            
            double A = candiesPrice * candiesWeight;
            double B = gelatinousPrice * gelatinousWeight;

            OutputService.ShowMessage($"Candies price : {candiesPrice * candiesWeight} rub / {candiesWeight}kg\n"+
                                      $"Gelatinous price : {gelatinousPrice * gelatinousWeight} rub / {gelatinousWeight}kg");

            ComparePrices(A, B);
        }

        private static void ComparePrices(double A, double B)
        {
            if(A > B)
            {
                OutputService.ShowMessage($"A > B: {Round(GetСomparisonCoef(A, B), 2)}");
            }
            else if(A < B)
            {
                OutputService.ShowMessage($"A < B: {Round(GetСomparisonCoef(A, B), 2)}");
            }
            else
            {
                OutputService.ShowMessage("A = B");
            }
        }

        private static double GetСomparisonCoef(double x, double y)
        {
            return x / y;
        }
    }
}