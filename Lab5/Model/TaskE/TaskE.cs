using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Model.TaskE
{
    class TaskE : ITask
    {
        public string GetTaskResult(int number)
        {
            string taskResult;

            try
            {
                taskResult = $"Fibonacci number on the position {number}: {GetFibonacciNumber(number)}";
            }
            catch
            {
                taskResult = "Incorrect data";
            }

            return taskResult;
        }

        private long GetFibonacciNumber(int position)
        {
            if(position < 0)
            {
                throw new Exception("The position can't be negative");
            }

            long oldValue = 0;
            long value = 1;
            long sum = 0;
            int index = 1;
            while(index < position)
            {
                sum = value;
                value += oldValue;
                oldValue = sum;
                index++;
            }

            return value;
        }
    }
}
