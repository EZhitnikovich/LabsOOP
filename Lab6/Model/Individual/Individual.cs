using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab6.Interfaces;

namespace Lab6.Model.Individual
{
    class Individual : ITask
    {
        public string GetTaskResult(double[] numbers)
        {
            if(numbers is null)
            {
                throw new Exception("Array is null");
            }
            if (!numbers.Any())
            {
                throw new Exception("Array is empty");
            }
            string taskResult = $"Index of maximum abs value: {GetMaxAbsElementIndex(numbers)}, " +
                                $"sum after first positive: {GetSumAfterFirstPositive(numbers)}";
            return taskResult;
        }

        public double GetSumAfterFirstPositive(double[] numbers)
        {
            if (numbers is null)
            {
                throw new Exception("Array is null");
            }
            if (!numbers.Any())
            {
                throw new Exception("Array is empty");
            }
            int firstPositiveIndex = Array.IndexOf(numbers, numbers.FirstOrDefault(x => x > 0.0));
            var sum = numbers[++firstPositiveIndex..].Sum();
            return sum;
        }

        public double GetMaxAbsElementIndex(double[] numbers)
        {
            if (numbers is null)
            {
                throw new Exception("Array is null");
            }
            if (!numbers.Any())
            {
                throw new Exception("Array is empty");
            }
            var maxAbs = numbers.Aggregate((a, b) => (Math.Abs(a) > Math.Abs(b)) ? a : b);
            return Array.IndexOf(numbers, maxAbs);
        }
    }
}
