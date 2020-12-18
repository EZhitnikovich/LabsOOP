using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Utils
{
    class IOService
    {
        private readonly IInputService inputService;
        private readonly IOutputService outputService;
        public IOService(IInputService iService, IOutputService oService)
        {
            inputService = iService;
            outputService = oService;
        }

        public bool GetNumber(out int number)
        {
            return int.TryParse(inputService.GetUserMsg(), out number);
        }

        public bool GetNumber(out int number, string message)
        {
            outputService.ShowMessage(message);
            return int.TryParse(inputService.GetUserMsg(), out number);
        }

        public bool GetNumber(out double number, string message)
        {
            outputService.ShowMessage(message);
            return double.TryParse(inputService.GetUserMsg(), out number);
        }

        public int[] GetNumbers(string message)
        {
            outputService.ShowMessage(message);
            int[] resultParams = inputService.GetUserMsg().Split().Where(x => int.TryParse(x, out int n)).Select(int.Parse).ToArray();
            return resultParams;
        }
    }
}
