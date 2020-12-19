using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Controller
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
                OutputService.ShowMessage("1 - Count the number of digits in a number\n"+
                                          "2 - Check if the digits have the same parity\n"+
                                          "3 - Check the sequence of digits\n"+
                                          "4 - Find the maximum digit in a number\n"+
                                          "5 - Find the Fibonacci number by index");

                string result;

                if(int.TryParse(InputService.GetUserMsg(), out int index) && !(index <= 0 || index > Tasks.Count))
                {
                    result = GetTaskResultByIndex(index);
                }
                else
                {
                    result = "Incorrect index";
                }

                OutputService.ShowMessage(result);
            }
        }

        private string GetTaskResultByIndex(int index)
        {
            string result;

            OutputService.ShowMessage("Input number");

            if (int.TryParse(InputService.GetUserMsg(), out int number))
            {
                result = Tasks[index - 1].GetTaskResult(number);
            }
            else
            {
                result = "Incorrect data";
            }

            return result;
        }
    }
}
