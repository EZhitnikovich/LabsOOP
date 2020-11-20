using static System.Math;

namespace Lab2
{
    public static class FileSize
    {
        // Task 2
        
        public static void Run(double value)
        {
            OutputService.ShowMessage($"Bytes = {value}\n");
            OutputService.ShowMessage($"Kilobytes = {ValueConverter.GetCalcResult(value, (int)Pow(2, (int)CoefEnum.kilobytes))}\n");
            OutputService.ShowMessage($"Megabytes = {ValueConverter.GetCalcResult(value, (int)Pow(2, (int)CoefEnum.megabytes))}\n");
            OutputService.ShowMessage($"Gigabytes = {ValueConverter.GetCalcResult(value, (int)Pow(2, (int)CoefEnum.gigabytes))}\n");
        }
    }
}