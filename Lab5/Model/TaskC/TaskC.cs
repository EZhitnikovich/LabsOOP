using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab5.Model.TaskC
{
    class TaskC : ITask
    {
        public string GetTaskResult(int number)
        {
            string taskResult;
            string numInStr = number.ToString();
            if(Enumerable.Range(0, numInStr.Length - 1).All(e => Convert.ToInt32(numInStr[e]) < Convert.ToInt32(numInStr[e + 1])))
            {
                taskResult = "All digits are increasing";
            }
            else if(Enumerable.Range(0, numInStr.Length - 1).All(e => Convert.ToInt32(numInStr[e]) > Convert.ToInt32(numInStr[e + 1])))
            {
                taskResult = "All digits are decreasing";
            }
            else
            {
                taskResult = "The digits don't decrease or increase";
            }

            return taskResult;
        }
    }
}
