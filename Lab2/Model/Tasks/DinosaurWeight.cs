namespace Lab2
{
    public static class DinosaurWeight
    {
        // Task1
        public static void Run(double value)
        {
            OutputService.ShowMessage($"Grams = {value}\n");
            OutputService.ShowMessage($"Kilograms = {ValueConverter.GetCalcResult(value, (int)CoefEnum.kilograms)}\n");
            OutputService.ShowMessage($"Centners = {ValueConverter.GetCalcResult(value, (int)CoefEnum.centners)}\n");
            OutputService.ShowMessage($"Tons = {ValueConverter.GetCalcResult(value, (int)CoefEnum.tons)}\n");
        }
    }
}