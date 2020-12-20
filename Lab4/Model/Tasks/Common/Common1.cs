using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Common
{
    class Common1
    {
        public string GetTaskResult(int years)
        {
            string taskResult;
            int heads = CountHeads(years);
            int eyes = CountEyes(heads);
            taskResult = $"Heads = {heads}, eyes = {eyes}";

            return taskResult;
        }

        private int CountHeads(int years)
        {
            if(years < 0)
            {
                throw new ArgumentException("Years can't be negative");
            }

            const int startHeads = 3;
            const int twoHundred = 200, threeHundred = 300;
            int heads = startHeads;

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

            return heads;
        }

        private static int CountEyes(int heads)
        {
            return heads * 2;
        }
    }
}
