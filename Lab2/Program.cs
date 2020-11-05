using Lab2.Tasks;
using Lab2.Services;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

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
                    case "1": Task1.StartTask(); break;
                    case "2": Task2.StartTask(); break;
                    case "3": Task3.StartTask(); break;
                    case "4": Task4.StartTask(); break;
                    case "5": Task5.StartTask(); break;
                    default:
                        OutputService.ShowMessage("Incorrect command");
                        break;
                }
            }
        }
    }
}
