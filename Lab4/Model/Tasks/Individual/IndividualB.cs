using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Individual
{
    class IndividualB : ITask
    {
        public string GetTaskResult(IOService ioService)
        {
            string taskResult = "Incorrect data";

            if(ioService.GetNumber(out int rating, "Enter rating"))
            {
                if (rating >= 0 && rating < 2)
                {
                    taskResult = "very bad";
                }
                else if(rating >= 2 && rating < 4)
                {
                    taskResult = "poor";
                }
                else if(rating >=4 && rating < 6)
                {
                    taskResult = "satisfactory";
                }
                else if(rating >= 6 && rating < 8)
                {
                    taskResult = "good";
                }
                else if(rating >= 8 && rating <= 10)
                {
                    taskResult = "very well";
                }
            }

            return taskResult;
        }
    }
}
