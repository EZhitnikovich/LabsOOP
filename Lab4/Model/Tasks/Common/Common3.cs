using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Common
{
    class Common3 : ITask
    {
        public string GetTaskResult(IOService ioService)
        {
            string taskResult = "Incorrect data";
            if (ioService.GetNumber(out int number, "Enter number"))
            {
                int[] numbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
                bool isMultiple = false;
                foreach (var elem in numbers)
                {
                    if (number % elem == 0)
                    {
                        isMultiple = true;
                    }
                }

                taskResult = $"is the number is a multiple of the numbers 2, 3, 5, 7, 11, 13, 17, 19? - {isMultiple}";
            }

            return taskResult;
        }
    }
}
