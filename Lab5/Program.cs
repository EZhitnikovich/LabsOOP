using Lab5.Controller;
using Lab5.Interfaces;
using Lab5.Model.TaskA;
using Lab5.Model.TaskB;
using Lab5.Model.TaskC;
using Lab5.Model.TaskD;
using Lab5.Model.TaskE;
using Lab5.Utils;
using Lab5.View;
using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITask> tasks = new List<ITask>
            {
                new TaskA(),
                new TaskB(),
                new TaskC(),
                new TaskD(),
                new TaskE()
            };
            IInputService inputService = new InputService();
            IOutputService outputService = new OutputService();

            MainController mainController = new MainController(inputService, outputService, tasks);

            mainController.Start();
        }
    }
}
