using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Model.TaskA
{
    class TaskA : ITask
    {
        public string GetTaskResult(int number)
        {
            string taskResult;

            taskResult = $"Number of digits: {number.ToString().Length}";

            return taskResult;
        }
    }
}
