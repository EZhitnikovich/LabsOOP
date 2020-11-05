namespace Lab2
{
    public class Distance
    {
        // Task 3
        public double Centimeters{get; private set;}
        public double Metres{get; private set;}
        public double Kilometers{get; private set;}

        public Distance(double centimeters)
        {
            this.Centimeters = centimeters;
            this.Metres = ValueConverter.GetCalcResult(centimeters, 100);
            this.Kilometers = ValueConverter.GetCalcResult(centimeters, 100*1000);
        }
    }
}