using Lab2.Services;

namespace Lab2.Tasks
{
    public static class Task1
    {
        public static void StartTask()
        {
            OutputService.ShowMessage("Input weight in grams: ");
            string msg = InputService.GetUserMsg();
            if(double.TryParse(msg, out double result))
            {
                OutputService.ShowMessage($"Grams = {result}\n" +
                                          $"Kilograms = {ConverterService.GetCalcResult(result, 1000)}\n" +
                                          $"Centners = {ConverterService.GetCalcResult(result, 1000 * 100)}\n"+
                                          $"Tons = {ConverterService.GetCalcResult(result, 1000 * 1000)}\n");
            }
            else
            {
                OutputService.ShowMessage("Something went wrong");
            }
        }
    }
}