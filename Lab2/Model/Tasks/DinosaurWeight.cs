namespace Lab2
{
    public class DinosaurWeight
    {
        // Task1
        public double Grams{get; private set;}
        public double Kilograms{get; private set;}
        public double Centners{get; private set;}
        public double Tons{get; private set;}

        public DinosaurWeight(double grams)
        {
            this.Grams = grams;
            this.Kilograms = ValueConverter.GetCalcResult(grams, 1000);
            this.Centners = ValueConverter.GetCalcResult(Centners, 1000 * 100);
            this.Tons = ValueConverter.GetCalcResult(Centners, 1000 * 1000);
        }
    }
}