using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Individual
{
    class IndividualA : ITask
    {
        public string GetTaskResult(IOService ioService)
        {
            string taskResult = "Incorrect data";
            if(ioService.GetNumber(out double first, "Enter first number") &&
                ioService.GetNumber(out double second, "Enter second number") &&
                ioService.GetNumber(out double third, "Enter third number"))
            {
                bool isTriangle = false;
                if (first + second > third &&
                    first + third > second &&
                    second + third > first)
                {
                    isTriangle = true;
                }

                taskResult = $"Triangle exists? = {isTriangle}";
            }

            return taskResult;
        }
    }
}
