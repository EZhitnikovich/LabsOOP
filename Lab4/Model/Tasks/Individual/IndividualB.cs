using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Individual
{
    class IndividualB
    {
        public string GetTaskResult(int number)
        {
            string taskResult = GetDescription(number);
            
            return taskResult;
        }

        private string GetDescription(int rating)
        {
            string desctiption;

            if (rating >= 0 && rating < 2)
            {
                desctiption = "very bad";
            }
            else if (rating >= 2 && rating < 4)
            {
                desctiption = "poor";
            }
            else if (rating >= 4 && rating < 6)
            {
                desctiption = "satisfactory";
            }
            else if (rating >= 6 && rating < 8)
            {
                desctiption = "good";
            }
            else if (rating >= 8 && rating <= 10)
            {
                desctiption = "very well";
            }
            else
            {
                desctiption = "Unknown";
            }

            return desctiption;
        }
    }
}
