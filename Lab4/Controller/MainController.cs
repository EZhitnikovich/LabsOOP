using Lab4.Interfaces;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Utils;

namespace Lab4.Controller
{
    class MainController
    {
        public IOutputService OutputService { get; private set; }
        public IOService IO { get; private set; }
        public MainController(IOService iOService, IOutputService outputService)
        {
            OutputService = outputService;
            IO = iOService;
        }

        public void Start()
        {
            while (true)
            {
                OutputService.ShowMessage("1 - Count the number of dragon heads and eyes;\n" +
                                          "2 - \"The Greatest\" (get min/max value);\n" +
                                          "3 - Is the number a multiple of the numbers?(2, 3, 5, 7, 11, 13, 17, 19);\n" +
                                          "4 - determine whether the given sides are sides of a triangle;\n" +
                                          "5 - Description of the mark.\n");
                IO.GetNumber(out int index, "Enter index");
                switch (index)
                {
                    case 1: OutputService.ShowMessage(TaskExecutor.Common1(IO)); break;
                    case 2: OutputService.ShowMessage(TaskExecutor.Common2(IO)); break;
                    case 3: OutputService.ShowMessage(TaskExecutor.Common3(IO)); break;
                    case 4: OutputService.ShowMessage(TaskExecutor.IndividualA(IO)); break;
                    case 5: OutputService.ShowMessage(TaskExecutor.IndividualB(IO)); break;
                    default: OutputService.ShowMessage("Incorrect index"); break;
                }
            }
        }
    }
}
