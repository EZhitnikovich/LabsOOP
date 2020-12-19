using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab5.Model.TaskD
{
    class TaskD : ITask
    {
        public string GetTaskResult(int number)
        {
            string taskResult;

            taskResult = $"In number {number} maximum digit: {GetMaximumDigit(number)}";

            return taskResult;
        }

        private int GetMaximumDigit(int number)
        {
            int maxumumNumber = 0;
            number = Math.Abs(number);
            for(; number != 0; number /= 10)
            {
                int temp = number % 10;
                if(temp > maxumumNumber)
                {
                    maxumumNumber = temp;
                }
            }

            return maxumumNumber;
        }
    }
}
