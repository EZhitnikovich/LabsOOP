using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.Model.TaskB
{
    class TaskB : ITask
    {
        public string GetTaskResult(int number)
        {
            string taskResult;

            if(number.ToString().All(x => Convert.ToInt32(x) % 2 == 0))
            {
                taskResult = "All digits are even";
            }
            else if(number.ToString().All(x => Convert.ToInt32(x) % 2 != 0))
            {
                taskResult = "All difits are odd";
            }
            else
            {
                taskResult = "The number has even and odd digits";
            }

            return taskResult;
        }
    }
}
