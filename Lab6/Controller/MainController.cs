using System;
using System.Collections.Generic;
using System.Text;
using Lab6.Interfaces;

namespace Lab6.Controller
{
    class MainController
    {
        public IInputService InputService { get; private set; }
        public IOutputService OutputService { get; private set; }
        public List<ITask> Tasks { get; private set; }

        public MainController(IInputService _inputService, IOutputService _outputService, List<ITask> _tasks)
        {
            InputService = _inputService;
            OutputService = _outputService;
            Tasks = _tasks;
        }

        public void Start()
        {
            while (true)
            {
                OutputService.PrintLine("1 - Get the index of the maximum abs element and the amount after the first positive");

                string result;

                if (int.TryParse(InputService.GetUserMsg(), out int index) && !(index <= 0 || index > Tasks.Count))
                {
                    result = GetTaskResultByIndex(index);
                }
                else
                {
                    result = "Incorrect index";
                }

                OutputService.PrintLine(result);
            }
        }

        private string GetTaskResultByIndex(int index)
        {
            string result;

            OutputService.PrintLine("Input array length");

            if (int.TryParse(InputService.GetUserMsg(), out int number))
            {
                OutputService.PrintLine("Generated array:");
                var arr = GenerateRandomDoubleArray(number);
                for (int i = 0; i < arr.Length; OutputService.Print(arr[i].ToString() + " "), i++);
                result = Tasks[index - 1].GetTaskResult(arr);
            }
            else
            {
                result = "Incorrect data";
            }

            return result;
        }

        private double[] GenerateRandomDoubleArray(int length, int start = -50, int end = 50)
        {
            if(length < 1)
            {
                throw new Exception("Length must be more than 1");
            }
            Random rand = new Random();
            double[] arr = new double[length];
            for(int i = 0; i < length; i++)
            {
                arr[i] = Math.Round(rand.NextDouble() * (start - end) + end, 2);
            }
            return arr;
        }
    }
}
