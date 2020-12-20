using Lab4.Controller;
using Lab4.Interfaces;
using Lab4.Model.Tasks.Common;
using Lab4.Model.Tasks.Individual;
using Lab4.Utils;
using Lab4.View;
using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSerivce = new InputService();
            var outputService = new OutputService();
            var ioService = new IOService(inputSerivce, outputService);

            var mainController = new MainController(ioService, outputService);

            mainController.Start();
        }
    }
}
