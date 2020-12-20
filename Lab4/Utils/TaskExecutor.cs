using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual;

namespace Lab4.Utils
{
    static class TaskExecutor
    {
        public static string Common1(IOService iOService)
        {
            string result;
            if (iOService.GetNumber(out int number, "Enter years"))
            {
                var task = new Common1();
                result = task.GetTaskResult(number);
            }
            else
            {
                result = "Incorrect data";
            }
            return result;
        }

        public static string Common2(IOService iOService)
        {
            var task = new Common2();
            return task.GetTaskResult(iOService.GetNumbers("Enter the numbers separated by a space"));
        }

        public static string Common3(IOService iOService)
        {
            string result;
            if (iOService.GetNumber(out int number, "Enter number"))
            {
                var task = new Common3();
                result = task.GetTaskResult(number);
            }
            else
            {
                result = "Incorrect data";
            }

            return result;
        }

        public static string IndividualA(IOService iOService)
        {
            var task = new IndividualA();
            return task.GetTaskResult(iOService.GetNumbers("Enter the numbers separated by a space"));
        }

        public static string IndividualB(IOService iOService)
        {
            string result;
            if (iOService.GetNumber(out int number, "Enter mark"))
            {
                var task = new IndividualB();
                result = task.GetTaskResult(number);
            }
            else
            {
                result = "Incorrect data";
            }

            return result;
        }
    }
}
