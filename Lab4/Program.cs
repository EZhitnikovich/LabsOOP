using Lab4.Interfaces;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual;
using Lab4.Utils;
using Lab4.View;
using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITask> tasks = new List<ITask>
            {
                new Common1(),
                new Common2(),
                new Common3(),
                new IndividualA(),
                new IndividualB()
            };

            InputService inputService = new InputService();
            OutputService outputService = new OutputService();
            IOService ioService = new IOService(inputService, outputService);

            while (true)
            {
                outputService.ShowMessage("1 - Count the dragon heads;\n"+
                                          "2 - \"The Greatest\" (get min/max value);\n" +
                                          "3 - Is the number a multiple of the numbers?(2, 3, 5, 7, 11, 13, 17, 19);\n" +
                                          "4 - determine whether the given sides are sides of a triangle;\n" +
                                          "5 - Description of the mark.\n");

                if(ioService.GetNumber(out int index, "Enter index"))
                {
                    string result = default;

                    if (index <= 0 || index > tasks.Count)
                    {
                        result = "Incorrect index" ;
                    }
                    else
                    {
                        result = tasks[index - 1].GetTaskResult(ioService);
                    }

                    outputService.ShowMessage(result);
                }
            }
        }
    }
}
