using System;
using System.Linq;
using Lab6.Model.Individual;
using Lab6.Interfaces;
using System.Collections.Generic;
using Lab6.Utils;
using Lab6.View;
using Lab6.Controller;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITask> tasks = new List<ITask>()
            {
                new Individual()
            };
            IInputService inputService = new InputService();
            IOutputService outputService = new OutputService();

            MainController mainController = new MainController(inputService, outputService, tasks);

            mainController.Start();
        }
    }
}
