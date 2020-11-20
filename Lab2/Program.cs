namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while(run)
            {
                OutputService.ShowMessage("Input index:\n"+
                                          "0 - exit\n"+
                                          "1 - Convert dinosaur weight\n"+
                                          "2 - Convert file size\n"+
                                          "3 - Convert distance\n"+
                                          "4 - Swap numbers\n"+
                                          "5 - Candies shop\n");
                string index = InputService.GetUserMsg();
                switch (index)
                {
                    case "0": run = false; break;
                    case "1": TaskExecutor.Task1(); break;
                    case "2": TaskExecutor.Task2(); break;
                    case "3": TaskExecutor.Task3(); break;
                    case "4": TaskExecutor.Task4(); break;
                    case "5": TaskExecutor.Task5(); break;
                    default: OutputService.ShowMessage("Incorrect index\n"); break;
                }
            }
        }
    }
}
