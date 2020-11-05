namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            MainController mainController = new MainController();

            while(run)
            {
                OutputService.ShowMessage("0 - Stop program\n" +
                                          "1 - Task with weight\n" +
                                          "2 - Task with file size\n" +
                                          "3 - Task with distance\n" +
                                          "4 - Task with permutation\n" +
                                          "5 - Task with candies price\n");

                string item = InputService.GetUserMsg();
                switch (item)
                {
                    case "0":
                        run = false;
                        break;
                    case "1": mainController.CalculateDinosaurWeight(); break;
                    case "2": mainController.CalculateFileSize(); break;
                    case "3": mainController.CalculateDistance(); break;
                    case "4": mainController.MakeSwap(); break;
                    case "5": mainController.CompareCandyPrices(); break;
                    default:
                        OutputService.ShowMessage("Incorrect command");
                        break;
                }
            }
        }
    }
}
