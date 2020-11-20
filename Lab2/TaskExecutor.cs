
namespace Lab2
{
    public static class TaskExecutor
    {
        
        public static void Task1()
        {
            OutputService.ShowMessage("Input weight in grams: ");
            string msg = InputService.GetUserMsg();
            if(double.TryParse(msg, out double result))
            {
                DinosaurWeight.Run(result);
            }
            else
            {
                OutputService.ShowMessage("Error.");
            }
        }

        public static void Task2()
        {
            OutputService.ShowMessage("Input file size in bytes: ");
            string msg = InputService.GetUserMsg();
            if(double.TryParse(msg, out double result))
            {
                FileSize.Run(result);
            }
            else
            {
                OutputService.ShowMessage("Error.");
            }
        }

        public static void Task3()
        {
            OutputService.ShowMessage("Input distance in centimeters");
            string msg = InputService.GetUserMsg();
            if(double.TryParse(msg, out double result))
            {
                Distance.Run(result);
            }
            else
            {
                OutputService.ShowMessage("Error.");
            }
        }

        public static void Task4()
        {
            OutputService.ShowMessage("Input a");
            string aMsg = InputService.GetUserMsg();
            OutputService.ShowMessage("Input b");
            string bMsg = InputService.GetUserMsg();
            if(double.TryParse(aMsg, out double a) && double.TryParse(bMsg, out double b))
            {
                MySwap.Run(ref a, ref b);
                OutputService.ShowMessage($"a = {a}\n" +
                                          $"b = {b}\n");
            }
            else
            {
                OutputService.ShowMessage("Error");
            }
        }

        public static void Task5()
        {
            OutputService.ShowMessage("Input candies weight");
            string candWeightMsg = InputService.GetUserMsg();
            OutputService.ShowMessage("Input gelatinous weight");
            string gelWeightMsg = InputService.GetUserMsg();

            if(double.TryParse(candWeightMsg, out double candWeight) && double.TryParse(gelWeightMsg, out double gelWeight))
            {
                CandiesAndGelatinous.Run(candWeight, gelWeight);
            }
            else
            {
                OutputService.ShowMessage("Error.");
            }
        }
    }
}