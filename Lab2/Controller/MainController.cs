using static System.Math;

namespace Lab2
{
    public class MainController
    {
        public void CalculateDinosaurWeight()
        {

            OutputService.ShowMessage("Input weight in grams: ");
            double grams = double.Parse(InputService.GetUserMsg());

            DinosaurWeight dinosaurWeight = new DinosaurWeight(grams);

            OutputService.ShowMessage($"Grams = {dinosaurWeight.Grams}\n" +
                                      $"Kilograms = {dinosaurWeight.Kilograms}\n" +
                                      $"Centners = {dinosaurWeight.Centners}\n"+
                                      $"Tons = {dinosaurWeight.Tons}\n");
        }

        public void CalculateFileSize()
        {
            OutputService.ShowMessage("Input size in bytes:");
            double bytes = double.Parse(InputService.GetUserMsg());

            FileSize fileSize = new FileSize(bytes);

            OutputService.ShowMessage($"Bytes = {fileSize.Bytes}\n" +
                                      $"Kilobytes = {fileSize.Kilobytes}\n" +
                                      $"Megabytes = {fileSize.Megabytes}\n" +
                                      $"Gigabytes = {fileSize.Gigabytes}\n");
        }

        public void CalculateDistance()
        {
            OutputService.ShowMessage("Input the distance in centimeters:");
            double centimeters = double.Parse(InputService.GetUserMsg());

            Distance distance = new Distance(centimeters);

            OutputService.ShowMessage($"Centimeters = {distance.Centimeters}\n" +
                                      $"Metres = {distance.Metres}\n" +
                                      $"Kilometers = {distance.Kilometers}\n");
        }

        public void MakeSwap()
        {
            OutputService.ShowMessage("Input \"a\" value:");
            double a = double.Parse(InputService.GetUserMsg());

            OutputService.ShowMessage("Input \"b\" value:");
            double b = double.Parse(InputService.GetUserMsg());

            OutputService.ShowMessage($"a = {a}, b = {b}");
            MySwap.SwapNums(ref a, ref b);
            OutputService.ShowMessage($"a = {a}, b = {b}");
        }

        public void CompareCandyPrices()
        {
            OutputService.ShowMessage("Input candies weight: ");
            double candiesWeight = double.Parse(InputService.GetUserMsg());

            OutputService.ShowMessage("Input gelatinous weight: ");
            double gelatinousWeight = double.Parse(InputService.GetUserMsg());

            CandiesAndGelatinous candiesAndGelatinous = new CandiesAndGelatinous(12.4, 6d);

            OutputService.ShowMessage($"Candies price : {candiesAndGelatinous.CandiesPricePerKg * candiesWeight} rub / {candiesWeight}kg\n"+
                                      $"Gelatinous price : {candiesAndGelatinous.GelatinousPricePerKg * gelatinousWeight} rub / {gelatinousWeight}kg");

            OutputService.ShowMessage($"The price of candy differs from gelatine by {Round(candiesAndGelatinous.ComparePrices(candiesWeight, gelatinousWeight), 2)} times");
        }
    }
}