using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model.Tasks.Individual
{
    class IndividualA
    {
        public string GetTaskResult(int[] arr)
        {
            string taskResult;

            try
            {
                taskResult = $"Triangle exists? = {CheckTriangle(arr)}";
            }
            catch
            {
                taskResult = "Incorrect data";
            }

            return taskResult;
        }

        private bool CheckTriangle(int[] arr)
        {
            if(arr.Length != 3)
            {
                throw new Exception("The triangle must have 3 sides");
            }

            bool isTriangle = false;
            if (arr[0] + arr[1] > arr[2] &&
                arr[0] + arr[2] > arr[1] &&
                arr[1] + arr[2] > arr[0])
            {
                isTriangle = true;
            }

            return isTriangle;
        }
    }
}
