using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Common
{
    class Common1 : ITask
    {
        public string GetTaskResult(IOService ioService)
        {
            string taskResult;
            if (ioService.GetNumber(out int years, "Enter years"))
            {
                int heads = CountHeads(years);
                int eyes = CountEyes(heads);
                taskResult = $"Heads = {heads}, eyes = {eyes}";
            }
            else
            {
                taskResult = "Incorrect data";
            }
            return taskResult;
        }

        private int CountHeads(int years)
        {
            const int startHeads = 3;
            const int twoHundred = 200, threeHundred = 300;
            int heads;
            //for(int i = 0; i <= years; i++)
            //{
            //    if(i > 0 && i < 200)
            //    {
            //        heads += 3;
            //    }
            //    else if(i >= 200 && i < 300)
            //    {
            //        heads += 2;
            //    }
            //    else if(i >= 300)
            //    {
            //        heads++;
            //    }
            //}

            if (years > 0 && years < twoHundred)
            {
                heads = startHeads + 3 * years;
            }
            else if(years >= twoHundred && years < threeHundred)
            {
                heads = startHeads + 3 * (twoHundred) + 2 * (years - twoHundred);
            }
            else if(years >= threeHundred)
            {
                heads = startHeads + 3 * (twoHundred) + 2 * (threeHundred - twoHundred) + (years - threeHundred);
            }
            else
            {
                throw new Exception("Incorrect data");
            }

            return heads;
        }

        private int CountEyes(int heads)
        {
            return heads * 2;
        }
    }
}
