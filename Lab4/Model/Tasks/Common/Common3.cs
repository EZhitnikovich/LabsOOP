using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab4.Model.Tasks.Common
{
    class Common3
    {
        public string GetTaskResult(int number)
        {
            var numbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };

            string taskResult = $"is the number is a multiple of the numbers 2, 3, 5, 7, 11, 13, 17, 19? - {numbers.Any(x => number % x == 0)}";

            return taskResult;
        }
    }
}
