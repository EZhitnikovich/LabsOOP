using static System.Math;

namespace Lab2
{
    public class FileSize
    {
        // Task 3
        public double Bytes{get; private set;}
        public double Kilobytes{get; private set;}
        public double Megabytes{get; private set;}
        public double Gigabytes{get; private set;}

        public FileSize(double bytes)
        {
            this.Bytes = bytes;
            this.Kilobytes = ValueConverter.GetCalcResult(bytes, (int)Pow(2, 10));
            this.Megabytes = ValueConverter.GetCalcResult(bytes, (int)Pow(2, 20));
            this.Gigabytes = ValueConverter.GetCalcResult(bytes, (int)Pow(2, 30));
        }
    }
}