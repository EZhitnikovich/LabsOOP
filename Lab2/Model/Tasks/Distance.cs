namespace Lab2
{
    public static class Distance
    {
        // Task 3
        public static void Run(double value)
        {
            OutputService.ShowMessage($"Сentimeters = {value}\n");
            OutputService.ShowMessage($"Metres = {ValueConverter.GetCalcResult(value, (int)CoefEnum.metres)}\n");
            OutputService.ShowMessage($"Kilometers = {ValueConverter.GetCalcResult(value, (int)CoefEnum.kilometres)}\n");
        }
    }
}