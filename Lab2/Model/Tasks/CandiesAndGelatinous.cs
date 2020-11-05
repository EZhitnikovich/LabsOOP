namespace Lab2
{
    public class CandiesAndGelatinous
    {
        // Task 5

        // public void StartTask()
        // {
        //     double candiesPrice = 12.1;
        //     double gelatinousPrice = 8.9;

        //     double candiesWeight = 1;
        //     double gelatinousWeight = 1;

        //     OutputService.ShowMessage($"Candies price : {candiesPrice * candiesWeight} rub / {candiesWeight}kg\n"+
        //                               $"Gelatinous price : {gelatinousPrice * gelatinousWeight} rub / {gelatinousWeight}kg");

        //     OutputService.ShowMessage("Input candies weight: ");
        //     candiesWeight = Convert.ToDouble(InputService.GetUserMsg());

        //     OutputService.ShowMessage("Input gelatinous weight: ");
        //     gelatinousWeight = Convert.ToDouble(InputService.GetUserMsg());
            
        //     double A = candiesPrice * candiesWeight;
        //     double B = gelatinousPrice * gelatinousWeight;

        //     OutputService.ShowMessage($"Candies price : {candiesPrice * candiesWeight} rub / {candiesWeight}kg\n"+
        //                               $"Gelatinous price : {gelatinousPrice * gelatinousWeight} rub / {gelatinousWeight}kg");

        //     ComparePrices(A, B);
        // }

        public double CandiesPricePerKg{get; set;}
        public double GelatinousPricePerKg{get; set;}

        public CandiesAndGelatinous(double candiesPricePerKg, double gelatinousPricePerKg)
        {
            this.CandiesPricePerKg = candiesPricePerKg;
            this.GelatinousPricePerKg = gelatinousPricePerKg;
        }

        public double ComparePrices(double candiesWeight, double gelatinousWeight)
        {
            double candiesPrice = this.CandiesPricePerKg * candiesWeight;
            double gelatinousPrice = this.GelatinousPricePerKg * gelatinousWeight;

            return candiesPrice / gelatinousPrice;
        }
    }
}