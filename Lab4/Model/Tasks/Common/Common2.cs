using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Model.Tasks.Common
{
    class Common2
    {
        public string GetTaskResult(int[] numbers)
        {
            string taskResult;
            try
            {
                taskResult = CheckNumbers(numbers);
            }
            catch
            {
                taskResult = "Incorrect data";
            }
            return taskResult;
        }

        private string CheckNumbers(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new Exception("Array can't be empty");
            }

            string result;

            if (numbers.All(x => x == numbers[0]))
                result = "All numbers are equal";
            else
                result = $"Maximum = {numbers.Max()}, minimum = {numbers.Min()}";

            return result;
        }
    }
}
