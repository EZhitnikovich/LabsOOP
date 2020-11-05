using Lab2.Services;

using static System.Math;

namespace Lab2.Tasks
{
    public static class Task2
    {
        public static void StartTask()
        {
            OutputService.ShowMessage("Input size in bytes:");
            string msg = InputService.GetUserMsg();
            if(double.TryParse(msg, out double result))
            {
                OutputService.ShowMessage($"Bytes = {result}\n" +
                                          $"Kilobytes = {ConverterService.GetCalcResult(result, (int)Pow(2, 10))}\n" +
                                          $"Megabytes = {ConverterService.GetCalcResult(result, (int)Pow(2, 20))}\n" +
                                          $"Gigabytes = {ConverterService.GetCalcResult(result, (int)Pow(2, 30))}\n");
            }
            else
            {
                OutputService.ShowMessage("Something went wrong");
            }
        }
    }
}