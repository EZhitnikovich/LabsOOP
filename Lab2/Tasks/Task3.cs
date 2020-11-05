using Lab2.Services;

namespace Lab2.Tasks
{
    public static class Task3
    {
        public static void StartTask()
        {
            OutputService.ShowMessage("Input the distance in centimeters:");
            string msg = InputService.GetUserMsg();
            if(double.TryParse(msg, out double result))
            {
                OutputService.ShowMessage($"Centimeters = {result}\n" +
                                          $"Metres = {ConverterService.GetCalcResult(result, 100)}\n" +
                                          $"Kilometers = {ConverterService.GetCalcResult(result, 100*1000)}\n");
            }
            else
            {
                OutputService.ShowMessage("Something went wrong");
            }
        }
    }
}