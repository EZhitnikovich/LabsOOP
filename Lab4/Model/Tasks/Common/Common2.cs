using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Model.Tasks.Common
{
    class Common2 : ITask
    {
        public string GetTaskResult(IOService ioService)
        {
            int[] numbers = ioService.GetNumbers("Enter numbers in one line (separated by a space)");
            string taskResult = "Incorrect data";
            if (numbers.Length != 0)
            {
                bool isAllEqual = true;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] != numbers[i + 1])
                    {
                        isAllEqual = false;
                    }
                }

                if (isAllEqual)
                    taskResult =  "All numbers are equal";
                else
                    taskResult = $"Maximum = {numbers.Max()}, minimum = {numbers.Min()}";
            }

            return taskResult;
        }
    }
}
